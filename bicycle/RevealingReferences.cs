using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicycle
{
    class RevealingReferences
    {
        // Constructor
        RevealingReferences(List<Tuple<double, double>> data)
        {
            _wheels = wheelify(data).ToList();
        }

        public IEnumerable<double> diameters()
        {
            return wheels.Select(wheel => diameter(wheel));
        }

        private double diameter(Wheel wheel)
        {
            return wheel.rim + wheel.tire * 2.0;
        }

        private IEnumerable<Wheel> wheelify(List<Tuple<double, double>> data)
        {
            return data.Select(e => new Wheel(e.Item1, e.Item2));
        }

        // member variables
        private List<Wheel> _wheels;

        // Accessor
        private List<Wheel> wheels
        {
            get { return _wheels; }
        }
    }
}
