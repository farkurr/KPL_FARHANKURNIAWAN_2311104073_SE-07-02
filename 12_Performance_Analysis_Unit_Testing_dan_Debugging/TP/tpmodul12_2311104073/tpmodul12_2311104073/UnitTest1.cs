using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.Remoting.Messaging;
using tpmodul12_2311104041;
using tpmodul12_2311104041Tests;
using tpmodul12_2311104073;

namespace tpmodul12_2311104041Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNegatif()
        {
            string result = Helper.CariTandaBilangan(-10);
            Assert.AreEqual("Bilangan Negatif", result);
        }

        [TestMethod]
        public void TestPositif()
        {
            string result = Helper.CariTandaBilangan(10);
            Assert.AreEqual("Bilangan Positif", result);
        }

        [TestMethod]
        public void TestNol()
        {
            string result = Helper.CariTandaBilangan(0);
            Assert.AreEqual("Bilangan Nol", result);
        }
    }
}