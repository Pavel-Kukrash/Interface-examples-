using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IMovable
    {
        //public const int minSpeed = 0;     
        //private static int maxSpeed = 60;
        public void Move() => Console.WriteLine("Driving");
        //static double GetTime(double distance, double speed) => distance / speed;
        //static int MaxSpeed
        //{
        //    get => maxSpeed;
        //    set
        //    {
        //        if(value > 0) maxSpeed = value;
        //    }
        //}

    }
}
