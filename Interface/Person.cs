using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Person : IMovable, ICloneable, IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public object Clone() => new Person(Name, Age);

        //public int CompareTo(object o)
        //{
        //    if (o is Person person) return Name.CompareTo(person.Name);
        //    else throw new ArgumentException("Incorrect params");
        //}

        public int CompareTo(Person? person)
        {
            return person is null ? 
                throw new ArgumentException("Incorrect params") :
                        Age.CompareTo(person.Age);
            //return Name.CompareTo(person.Name);

        }

        public static IComparer<Person> SortByAge()
        {
            return new PeopleComparer();
        }


        public void Move() => Console.WriteLine("Man is walking");
    }
}
