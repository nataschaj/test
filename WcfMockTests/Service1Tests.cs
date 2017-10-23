using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfMock.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetSideTest()
        {
            double resultat;
            //Arrange
            var calc = new Service1();

            //Act
            resultat = calc.GetSide(10, 2, 2);

            //Assert
            Assert.AreEqual(14, resultat);
        }

        [TestMethod()]
        public void GetVolumeTest()
        {
            double resultat;
            //Arrange
            var calc = new Service1();

            resultat = calc.GetVolume(5, 5, 10);

            Assert.AreEqual(20, resultat);
            
        }
    }
}