using System;
using System.Collections.Generic;
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
            // read in the file
            //File.ReadALlLines (in an array)

            //iterate through the array and set the values appropriately to a new TimePerson Object.

            //csv is a comma delimated

            //populate whole list with all the people then do the linq query with lambda to filter those people
            TimePerson tp = new TimePerson();
            tp.Name = "Amanda";
            tp.Honor = "Being Awesome";
            tp.Category = "Cats";
        

            TimePerson tp2 = new TimePerson();
            tp.Name = "Amanda";
            tp.Honor = "Being Awesome";

            people.Add(tp);
            people.Add(tp2);

            List<TimePerson> listofPeople = people.Where(p => (p.Year >= begYear) && (p.Year <= endYear)).ToList();

            return listofPeople;
        }
    }
}
