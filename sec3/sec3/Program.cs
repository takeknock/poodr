using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec3
{
    public class Gear
    {
        // Constructors
        public Gear(double chainring, double cog, IWheel wheel)
        {
            //this.chainring = chainring;
            //this.cog = cog;
            //this.rim = rim;
            //this.tire = tire;
            _chainring = chainring;
            _cog = cog;
            _wheel = wheel;
        }

        public double gearInches
        {
            get { return ratio * wheel.diameter(); }
        }

        public double ratio
        {
            get { return chainring / cog; }
        }

        // Accessors
        public double chainring
        {
            get { return _chainring; }
            private set { _chainring = chainring; }
        }

        public double cog
        {
            get { return _cog; }
            private set { _cog = cog; }
        }

        public double rim
        {
            get { return _rim; }
            private set { _rim = rim; }
        }

        public double tire
        {
            get { return _tire; }
            private set { _tire = tire; }
        }

        private IWheel wheel
        {
            get { return _wheel; }
        }

        // member variables
        private double _chainring;
        private double _cog;
        private double _rim;
        private double _tire;
        private IWheel _wheel;

    } // class Gear

    public class Wheel : IWheel
    {
        public Wheel(double rim, double tire)
        {
            //this.rim = rim;
            //this.tire = tire;
            _rim = rim;
            _tire = tire;
        }

        public double diameter()
        {
            return rim + (tire * 2.0);
        }

        public double rim
        {
            get { return _rim; }
            private set { _rim = rim; }
        }

        public double tire
        {
            get { return _tire; }
            private set { _tire = tire; }
        }

        private double _rim;
        private double _tire;
    }


    class Program
    {
        static void Main(string[] args)
        {
            double chainring = 52;
            double cog = 11;
            double rim = 26;
            double tire = 1.5;

            Wheel wheel = new Wheel(rim, tire);

            Console.WriteLine(new Gear(chainring, cog, wheel).gearInches);

        }
    }
}
