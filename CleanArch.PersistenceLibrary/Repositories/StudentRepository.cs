using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary.Models;
using CleanArch.CoreLibrary.Repositories;

namespace CleanArch.PersistenceLibrary.Repositories
{
    public class StudentRepository:IStudentRepository
    {
        private readonly CleanArchDbContext _context;


        public StudentRepository(CleanArchDbContext context)
        {
            _context = context;
        }

        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }

        public IEnumerable<Student> Find(Expression<Func<Student, bool>> predicate)
        {
            return _context.Students.Where(predicate);
        }

        public Student SingleOrDefault(Expression<Func<Student, bool>> predicate)
        {
            return _context.Students.SingleOrDefault(predicate);
        }

        public void Add(Student entity)
        {
            _context.Students.Add(entity);
        }

        public void AddRange(IEnumerable<Student> entities)
        {
            _context.Students.AddRange(entities);
        }

        public void Remove(Student entity)
        {
            _context.Students.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Student> entities)
        {
            _context.Students.RemoveRange(entities);
        }

        public IEnumerable<Student> GetStudentsWithDepartment()
        {
           return _context.Students.Include(c=>c.Department);
        }
    }
}
