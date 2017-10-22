using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bicycle;

namespace poodr
{
    class Program
    {
        static void Main(string[] args)
        {
            double chainring = 52;
            double cog = 11;
            double rim = 26;
            double tire = 1.5;
            Wheel wheel = new Wheel(rim, tire);
            Gear gear = new Gear(chainring, cog, wheel);
            Console.WriteLine(gear.ratio.ToString());
            Console.WriteLine(gear.gearInches.ToString());
        }
    }
}
