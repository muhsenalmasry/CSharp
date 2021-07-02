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
    public class PalindromiTestit
    {
        [TestMethod()]
        [DataRow("saippuakauppias")]
        [DataRow("kononen on ok")]
        public void Palindromi(string ht)
        {
            HeTu hetu = new HeTu();
            bool actual = hetu.OnPalindromi(ht);
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        [DataRow("")]
        [DataRow(null)]
        public void Palindrominullkirjainta(string ht)
        {
            HeTu hetu = new HeTu();
            bool actual = hetu.OnPalindromi(ht);
            Assert.IsFalse(actual);
        }
        [TestMethod()]
        [DataRow("mustanaamio")]
        public void EiPalindromi(string ht)
        {
            HeTu hetu = new HeTu();
            Assert.IsFalse(hetu.OnPalindromi(ht));
        }
    }
}