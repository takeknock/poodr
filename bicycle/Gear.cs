using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicycle
{
    public class Gear
    {
        public Gear(double chainring, double cog)
        {
            _chainring = chainring;
            _cog = cog;
        }

        public double ratio
        {
            get{ return _chainring / _cog;}
        }
        private double _chainring;
        private double _cog;

    }
}
