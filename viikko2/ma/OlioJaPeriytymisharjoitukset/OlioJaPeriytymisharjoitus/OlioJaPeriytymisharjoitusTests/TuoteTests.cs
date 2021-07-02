using Microsoft.VisualStudio.TestTools.UnitTesting;
using OlioJaPeriytymisharjoitus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioJaPeriytymisharjoitus.Tests
{
    [TestClass()]
    public class TuoteTests
    {
        [TestMethod()]
        public void TuoteTest_LaskeHinta_Ok()
        {
            Tuote tuote = new Tuote(1234, "Tuote", 50, Verokanta.ALV_14);
            decimal expected = 50 + 50 * 14 / 100;
            Assert.AreEqual(expected, tuote.LaskeHinta());
        }

        //[TestMethod()]
        //public void TuoteTest1()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void TuoteTest2()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void LaskeHintaTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void ToStringTest()
        //{
        //    Assert.Fail();
        //}
    }
}