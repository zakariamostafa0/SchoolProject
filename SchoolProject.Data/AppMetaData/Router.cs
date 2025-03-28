﻿namespace SchoolProject.Data.AppMetaData
{
    public static class Router
    {
        public const string root = "Api";
        public const string version = "V1";
        public const string Rule = root + "/" + version + "/";


        private const string IntId = "/{id:int}";
        private const string StringId = "/{id}";

        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";
            public const string List = Prefix /*+ "/List"*/;
            public const string GetById = Prefix + IntId;
            public const string Create = Prefix /*+ "/Create"*/;
            public const string Paginate = Prefix + "/Paginate";
            public const string Update = Prefix /*+ "/Update"*/;
            public const string Delete = Prefix /*+ "/Delete"*/ + IntId;

        }
        public static class DepartmentRouting
        {
            public const string Prefix = Rule + "Department";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "Id";
            public const string Create = Prefix + "/Create";
            public const string Paginate = Prefix + "/Paginate";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "/Delete" + IntId;
            public const string GetDepartmentsStudentsCount = Prefix + "Departments-Students-Count";
            public const string GetDepartmentStudentsCountById = Prefix + "Departments-Students-Count" + IntId;


        }
        public static class InstructorRouting
        {
            public const string Prefix = Rule + "Instructor";
            public const string List = Prefix /*+ "/List"*/;
            public const string GetById = Prefix + IntId;
            public const string Create = Prefix /*+ "/Create"*/;
            public const string Paginate = Prefix + "/Paginate";
            public const string Update = Prefix /*+ "/Update"*/;
            public const string Delete = Prefix /*+ "/Delete"*/ + IntId;

            public const string GetSalarySummation = Prefix + "/GetSalarySummation";

        }
        public static class AccountRouting
        {
            public const string Prefix = Rule + "Account";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + IntId;
            public const string GetUser = Prefix + "/GetUser";
            public const string Create = Prefix + "/Create";
            public const string Paginate = Prefix + "/Paginate";
            public const string Edit = Prefix + "/Edit";
            public const string ChangePassword = Prefix + "/ChangePassword";
            public const string Delete = Prefix + "/Delete" + StringId;
            public const string SendEmailConfirmationAgain = Prefix + "/SendEmailConfirmationAgain";
            public const string SendEmailResetPasswordCode = Prefix + "/SendEmailResetPasswordCode";
            public const string ConfirmResetPasswordCode = Prefix + "/ConfirmResetPasswordCode";
            public const string ResetPassword = "/api/account/resetassword";

            //public const string RemoveUserRoles = Prefix + "/RemoveUserRoles";
            //public const string AddUserRoles = Prefix + "/AddUserRoles";


        }
        public static class AuthenticationRouting
        {
            public const string Prefix = Rule + "Authentication";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + IntId;
            public const string GetUser = Prefix + "/GetUser";
            public const string Login = Prefix + "/Login";
            public const string RefreshToken = Prefix + "/RefreshToken";
            public const string ValidateToken = Prefix + "/ValidateToken";
            public const string Paginate = Prefix + "/Paginate";
            public const string Edit = Prefix + "/Edit";
            public const string ChangePassword = Prefix + "/ChangePassword";
            public const string Delete = Prefix + "/Delete" + StringId;
            public const string ConfirmEmail = "/Api/Authentication/ConfirmEmail";
        }

        public static class AuthorizationRouting
        {
            public const string Prefix = Rule + "Authorization";
            public const string Role = Prefix + "/Role";
            public const string Claim = Prefix + "/Claim";
            public const string CreateRole = Role /*+ "/Create"*/;
            public const string UpdateRole = Role /*+ "/Update"*/;
            public const string DeleteRole = Role /*+ "/Delete"*/ + StringId;
            public const string GetAllRoles = Role;
            public const string GetRoleById = Role + StringId;
            public const string GetUserRoles = Role + "/GetRolesForUser" + "/{userId}";
            public const string UpdateUserRoles = Role + "/UpdateUserRoles";
            public const string GetUserClaims = Claim + "/GetUserClaims" + "/{userId}";
            public const string UpdateUserClaims = Claim + "/UpdateUserClaims";
        }
        public static class EmailRouting
        {
            public const string Prefix = Rule + "Email";
            //public const string SendEmail = Rule + "/SendEmail";
        }
    }
}
