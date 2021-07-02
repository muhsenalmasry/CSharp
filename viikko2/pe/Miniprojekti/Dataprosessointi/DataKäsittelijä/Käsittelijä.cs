using System;
using System.Collections.Generic;
using System.IO;
using CourseData;

namespace DataKäsittelijä
{
    public static class Käsittelijä
    {
        public static bool SarakkeidenmääräOk(this Data data)
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(data.CourseCode) )
                ok = false;
            if (string.IsNullOrWhiteSpace(data.Name))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.StartDate))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.EndDate))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.Location))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.MaterialType))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.MatCode))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.Description))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.MatCode))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.MainCategory))
                ok = false;
            if (string.IsNullOrWhiteSpace(data.SubCategory1))
                ok = false;
            return ok;
        }

        public static bool KuvauspituusOk(this Data data)
        {
            bool ok = true;
            if (data.Description.Length > 500)
                ok = false;
            return ok;
        }

        public static bool LuokitusOk(this Data data)
        {
            bool ok = true;
            if (string.IsNullOrWhiteSpace(data.MainCategory) || string.IsNullOrWhiteSpace(data.SubCategory1))
                ok = false;
            return ok;
        }

        public static bool KestoOk(this Data data)
        {
            bool ok = true;
            var daysCount = (DateTime.Parse(data.EndDate.Replace(".", "/")) - DateTime.Parse(data.StartDate.Replace(".", "/"))).TotalDays;
            if (daysCount < 0)
                ok = false;
            return ok;
        }
        public static void VirheellisetRivit(this List<Data> data)
        {
            StreamWriter writer = new StreamWriter("c:/users/muhsen/desktop/loki.txt");
            foreach (var item in data)
            {
                if (!SarakkeidenmääräOk(item))
                {
                    writer.WriteLine("rivi: " + data.IndexOf(item) + "Virheellinen sarakkeiden määrä!");
                }
                if (!KuvauspituusOk(item))
                {
                    writer.WriteLine("rivi: " + data.IndexOf(item) + "Kuvauksenpituus on yli 500 merkkiä!");
                }
                if (!LuokitusOk(item))
                {
                    writer.WriteLine("rivi: " + data.IndexOf(item) + "Vähemmän kuin kaksi luokitusta!");
                }
                if (!KestoOk(item))
                {
                    writer.WriteLine("rivi: " + data.IndexOf(item) + ", Päivämäärät virheelliset!");
                }
            }
            writer.Close();
        }

        public static void TulostusMuoto(this List<Data> data)
        {
            StreamWriter writer = new StreamWriter("c:/users/muhsen/desktop/KurssiData_20210629_185142.csv");
            foreach (var item in data)
            {
                if(item.SarakkeidenmääräOk() && item.KuvauspituusOk() && item.KestoOk() && item.LuokitusOk())
                {
                    int.TryParse(item.CourseCode, out int coursecode);
                    string courseCode = "C" + Convert.ToString(coursecode - 550000 + 1000000);
                    var daysCount = (Convert.ToDateTime(item.EndDate.Replace(".", "/")) - Convert.ToDateTime(item.StartDate.Replace(".", "/"))).TotalDays;
                    string duration = Convert.ToString(daysCount);
                    writer.WriteLine($"{courseCode};{item.Name};{duration};{item.Location};{item.MaterialType};{item.Description};{item.MatCode};{item.MainCategory};{item.SubCategory1};{item.SubCategory2}");
                }
                
            }
            writer.Close();
        }
    }
}
