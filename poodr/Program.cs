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
            Gear gear = new Gear(chainring, cog);
            Console.WriteLine(gear.ratio.ToString());
        }
    }
}
