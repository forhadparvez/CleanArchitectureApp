using CleanArch.CoreLibrary.AutoMapperProfiles;
using ClearArch.ServiceLibrary;
using ClearArch.ServiceLibrary.Managers;
namespace CleanArch.TestingConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfiguration.Configure();

            StudentManager studentManager = new StudentManager();
            // Save

            // Update
            int success = studentManager.Update(1, new CoreLibrary.Models.Student
            {
                Id = 1,
                Name = "Mr B",
                DepartmentId = 1,
                Address = "Dinajpur",
                Code = "02",
                Roll = "0222"
            });

            System.Console.WriteLine(success);

        }
    }
}
