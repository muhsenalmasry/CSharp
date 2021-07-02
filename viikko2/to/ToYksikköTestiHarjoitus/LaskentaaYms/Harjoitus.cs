using System;

namespace LaskentaaYms
{
    public class Harjoitus
    {
        public long IndeksiKorotus(int i)
        {
            long l = 0; ;
            if (i == 42)
                return l;
            string s = Convert.ToString(i * 2);
            s += s.Length;
            l = int.Parse(s);
            return l;
        }

        public string IndeksiKorotus(int i, string erotin  )
        {
            string s = Convert.ToString(i * 2);
            Console.WriteLine(s);
            s += erotin;
            s += s.Substring(0, s.IndexOf(erotin)).Length;
            return s;
        }

    }
}
