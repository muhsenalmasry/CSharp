using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace KonsulttiSovellus
{
    static class LaajennosDemot
    {
        public static int LaskeIndeksi(this Konsultti k)
        {
            return k.Etunimi.Length + k.Sukunimi.Length;
        }

        public static int VokaaliLkm(this string s)
        {
            //mustanaamio
            s = s.ToLower();
            var q = from c in s
                    where "aeiouyåäö".Contains(c)
                    select c;
            return q.Count();

        }
    }
}
