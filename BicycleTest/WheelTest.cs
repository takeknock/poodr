using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using bicycle;

namespace BicycleTest
{
    [TestClass]
    public class WheelTest
    {
        [TestMethod]
        public void TestCircumference()
        {
            double rim = 26;
            double tire = 1.5;
            Wheel wheel = new Wheel(rim, tire);

            const double expected = 91.106186954104;
            Assert.AreEqual(expected, wheel.circumference, 10E-7);
        }
    }
}
