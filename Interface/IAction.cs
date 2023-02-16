using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IAction
    {
        void Move();
        void Stop();

        void Pause();
    }
}
