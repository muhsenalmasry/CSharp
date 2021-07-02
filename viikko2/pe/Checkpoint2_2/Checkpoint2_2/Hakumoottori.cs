using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_2
{
    class Hakumoottori
    {
        public static List<Hakutulos> Hae(string hakemisto, string teksti)
        {
            List<Hakutulos> hakutulos = new List<Hakutulos>();
            DirectoryInfo dir = new(hakemisto);
            var q = from file in dir.GetFiles("*.cs").Concat(dir.GetFiles("*.txt"))
                    where File.ReadAllText(file.ToString()).Contains(teksti)
                    select file;
            foreach (var file in q)
            {
                string rivi;
                int rivinumero = 0;
                StreamReader reader = new StreamReader(file.ToString());
                while((rivi = reader.ReadLine()) != null)
                {
                    if (rivi.Contains(teksti))
                    {
                        hakutulos.Add(new Hakutulos { Hakemisto = hakemisto, Tiedosto = file.Name, Rivinumero= rivinumero + 1 });
                    }

                    rivinumero++;
                }
            }

            return hakutulos;
        }
    }
}
