﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CourseData;
using DataKäsittelijä;

namespace Dataprosessointi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> lista = new List<Data>();
            foreach (var rivi in File.ReadAllLines(@"C:\users\muhsen\desktop\CourseData\CourseData.csv"))
            {
                var data = rivi.Split(";");
                lista.Add(new Data(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]));
            }

            
            lista.RemoveAt(0);
            var q = (from d in lista
                    where d.SarakkeidenmääräOk()
                    where d.KuvauspituusOk()
                    where d.KestoOk()
                    where d.LuokitusOk()
                    select d).ToList();
            lista.VirheellisetRivit();
            q.TulostusMuoto();
        }
    }
}
