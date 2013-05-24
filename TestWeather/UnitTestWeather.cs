using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestWeather
{
    [TestClass]
    public class UnitTestWeather
    {
        [TestMethod]
        public void TestMethodWeather1()
        {
            Guid g1 = Weather.Generator.getRandomGuid();
            Guid g2 = Weather.Generator.getRandomGuid();
                
            Assert.AreNotEqual(g1,g2);
        }
    }
}
