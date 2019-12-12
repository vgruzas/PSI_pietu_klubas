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
    public class UzrasaiTests
    {
        Uzrasai uzrasai = new Uzrasai(0, "pavadinimas", "uzrasai", "naudotojas");

        [TestMethod()]
        public void GetIDTest()
        {
            int gauta = uzrasai.GetID();
            int expected = 0;

            Assert.AreEqual(expected, gauta);
        }

        [TestMethod()]
        public void GetNaudotojasTest()
        {
            string gauta = uzrasai.GetNaudotojas();
            string expected = "naudotojas";

            Assert.AreEqual(expected, gauta);
        }

        [TestMethod()]
        public void GetPavadinimasTest()
        {
            string gauta = uzrasai.GetPavadinimas();
            string expected = "pavadinimas";

            Assert.AreEqual(expected, gauta);
        }

        [TestMethod()]
        public void GetUzrasaiTest()
        {
            string gauta = uzrasai.GetUzrasai();
            string expected = "uzrasai";

            Assert.AreEqual(expected, gauta);
        }
    }
}