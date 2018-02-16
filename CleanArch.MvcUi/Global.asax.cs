using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using CleanArch.CoreLibrary.Dtos;
using CleanArch.CoreLibrary.Models;
using CleanArch.CoreLibrary.ViewModels;

namespace CleanArch.MvcUi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c =>
            {
                c.CreateMap<Student, StudentDto>();
                c.CreateMap<StudentDto, Student>();

                c.CreateMap<Student, StudentViewModel>();
                c.CreateMap<StudentViewModel, Student>();
            });



            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
