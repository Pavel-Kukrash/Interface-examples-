using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class User<T> : IUser<T>
    {
        public T Id { get;  }
        public User(T id) => Id = id;
        
    }
}
