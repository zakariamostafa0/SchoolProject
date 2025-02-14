﻿global using SchoolProject.Data.Helpers.Enums;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentQueryHandler : ResponseHandler,
                                        IRequestHandler<GetStudentListQuery, Response<List<GetStudentListResponse>>>,
                                        IRequestHandler<GetStudentByIdQuery, Response<GetStudentListResponse>>,
                                        IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<GetStudentPaginatedListResponse>>
    {
        #region Fields
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public StudentQueryHandler(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }
        #endregion

        #region Handles Methods
        public async Task<Response<List<GetStudentListResponse>>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsListAsync();
            var studentsDTO = _mapper.Map<List<GetStudentListResponse>>(students);
            return Success(studentsDTO);
        }

        public async Task<Response<GetStudentListResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var student = await _studentService.GetStudentByIdAsync(request.Id);
            if (student == null)
                return NotFound<GetStudentListResponse>("NO student was found!!");
            var studentResponse = _mapper.Map<GetStudentListResponse>(student);
            return Success(studentResponse);
        }

        public Task<PaginatedResult<GetStudentPaginatedListResponse>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
        {
            //Take from the student and put in the response
            Expression<Func<Student, GetStudentPaginatedListResponse>> expression =
                 s => new GetStudentPaginatedListResponse(s.StudID, s.Name, s.Address, s.Department.DName);

            var querable = _studentService.GetFilterStudentPaginatedQuerable(request.OrederBy, request.Search)
                                          .Select(expression)
                                          .ToPaginatedListAsync(request.PageNumber ??= 0, request.PageSize ??= 0);
            return querable;

        }
        #endregion
    }
}
