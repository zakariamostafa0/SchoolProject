﻿namespace SchoolProject.Core.Mapping.Departments
{
    public partial class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            GetDepartmentByIdMapping();
            GetDepartmentsStudentsCountMapping();
            GetDepartmentStudentsCountByIdMapping();
        }
    }
}
