using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArch.CoreLibrary.Models;

namespace CleanArch.CoreLibrary.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }

        public string Roll { get; set; }
        public string Address { get; set; }
    }
}
