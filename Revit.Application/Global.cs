using Prism.Ioc;
using Revit.Accounts.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revit.Entity
{
    public static class Global
    {
        public static LoginedUserDto User { get; set; } = null;

        private static IServiceProvider _provider;
        public static IServiceProvider Provider
        {
            get { return _provider; }
            set { _provider = value; }
        }

        public static bool IsDebug { get; set; } = false;



        private static IContainerExtension _containerExtension;
        public const  string HOST= "http://localhost:5177/";

        public static IContainerExtension ContainerExtension
        {
            get { return _containerExtension; }
            set { _containerExtension = value; }
        }

        public static string Token { get; set; }
    }
}
