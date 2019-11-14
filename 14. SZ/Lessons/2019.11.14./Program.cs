using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Employer employer = new Employer();

            List<string> employeeDays = new List<string>();
            List<string> employerDays = new List<string>();

            employee.GetAllValues(employeeDays);
            employer.GetAllValues(employerDays);

            for (int i = 0; i < employeeDays.Count; ++i)
            {
                if (employerDays.Contains(employeeDays[i]))
                {
                    Console.WriteLine(employeeDays[i]);
                }
            }
        }
    }
}
