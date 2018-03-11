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
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Student> GetStudentsWithDepartment()
        {
           return Context.Set<Student>().Include(c=>c.Department);
        }
    }
}
