using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {

            return (p1 == null || p2 == null) ?
                throw new ArgumentException("Incorrect params") :
                p1.Age.CompareTo(p2.Age);
        }

       

    }
}
