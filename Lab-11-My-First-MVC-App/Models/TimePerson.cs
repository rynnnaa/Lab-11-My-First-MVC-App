using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Lab_11_My_First_MVC_App.Models
{
    public class TimePerson
    {
        public int Year { get; set; }
        public string Honor { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int BirthYear { get; set; }
        public int DeathYear { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Context { get; set; }


        public static List<TimePerson> GetPersons(int begYear, int endYear)
        {

            List<TimePerson> people = new List<TimePerson>();

            //csv (is a comma delimated)


            string myFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../wwwroot/personOfTheYear.csv");

            //string[] data = File.ReadAllLines(myFile);  
            var lines = File.ReadAllLines(myFile).Skip(1);

            foreach (var item in lines)
            {
                string[] columns = item.Split(',');
                TimePerson tp = new TimePerson();
                tp.Year = (columns[0] == "" ? 0 : Convert.ToInt32(columns[0]));
                tp.Honor = columns[1];
                tp.Name = columns[2];
                tp.Country = columns[3];
                tp.BirthYear = (columns[4] == "" ? 0 : Convert.ToInt32(columns[4]));
                tp.DeathYear = (columns[5] == "" ? 0 : Convert.ToInt32(columns[5]));
                tp.Title = columns[6];
                tp.Category = columns[7];
                tp.Context = columns[8];

                people.Add(tp);

            }

            List <TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();

            return listofPeople;
        }
    }
}
