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
    public class UzrasaiControllerTests
    {
        UzrasaiController uzc = new UzrasaiController("test", "text", 0);

        [TestMethod()]
        public void InsertTest()
        {
            string gauta = uzc.Insert();
            string expected = "insert [Uzrasai] (name, data, username) VALUES ('" + "text" + "', '', '" + "test" + "')";

            Assert.AreEqual(expected, gauta);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            string gauta = uzc.Update();
            string expected = "update [Uzrasai] set data='" + "text" + "' where ID='" + 0 + "'";

            Assert.AreEqual(expected, gauta);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            string gauta = uzc.Delete();
            string expected = "delete from [Uzrasai] where ID='" + 0 + "'";

            Assert.AreEqual(expected, gauta);
        }

        [TestMethod()]
        public void ReadTest()
        {
            string gauta = uzc.Read();
            string expected = "select * from [Uzrasai] where username ='" + "test" + "' order by ID desc";

            Assert.AreEqual(expected, gauta);
        }
    }
}