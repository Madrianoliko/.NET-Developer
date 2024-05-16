using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008___Value_vs_Referemce_Types
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public void PerformWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hour(s) has been performed");
        }
    }
}
