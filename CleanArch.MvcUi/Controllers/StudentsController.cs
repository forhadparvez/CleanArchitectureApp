using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CleanArch.CoreLibrary.Models;
using CleanArch.CoreLibrary.ViewModels;
using ClearArch.ManagerLibrary.Managers;

namespace CleanArch.MvcUi.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentManager _studentManager;

        public StudentsController()
        {
            _studentManager = new StudentManager();
        }

        // GET: Students
        public ActionResult Index()
        {
            var students = _studentManager.GetStudents().Select(Mapper.Map<Student, StudentViewModel>);
            return View("StudentList", students);
        }

        [HttpGet]
        public ActionResult New()
        {
            return View("StudentForm");
        }
    }
}