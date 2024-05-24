using BethanysPieShopHRM.HR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011___Fundamentals_Of_Object_oriented_Programming.HR
{
    internal class JuniorResearcher : Researcher
    {
        public JuniorResearcher(string first, string last, string em, DateTime bd, double? rate) : base(first, last, em, bd, rate)
        {
        }
    }
}
