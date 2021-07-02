using System;
using System.Collections.Generic;

namespace CourseData
{
    public class Data
    {
        string CourseCode { get; set; }
        string Nimi { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
        string Location { get; set; }
        string MaterialType { get; set; }
        string Description { get; set; }
        string MatData { get; set; }
        string MainCategory { get; set; }
        string SubCategory1 { get; set; }
        string SubCategory2 { get; set; }

        public Data(string coursecode, string nimi, string startdate, string enddate, string location,
            string materialtype, string description, string matdata, string maincategory, string subcategory1, string subcategory2)
        {
            CourseCode = coursecode;
            Nimi = nimi;
            StartDate = startdate;
            EndDate = enddate;
            Location = location;
            MaterialType = materialtype;
            Description = description;
            MatData = matdata;
            MainCategory = maincategory;
            SubCategory1 = subcategory1;
            SubCategory2 = subcategory2;
        }

        public static bool SarakkeidenmääräOk(List<Data> data)
        {
            bool ok = true;
            foreach (var item in data)
            {
                if (string.IsNullOrEmpty(item.CourseCode))
                    ok = false;
                if (string.IsNullOrEmpty(item.Nimi))
                    ok = false;
                if (string.IsNullOrEmpty(item.StartDate))
                    ok = false;
                if (string.IsNullOrEmpty(item.EndDate))
                    ok = false;
                if (string.IsNullOrEmpty(item.Location))
                    ok = false;
                if (string.IsNullOrEmpty(item.MatData))
                    ok = false;
                if (string.IsNullOrEmpty(item.Description))
                    ok = false;
                if (string.IsNullOrEmpty(item.MatData))
                    ok = false;
                if (string.IsNullOrEmpty(item.MainCategory))
                    ok = false;
                if (string.IsNullOrEmpty(item.SubCategory1))
                    ok = false;
            }
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

        public static void VirheellisetRivit(List<Data> data)
        {
            foreach (var item in data)
            {
                if (SarakkeidenmääräOk())
                {

                }
            }
        }
    }
}
