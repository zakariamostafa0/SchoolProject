﻿using SchoolProject.Core.Features.Department.Queries.Results;

namespace SchoolProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIdQuery : IRequest<Response<GetDepartmentByIdResponse>>
    {
        public int Id { get; set; }
        public int StudentPageNumber { get; set; }
        public int StudentPageSize { get; set; }

    }
}
