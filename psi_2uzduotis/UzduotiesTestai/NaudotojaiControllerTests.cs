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
    public class NaudotojaiControllerTests
    {
        NaudotojaiController nc = new NaudotojaiController(0, 1, "text");

        [TestMethod()]
        public void InsertTest()
        {
            string expected = "insert into text";
            string result = nc.Insert();

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            string expected = "update [Login] set type='0' where ID='1'";
            string result = nc.Update();

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            string expected = "delete from text";
            string result = nc.Delete();

            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void ReadTest()
        {
            string expected = "select * from text";
            string result = nc.Read();

            Assert.AreEqual(expected, result);
        }
    }
}