using CleanArch.CoreLibrary;
using CleanArch.CoreLibrary.Models;
using CleanArch.PersistenceLibrary;
using System.Collections.Generic;

namespace ClearArch.ServiceLibrary.Managers
{
    public class DepartmentManager
    {
        private readonly IUnitOfWork _unitOfWork;

        public DepartmentManager()
        {
            _unitOfWork = new UnitOfWork(new CleanArchDbContext());
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _unitOfWork.Department.GetAll();
        }
    }
}
