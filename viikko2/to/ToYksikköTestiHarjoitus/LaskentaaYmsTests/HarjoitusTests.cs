using Microsoft.VisualStudio.TestTools.UnitTesting;
using LaskentaaYms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskentaaYms.Tests
{
    [TestClass()]
    public class HarjoitusTests
    {
        [TestMethod()]
        public void IndeksiKorotus_Alle10_ok()
        {
            LaskentaaYms.Harjoitus h = new Harjoitus();
            var actual = h.IndeksiKorotus(3);
            Assert.AreEqual(61, actual);
        }

        [TestMethod()]
        public void IndeksiKorotus_yli10_ok()
        {
            LaskentaaYms.Harjoitus h = new Harjoitus();
            var actual = h.IndeksiKorotus(12);
            Assert.AreEqual(242, actual);
        }


        [TestMethod()]
        public void IndeksiKorotus_VastausKaikkeen_ok()
        {
            LaskentaaYms.Harjoitus h = new Harjoitus();
            var actual = h.IndeksiKorotus(42);
            Assert.AreEqual(0, actual);
        }

        [TestMethod()]
        [DataRow(1, 21)]
        [DataRow(99, 1983)]
        [DataRow(800, 16004)]
        public void IndeksiKorotus_lukuja_Kaikkiok(int input, long output)
        {
            LaskentaaYms.Harjoitus h = new Harjoitus();
            var actual = h.IndeksiKorotus(input);
            Assert.AreEqual(output, actual);
        }

        [TestMethod()]
        public void IndeksiKorotus_Muotoilu_ok()
        {
            LaskentaaYms.Harjoitus h = new Harjoitus();
            var actual = h.IndeksiKorotus(50, "-");
            Assert.AreEqual("100-3", actual);
        }
    }


}