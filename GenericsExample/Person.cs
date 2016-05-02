using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GenericsExample
{
    public class Person
    {
        private int age;
        private string name;
        private List<int> luckyNrs = new List<int>();
        public Person(int age, string name) //Person constructor
        {
            this.age = age;
            this.name = name; //Sets the age and name of the person object
            SetLuckyNrs();
        }
        private void SetLuckyNrs()
        {
            Random r = new Random();
            for (int i = 0; i < name.Length; i++)
            {
                int nr = r.Next(1, 41);
                luckyNrs.Add(nr);
            }
        }
        public string GetPersonDetails()
        {
            string s = " ";
            foreach (var item in luckyNrs)
            {
                s = s + item.ToString() + ";  ";
            }
            return name + ", age: " + age + ", <br> Lucky Numbers:" + s;
        }
    }
}