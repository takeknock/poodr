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

        public Gear(double chainring, double cog, double rim, double tire)
        {
            _chainring = chainring;
            _cog = cog;
            _rim = rim;
            _tire = tire;
        }

        public double ratio
        {
            get{ return chainring / cog;}
        }

        public double gearInches
        {
            get { return ratio * diameter; }
        }

        public double diameter
        {
            get { return rim + (tire * 2); }
        }

        private double _chainring;
        private double _cog;
        private double _rim;
        private double _tire;

        private double chainring
        {
            get { return _chainring; }
        }
        
        private double cog
        {
            get { return _cog; }
        }

        private double rim
        {
            get { return _rim; }
        }

        private double tire
        {
            get { return _tire; }
        }

    }
}
