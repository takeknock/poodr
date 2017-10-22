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

        public Gear(double chainring, double cog, Wheel wheel)
        {
            _chainring = chainring;
            _cog = cog;
            _wheel = wheel;
        }

        public double ratio
        {
            get{ return chainring / cog;}
        }

        public double gearInches
        {
            get { return ratio * wheel.diameter; }
        }

        private double _chainring;
        private double _cog;
        private Wheel _wheel;

        private double chainring
        {
            get { return _chainring; }
        }
        
        private double cog
        {
            get { return _cog; }
        }


        private Wheel wheel
        {
            get { return _wheel; }
        }


    }
}
