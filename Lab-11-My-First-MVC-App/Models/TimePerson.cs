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

            //populate whole list with all the people then do the linq query with lambda to filter those people
            TimePerson tp = new TimePerson();

            string path = Environment.CurrentDirectory;

            string newPath = Path.GetFullPath(Path.Combine(Path.Combine(path, @"wwwroot\personOgTheYear.cvs"));

            //read all lines
            string[] myFile = File.ReadAllLines(newPath);

            //iterate through the array and set the values appropriately to a new TimePerson Object.
            for (int i = 1; i < myFile.Length; i++)
            {
                //split lines
                string[] fields = myFile[i].Split(',');

                people.Add(new TimePerson
                {

                    Year = Convert.ToInt32(fields[0]),

                })

            }
            {

            }




            List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();

            return listofPeople;
        }
    }
}
