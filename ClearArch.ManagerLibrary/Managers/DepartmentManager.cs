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
    public class DepartmentManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentManager()
        {
            _unitOfWork=new UnitOfWork(new CleanArchDbContext());
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _unitOfWork.Department.GetAll();
        }
    }
}
