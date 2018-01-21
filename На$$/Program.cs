using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace На__
{
    class Car
    {
        public readonly double MaxSpeed;
        private double CurrentSpeed;
        public Car()
        {
            MaxSpeed = 460;
        }
        public Car(double one)
        {
            MaxSpeed = one;
        }
        public double Speed
        {
            get { return CurrentSpeed; }
            set
            {
                if (value > MaxSpeed)
                {
                    CurrentSpeed = MaxSpeed - 1;
                }
                else
                {
                    CurrentSpeed = value;
                }
            }
        }
    }

    sealed class Offroad:Car
    {
        public void Test()
        {
            Console.WriteLine(Speed = 10);
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Offroad Jeep = new Offroad();
            Jeep.Speed = 328.192;
            Console.WriteLine(Jeep.Speed);
            Console.ReadKey();

        }
    }
}
