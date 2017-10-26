using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicycle
{
    public class Wheel
    {
        public Wheel(double rim, double tire)
        {
            _rim = rim;
            _tire = tire;
        }

        // 直径
        public double diameter
        {
            get { return rim + tire * 2.0; }
        }

        // 周
        public double circumference()
        {
            return diameter * Math.PI;
        }


        private double _rim;
        private double _tire;

        public double rim
        {
            get { return _rim; }
        }

        public double tire
        {
            get { return _tire; }
        }
    }
}
