using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Employee : Person
    {
        private enum WorkDays { Monday, Tuesday, Wednesday, Thursday, Friday}
        public override void GetAllValues(List<string> workDays)
        {
            foreach (WorkDays Day in Enum.GetValues(typeof(WorkDays)))
            {
                workDays.Add(Day.ToString());
            }
        }
    }
}
