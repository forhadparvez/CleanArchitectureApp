using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary.Repositories;

namespace CleanArch.CoreLibrary
{
    public interface IUnitOfWork:IDisposable
    {
        IStudentRepository Student { get; }
        IDepartmentRepository Department { get; }

        int Complete();
    }
}
