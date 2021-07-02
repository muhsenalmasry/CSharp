using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerkkijonojaJaTaulukoita
{
    static class ExtensioHarjoitus
    {
        public static string BlankkoTrimmaus(this string s)
        {
            
            var q = from ch in s
                where ch != ' '
                select ch;
            return string.Join("",q);
        }
        public static string BlankkoTrimmaus(this string s, params char[] merkit)
        {
            var q = from m in s
                    where !merkit.Contains(m)
                    select m;
            return string.Join("",q);
        }
    }
}
