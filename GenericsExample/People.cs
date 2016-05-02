using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericsExample
{
    public class People
    {
        List<Person> myPeople = new List<Person>(); //Creates a list for person objects

        public People()
        {
            myPeople.Add(new Person(50, "Fred")); //Adds the person objects to the list with parameters age and name
            myPeople.Add(new Person(30, "John"));
            myPeople.Add(new Person(26, "Andrew"));
            myPeople.Add(new Person(24, "Xavier"));
            myPeople.Add(new Person(5, "Mark"));
            myPeople.Add(new Person(6, "Cameron"));
        }

        public string DisplayPeople()
        {
            string s = "";
            foreach (var item in myPeople)
            {
                s = s + item.GetPersonDetails() + "<br>";
            }
            return s;
        }

    }
}