using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bicycle
{
    class ObscuringReferences
    {
        ObscuringReferences(List<Tuple<double,double>> data)
        {
            _data = data;
        }

        public IEnumerable<double> diameter()
        {
            return data.Select(e => e.Item1 + (e.Item2 * 2.0));
        }

        private List<Tuple<double, double>> data
        {
            get { return _data; }
        }

        private List<Tuple<double, double>> _data;
    }
}
