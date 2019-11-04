using Microsoft.VisualStudio.TestTools.UnitTesting;
using psi_2uzduotis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psi_2uzduotis.Tests
{
    [TestClass()]
    public class NaudotojaiTests
    {
        Naudotojai naudotojai = new Naudotojai(0, "test", "slaptikas", 0);

        [TestMethod()]
        public void GetIDTest()
        {
            int expected = 0;
            int result = naudotojai.GetID();

            Assert.AreEqual(expected, result, 0.01);
        }

        [TestMethod()]
        public void GetVardasTest()
        {
            string expected = "test";
            string result = naudotojai.GetVardas();

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetSlapTest()
        {
            string expected = "slaptikas";
            string result = naudotojai.GetSlap();

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void GetTypeNTest()
        {
            int expected = 0;
            int result = naudotojai.GetTypeN();

            Assert.AreEqual(expected, result, 0.01);
        }
    }
}