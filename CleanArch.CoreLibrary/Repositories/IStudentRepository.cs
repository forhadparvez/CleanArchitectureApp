using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary.Models;

namespace CleanArch.CoreLibrary.Repositories
{
    public interface IStudentRepository: IRepository<Student>
    {
        IEnumerable<Student> GetStudentsWithDepartment();
    }
}
