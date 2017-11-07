using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec3_3
{
    class Gear
    {
        public Gear(double chainring, double cog)
        {
            _chainring = chainring;
            _cog = cog;
        }

        public double gearInches(double diameter)
        {
            return ratio * diameter;
        }

        public double ratio
        {
            get { return chainring / cog; }
        }

        public double chainring
        {
            get { return _chainring; }
            private set { }
        }

        public double cog
        {
            get { return _cog; }
            private set { }
        }

        private readonly double _chainring;
        private readonly double _cog;
    }

    public class Wheel
    {
        public Wheel(double rim, double tire, double chainring, double cog)
        {
            _rim = rim;
            _tire = tire;
            _gear = new Gear(chainring, cog);
        }

        public double diameter
        {
            get { return rim + tire * 2; }
        }

        public double gearInches
        {
            get { return gear.gearInches(diameter); }
        }


        private double rim
        {
            get { return _rim; }
        }

        private double tire
        {
            get { return _tire; }
        }

        private Gear gear
        {
            get { return _gear; }
        }

        private readonly double _rim;
        private readonly double _tire;
        private readonly Gear _gear;
    }
    class _3_3
    {
    }
}
