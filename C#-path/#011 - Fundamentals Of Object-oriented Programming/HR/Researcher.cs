using BethanysPieShopHRM.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011___Fundamentals_Of_Object_oriented_Programming.HR
{
    internal class Researcher : Employee
    {
        public Researcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }

        public int NumberOfPieTastesInvented { get; set; }

        public void ResearchNewPieTaste(int researchHours)
        {
            NumberOfHoursWorked += researchHours;

            if(new Random().Next(100) > 50)
            {
                NumberOfPieTastesInvented++;

                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste ! Total number of pies invented: { NumberOfPieTastesInvented }");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is working still on a new pie taste!");
            }

            NumberOfPieTastesInvented++;
            Console.WriteLine("Researching new pie taste");
        }
    }
}
