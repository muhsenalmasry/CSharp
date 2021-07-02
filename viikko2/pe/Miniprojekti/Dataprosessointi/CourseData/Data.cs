using System;

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

        public bool SarakkeidenmääräOk(string[] data)
        {
            bool ok = true;
            foreach (var item in data)
            {
                if (string.IsNullOrEmpty(item))
                    ok = false;
            }
            return ok;
        }

        public bool KuvauspituusOk(string[] data)
        {
            bool ok = true;

            return ok;
        }
    }
}
