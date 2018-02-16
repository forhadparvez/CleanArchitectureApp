using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary;
using CleanArch.CoreLibrary.Repositories;
using CleanArch.PersistenceLibrary.Repositories;

namespace CleanArch.PersistenceLibrary
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly CleanArchDbContext _context;


        public IStudentRepository Student { get; private set; }
        public IDepartmentRepository Department { get; private set; }

        public UnitOfWork(CleanArchDbContext context)
        {
            _context = context;

            Student=new StudentRepository(context);
            Department=new DepartmentRepository(context);
        }

        
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
