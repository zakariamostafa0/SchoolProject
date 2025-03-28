﻿using Microsoft.AspNetCore.Authorization;
using SchoolProject.Core.Features.Department.Queries.Models;

namespace SchoolProject.Api.Controllers
{
    [ApiController]
    [Authorize(Roles = nameof(UserRoles.Admin))]
    public class DepartmentController : AppControllerBase
    {
        [HttpGet(Router.DepartmentRouting.GetById)]
        public async Task<IActionResult> GetDepartmentByIdAsync([FromQuery] GetDepartmentByIdQuery query)
        {
            var student = await Mediator.Send(query);
            return NewResult(student);
        }
        [HttpGet(Router.DepartmentRouting.GetDepartmentsStudentsCount)]
        public async Task<IActionResult> GetDepartmentsStudentsCount()
        {
            var student = await Mediator.Send(new GetDepartmentsStudentsCountQuery());
            return NewResult(student);
        }
        [HttpGet(Router.DepartmentRouting.GetDepartmentStudentsCountById)]
        public async Task<IActionResult> GetDepartmentStudentsCountById([FromRoute] int id)
        {
            var student = await Mediator.Send(new GetDepartmentStudentsCountByIdQuery(id));
            return NewResult(student);
        }
    }
}
