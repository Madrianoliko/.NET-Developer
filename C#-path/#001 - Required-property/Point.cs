using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Required_property
{
    public class Point
    {
        public required int X { get; set; }
        public required int Y { get; set; }

        public override string ToString() => $"{X} {Y}";

    }
}
