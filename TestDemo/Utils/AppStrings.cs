using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestDemo.Utils
{
    public static class AppStrings
    {
        public static class ErrorMessages
        {
            public const string Required = "This field is required.";
        }

        public static class DisplayNames
        {
            public const string Manufacturer = "Manufacturer";
            public const string ProductCode = "Product code";
        }

        public static class AppRoleNames
        {
            public const string Admin = "admin";
            public const string Manager = "manager";
            public const string Customer = "customer";
        }
    }
}