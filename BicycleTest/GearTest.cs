using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BicycleTest
{
    [TestClass]
    public class GearTest
    {
        [TestMethod]
        public void TestRatio()
        {
            double chainring = 52;
            double cog = 11;
            Bicycle.Gear gear = new Bicycle.Gear(chainring, cog);
            double expected = 4.72727272;
            Assert.AreEqual(expected, gear.ratio, 10E-5);
        }

        [TestMethod]
        public void TestGearInches()
        {
            double chainring = 52;
            double cog = 11;
            double rim = 26;
            double tire = 1.5;
            Bicycle.Gear gear = new Bicycle.Gear(chainring, cog, rim, tire);
            double expected = 137.09090909;
            Assert.AreEqual(expected, gear.gearInches, 10E-5);

        }
    }
}
