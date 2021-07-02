using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tarkistin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkistin.Tests
{
    [TestClass()]
    public class HeTuTests
    {
        [TestMethod()]
        public void HeTuOkTest_OikeaTunnus()
        {
            HeTu hetu = new HeTu();
            Assert.IsTrue(hetu.HeTuOk("121301A123E"));
        }
        [TestMethod()]
        public void HeTuOkTest_ViheellinenTunnus()
        {
            HeTu hetu = new HeTu();
            Assert.IsFalse(hetu.HeTuOk("120177-1A22"));
        }
        [TestMethod()]
        public void HeTuOkTest_VirheellinenPvm()
        {
            HeTu hetu = new HeTu();
            Assert.IsFalse(hetu.HeTuOk("10109-206Z"), "Lyhyt päivämäärä");
        }
        [TestMethod]
        public void HeTuOkTest_SallittuHeTu()
        {
            HeTu hetu = new HeTu();
            Assert.IsTrue(hetu.HeTuOk("040585-N2"));
        }

    }
}