using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ke_LisäHarjoitus
{
    class Tulostukset
    {
        public Tulostukset()
        {

        }

        public void TulostaLuvut(int ensimmäinenNumero, int viimeinenNumero)
        {
            for (int i = ensimmäinenNumero; i <= viimeinenNumero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\t");
                }
                Console.WriteLine(i);
            }
        }

        public void TulostaKysely(List<string> kysely)
        {
            StreamWriter writer = new StreamWriter("c:/users/muhsen/desktop/kysely.txt");
            string s = "5\t4\t3\t2\t1";
            string kyselyt = "";
            kyselyt += "\t\t\t\tkyllä\t\t\t\tEi";
            for (int i = 0; i < kysely.Count; i++)
            {
                if(kysely[i].Length <= 15)
                {
                    kyselyt += "\n" + kysely[i] + "\t\t\t" + s;
                }
                else if(kysely[i].Length <= 23)
                {
                    kyselyt += "\n" + kysely[i] + "\t\t" + s;
                }
                else if(kysely[i].Length <= 28)
                {
                    kyselyt += "\n" + kysely[i] + "\t" + s;
                }
                else if(kysely[i].Length <= 32)
                {
                    kyselyt += "\n" + kysely[i] + s;
                }
                else
                {
                    kyselyt += "\n" + kysely[i].Substring(0, 32) + "\n" + kysely[i].Substring(32).Trim() + "\t" + s;
                }       
            }
            Console.WriteLine(kyselyt);
            writer.WriteLine(kyselyt);
            writer.Close();
        }

        public void TulostaKysely2(List<string> kysely)
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < kysely.Count; i++)
            {
                if(kysely[i].Length > 32)
                {
                    while (kysely[i].Length > 32)
                    {
                        s.Append(kysely[i].Substring(0, 32));
                        s.Append("\n");
                        kysely[i] = kysely[i].Remove(0,32);
                    }
                    s.Append("\t\t\t5\t4\t3\t2\t1\n");
                }
                else
                {
                    if (kysely[i].Length <= 15)
                    {
                        s.Append("\n" + kysely[i] + "\t\t\t5\t4\t3\t2\t1\n");
                    }
                    else if (kysely[i].Length <= 25)
                    {
                        s.Append("\n" + kysely[i] + "\t\t5\t4\t3\t2\t1\n");
                    }
                    else if (kysely[i].Length <= 30)
                    {
                       s.Append("\n" + kysely[i] + "\t5\t4\t3\t2\t1\n");
                    }
                    
                }  
            }

            Console.WriteLine(s);
        }
    }
}
