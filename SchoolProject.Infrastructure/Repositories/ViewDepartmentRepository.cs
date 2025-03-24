﻿using SchoolProject.Data.Entities.Views;
using SchoolProject.Infrastructure.Views;

namespace SchoolProject.Infrastructure.Repositories
{
    public class ViewDepartmentRepository : GenericRepositoryAsync<ViewDepartment>, IViewRepository<ViewDepartment>
    {
        #region Filds
        private readonly DbSet<ViewDepartment> viewDepartmentRepository;

        #endregion

        #region Constructors
        public ViewDepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            viewDepartmentRepository = dbContext.Set<ViewDepartment>();
        }

        #endregion

        #region Handles Methods

        #endregion
    }
}
