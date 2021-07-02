using System;
using System.Collections.Generic;
using System.IO;

namespace CourseData
{
    public class Data
    {
        string CourseCode { get; set; }
        string Name { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
        string Location { get; set; }
        string MaterialType { get; set; }
        string Description { get; set; }
        string MatCode { get; set; }
        string MainCategory { get; set; }
        string SubCategory1 { get; set; }
        string SubCategory2 { get; set; }

        public Data(string coursecode, string nimi, string startdate, string enddate, string location,
            string materialtype, string description, string matdata, string maincategory, string subcategory1, string subcategory2)
        {
            CourseCode = coursecode;
            Name = nimi;
            StartDate = startdate;
            EndDate = enddate;
            Location = location;
            MaterialType = materialtype;
            Description = description;
            MatCode = matdata;
            MainCategory = maincategory;
            SubCategory1 = subcategory1;
            SubCategory2 = subcategory2;
        }

        public static bool SarakkeidenmääräOk(Data data)
        {
            bool ok = true;
                if (string.IsNullOrEmpty(data.CourseCode))
                    ok = false;
                if (string.IsNullOrEmpty(data.Name))
                    ok = false;
                if (string.IsNullOrEmpty(data.StartDate))
                    ok = false;
                if (string.IsNullOrEmpty(data.EndDate))
                    ok = false;
                if (string.IsNullOrEmpty(data.Location))
                    ok = false;
                if (string.IsNullOrEmpty(data.MatCode))
                    ok = false;
                if (string.IsNullOrEmpty(data.Description))
                    ok = false;
                if (string.IsNullOrEmpty(data.MatCode))
                    ok = false;
                if (string.IsNullOrEmpty(data.MainCategory))
                    ok = false;
                if (string.IsNullOrEmpty(data.SubCategory1))
                    ok = false;
            return ok;
        }

        public static bool KuvauspituusOk(Data data)
        {
            bool ok = true;
            if (data.Description.Length > 500)
                ok = false;
            return ok;
        }

        public static bool LuokitusOk(Data data)
        {
            bool ok = true;
            if (string.IsNullOrEmpty(data.MainCategory) || string.IsNullOrEmpty(data.SubCategory1))
                ok = false;
            return ok;
        }

        public static bool KestoOk(Data data)
        {
            bool ok = true;

            try
            {
                var daysCountTry = (Convert.ToDateTime(data.EndDate) - Convert.ToDateTime(data.StartDate)).TotalDays;

            }
            catch (Exception)
            {
                return false;
            }
            var daysCount = (Convert.ToDateTime(data.EndDate) - Convert.ToDateTime(data.StartDate)).TotalDays;
            if (daysCount < 0)
                ok = false;
            return ok;
        }
        public static void VirheellisetRivit(List<Data> data)
        {
            StreamWriter writer = new StreamWriter("c:/users/muhsen/desktop/loki.txt");
            foreach (var item in data)
            {
                if (!SarakkeidenmääräOk(item) )
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
                    writer.Write("rivi: " + data.IndexOf(item) + ", Päivämäärät virheelliset!");
                }
            }
        }

        public static void TulostusMuoto(List<Data> data)
        {
            StreamWriter writer = new StreamWriter("c:/users/muhsen/desktop/KurssiData_20210629_185142.csv");
            foreach (var item in data)
            {
                
                List<string> oikeatrivit = new List<string>();
                int.TryParse(item.CourseCode, out int coursecode);
                string courseCode = "C" + Convert.ToString( coursecode - 550000 + 1000000);
                var daysCount = (Convert.ToDateTime(item.EndDate) - Convert.ToDateTime(item.StartDate)).TotalDays;
                string duration = Convert.ToString(daysCount);
                writer.WriteLine($"{courseCode};{item.Name};{item.StartDate};{duration};{item.Location};{item.MaterialType};{item.Description};{item.MatCode};{item.MainCategory};{item.SubCategory1};{item.SubCategory2}");
            }
        } 
    }
}
