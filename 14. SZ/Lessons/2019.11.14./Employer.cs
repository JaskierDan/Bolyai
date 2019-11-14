using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPractice
{
    class Employer : Person
    {
        private enum WorkDays { Monday, Wednesday, Friday }
        public override void GetAllValues(List<string> workDays)
        {
            foreach (WorkDays Day in Enum.GetValues(typeof(WorkDays)))
            {
                workDays.Add(Day.ToString());
            }            
        }
    }
}
