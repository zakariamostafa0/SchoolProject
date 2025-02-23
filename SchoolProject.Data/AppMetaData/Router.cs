﻿namespace SchoolProject.Data.AppMetaData
{
    public static class Router
    {
        public const string root = "Api";
        public const string version = "V1";
        public const string Rule = root + "/" + version + "/";


        private const string Id = "/{id:int}";
        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + Id;
            public const string Create = Prefix + "/Create";
            public const string Paginate = Prefix + "/Paginate";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "/Delete" + Id;

        }
        public static class DepartmentRouting
        {
            public const string Prefix = Rule + "Department";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "Id";
            public const string Create = Prefix + "/Create";
            public const string Paginate = Prefix + "/Paginate";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "/Delete" + Id;

        }
        public static class AccountRouting
        {
            public const string Prefix = Rule + "Account";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + Id;
            public const string Create = Prefix + "/Create";
            public const string Paginate = Prefix + "/Paginate";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "/Delete" + Id;

        }
    }
}
