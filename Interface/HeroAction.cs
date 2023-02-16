using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class HeroAction : BaseAction, IAction
    {
        //void IAction.Stop() => Console.WriteLine("Stop action in HeroClass");
        public override void Stop() => Console.WriteLine("Overrided method");
        public new void Pause() => Console.WriteLine("Make a pause in HeroAction");

    }
}
