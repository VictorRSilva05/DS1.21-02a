using ConsoleApp20.Enums;
using System.Globalization;
namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Victor Rafael da Silva
            Console.WriteLine("Enter employee data:");
            Console.Write("ID: ");
            string id = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            float salary = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Role: ");
            string role = Console.ReadLine();

            Employee employee = new Employee(id, name, salary, role);

            Console.WriteLine("\n" + employee);

            
            employee.RaiseSalary(salary, Enum.Parse<Roles>(role));
            Console.WriteLine("Updated Salary:" + employee.Salary);

        }
    }
}
