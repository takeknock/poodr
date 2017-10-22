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
            _wheel = new Wheel(rim, tire);
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

        class Wheel
        {
            public Wheel(double rim, double tire)
            {
                _rim = rim;
                _tire = tire;
            }

            public double diameter
            {
                get { return rim + tire * 2.0; }
            }

            private double _rim;
            private double _tire;

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
}
