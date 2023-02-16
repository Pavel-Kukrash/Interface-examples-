using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class BaseAction : IAction
    {
        void IAction.Move() => Console.WriteLine("Move in Base Class");
        public virtual void Stop() => Console.WriteLine("Stop acyion in BaseAction");

        public void Pause() => Console.WriteLine("Make a pause in BaseAction");
    }
}
