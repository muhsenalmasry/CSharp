using System;

namespace Tarkistin
{
    public class HeTu
    {
        public bool HeTuOk(string hetu)
        {
            string pvm;
            char välimerkki;
            string numero;
            char tarkistusmerkki;
            string tMerkit = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            hetu = hetu.Trim();
            if (hetu.Length == 11)
            {
                pvm = hetu.Substring(0, 6);
                välimerkki = hetu[6];
                numero = hetu.Substring(7, 3);
                tarkistusmerkki = hetu[10];
                int i = 0;
                if (!int.TryParse(numero, out i)) { return false; }
                if (välimerkki != '-' && välimerkki != '+' && välimerkki != 'A')
                {
                    return false;
                }
                if (!int.TryParse(numero, out i)) { return false; }
                i = int.Parse(pvm + numero) % 31;
                if (tMerkit[i] != tarkistusmerkki)
                {
                    return false;
                }
                return true;
            }
            else if( hetu.Length < 11)
            {
                pvm = hetu.Substring(0, 6);
                välimerkki = hetu[6];
                tarkistusmerkki = hetu[7];
                int i = 0;
                if (!int.TryParse(pvm, out i)) { return false; }
                if (välimerkki != '-' && välimerkki != '+' && välimerkki != 'A')
                {
                    return false;
                }
                if (!tMerkit.Contains(tarkistusmerkki))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public bool OnPalindromi(string s)
        {
            string reversed = "";
            if (s.Length == 1)
                return true;
            if (string.IsNullOrEmpty(s) || s == null)
                return false;
            s = s.Trim();
            var str = s.Split(" ");
            s = String.Join("", str);
            for (int i = s.Length-1; i >= 0; i--)
            {
                reversed += s[i];
            }
            if (reversed == s)
                return true;
            return false;
        }
    }
}
