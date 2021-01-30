using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work19Jan
{
    public class Person
    {
        public int PersonAge { get; set; }
        public string PersonName { get; set; }
        public string PersonCity { get; set; }
        public Person(int age, string name, string city)
        {
            PersonAge = age;
            PersonName = name;
            PersonCity = city;

        }
        public void Show()
        {
            Console.WriteLine("********Details of Persons********");
            Console.WriteLine($"My name is {PersonName} \nAge is {PersonAge} \nI live in {PersonCity} ");
        }
    }
    class GenericListEg
    {
        static void Main()
        {
            List<Person> lp = new List<Person>();
            lp.Add(new Person(22, "Siri", "Hyderabad"));
            var lp2 = new Person[] { new Person(23, "Ekta", "Hyderabad"),
                                    new Person(23, "Sakshi", "Latur") ,
                                    new Person(23, "Rithika", "Guntur") };
            lp.AddRange(lp2);
            foreach (var p in lp)
                p.Show();

    }
    }
}
