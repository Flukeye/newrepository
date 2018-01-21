using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фегуры
{
    class Fegura
    {
        protected float a, b, c, d;
        public Fegura() { }
        public Fegura(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
    }

    class Tring : Fegura
    {
        public Tring(float a, float b, float c) : base(a, b, c, 0) { }
        public float Ploshad()
        {
            float half = (a + b + c) / 2;
            return (float)Math.Sqrt(half * (half - a) * (half - b) * (half - c));
        }
    }

    class Squar : Fegura
    {
        public Squar(float a, float b, float c, float d) : base(a, b, c, d) { }
        public float Ploshad()
        {
            float half = (a + b + c + d) / 2;
            return (float)Math.Sqrt((half - a) * (half - b) * (half - c) * (half - d));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Squar Kvadr = new Squar(12,2,3,12);
            Console.WriteLine(Kvadr.Ploshad());
            Console.ReadKey();////
        }
    }
}
