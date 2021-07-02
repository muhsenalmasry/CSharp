using System;
using System.Collections.Generic;
using System.Text;

namespace KonsulttiSovellus
{
    public static class EkstensioHarjoitus
    {
        //[Obsolete]
        public static string BlankkoTrimmaus(this string s)
        {
            //while (s.Contains("  "))
            //{
            //    s = s.Replace("  ", " ");
            //}
            //return s.Trim();
            ////
            string[] osat = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", osat);
        }

        public static string Replace(this string s, char c, string mjono)
        {
            return s.Replace(mjono, c.ToString());
        }

    }
}
