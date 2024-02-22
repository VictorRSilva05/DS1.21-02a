using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20.Enums;

namespace ConsoleApp20
{
    internal class Employee
    {
        //Victor Rafael da Silva
        public string Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public string Role { get; set; }

        const float MANAGER_ = 0.1f;
        const float ENGINEER_ = 0.2f;
        const float TECHNICIAN_ = 0.3f;
        const float OTHER_ = 0.4f;

        public Employee(string id, string name, float salary, string role)
        {
            Id = id;
            Name = name;
            Salary = salary;
            Role = role;
        }

        public void RaiseSalary(float salary, Roles role)
        {
            switch(role)
            {
                case Roles.Manager:
                     Salary += salary * MANAGER_;      
                    break;
                case Roles.Engineer:
                     Salary += salary * ENGINEER_; 
                    break;
                case Roles.Technician:
                     Salary += salary * TECHNICIAN_;
                    break;
                default:
                     Salary += salary * OTHER_;
                    break;
            }
        }

        public override string ToString()
        {
            return Name
                + "\nId:  "
                + Id
                + "\nSalary: "
                + Salary
                + "\nRole: "
                + Role;
        }
    }
}
