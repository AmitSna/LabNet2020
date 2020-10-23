using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Automóvil Audi = new Automóvil(1);
            Automóvil BMW = new Automóvil(2);
            Automóvil Cadillac = new Automóvil(3);
            Automóvil Dacia = new Automóvil(4);
            Automóvil Ferrari = new Automóvil(5);

            Avión Airbus = new Avión(123);
            Avión Boeing = new Avión(132);
            Avión Bombardier = new Avión(213);
            Avión Tupolev = new Avión(231);
            Avión Ilyushin = new Avión(312);

            Console.WriteLine(Audi.Avanzar());
            Console.WriteLine(Audi.Detenerse());
            Console.WriteLine(BMW.Avanzar());
            Console.WriteLine(BMW.Detenerse());
            Console.WriteLine(Cadillac.Avanzar());
            Console.WriteLine(Cadillac.Detenerse());
            Console.WriteLine(Dacia.Avanzar());
            Console.WriteLine(Dacia.Detenerse());
            Console.WriteLine(Ferrari.Avanzar());
            Console.WriteLine(Ferrari.Detenerse());

            Console.WriteLine(Airbus.Avanzar());
            Console.WriteLine(Airbus.Detenerse());
            Console.WriteLine(Boeing.Avanzar());
            Console.WriteLine(Boeing.Detenerse());
            Console.WriteLine(Bombardier.Avanzar());
            Console.WriteLine(Bombardier.Detenerse());
            Console.WriteLine(Tupolev.Avanzar());
            Console.WriteLine(Tupolev.Detenerse());
            Console.WriteLine(Ilyushin.Avanzar());
            Console.WriteLine(Ilyushin.Detenerse());

            Console.ReadLine();
        }
    }
}
