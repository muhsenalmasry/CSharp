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
    public class AlennustuoteTests
    {
        [TestMethod()]
        public void AlennustuoteTest()
        {
            Alennustuote at = new Alennustuote(123, "alennustuote", 50, 20.0f);
            decimal expected = 50 * 20 / 100;
            Assert.AreEqual(expected, at.LaskeHinta());
        }
    }
}