using ClearArch.ServiceLibrary.Managers;
namespace CleanArch.TestingConsoleUi
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            // Save

            // Update
            int success = studentManager.Update(1, new CoreLibrary.Models.Student
            {

            });

            System.Console.WriteLine(success);

        }
    }
}
