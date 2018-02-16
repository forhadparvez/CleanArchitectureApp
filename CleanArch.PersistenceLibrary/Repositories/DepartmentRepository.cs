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
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CleanArchDbContext _context;

        public DepartmentRepository(CleanArchDbContext context)
        {
            _context = context;
        }

        public Department Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> Find(Expression<Func<Department, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Department SingleOrDefault(Expression<Func<Department, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Department> entities)
        {
            throw new NotImplementedException();
        }

        public void Remove(Department entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Department> entities)
        {
            throw new NotImplementedException();
        }
    }
}
