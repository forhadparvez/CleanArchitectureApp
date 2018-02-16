using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using CleanArch.CoreLibrary;
using CleanArch.CoreLibrary.Dtos;
using CleanArch.CoreLibrary.Models;
using ClearArch.ManagerLibrary.Managers;

namespace CleanArch.MvcUi.Controllers.Api
{
    public class StudentsController : ApiController
    {
        private readonly StudentManager _studentManager;

        public StudentsController()
        {
            _studentManager = new StudentManager();
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var students = _studentManager.GetStudents();
            var studentDots = students.Select(Mapper.Map<Student, StudentDto>);
            return Ok(studentDots);
        }

        [HttpPost]
        public IHttpActionResult Save(StudentDto studentDto)
        {
            var student = Mapper.Map<StudentDto, Student>(studentDto);
            var successCount = _studentManager.Save(student);
            if (successCount>0)
            {
                return Ok(successCount);
            }
            return BadRequest();
        }

        [HttpPut]
        public IHttpActionResult Update(int id,StudentDto studentDto)
        {
            var student = Mapper.Map<StudentDto, Student>(studentDto);
            var successCount = _studentManager.Update(id, student);
            if (successCount>0)
            {
                return Ok(successCount);
            }
            return BadRequest();
        }
    }
}
