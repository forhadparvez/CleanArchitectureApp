using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary;
using CleanArch.CoreLibrary.Models;
using CleanArch.PersistenceLibrary;

namespace ClearArch.ManagerLibrary.Managers
{
    public class StudentManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentManager()
        {
            _unitOfWork = new UnitOfWork(new CleanArchDbContext());
        }

        public Student GetStudentById(int id)
        {
            return _unitOfWork.Student.Get(id);
        }

        public Student GetStudentByCode(string code)
        {
            return _unitOfWork.Student.SingleOrDefault(c => c.Code == code);
        }

        public Student GetStudentByRoll(string name)
        {
            return _unitOfWork.Student.SingleOrDefault(c => c.Name == name);
        }

        public IEnumerable<Student> GetStudents()
        {
            return _unitOfWork.Student.GetAll();
        }

        public IEnumerable<Student> GetStudentsWithDepartment()
        {
            return _unitOfWork.Student.GetStudentsWithDepartment();
        }

        public IEnumerable<Student> FindStudentsByName(string name)
        {
            return _unitOfWork.Student.Find(c => c.Name == name);
        }

        public int Save(Student student)
        {
            _unitOfWork.Student.Add(student);
            return _unitOfWork.Complete();
        }

        public int Update(int id,Student student)
        {
            var dbStudent = _unitOfWork.Student.Get(id);
            dbStudent.Code = student.Code;
            dbStudent.Name = student.Name;
            dbStudent.Roll = student.Roll;
            dbStudent.Address = student.Address;
            return _unitOfWork.Complete();
        }


        public bool IsCodeExist(string code)
        {
            var isCodeExist = false;
            var student = _unitOfWork.Student.SingleOrDefault(c => c.Code == code);
            if (student!=null)
                isCodeExist = true;
            
            return isCodeExist;
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
