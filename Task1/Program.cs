using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISeries[] series=new ISeries[2];
            series[0] = new ArithProgression();
            series[1]=new GeomProgression();
            foreach (var progression in series)
            {
                progression.SetStart(1);
                progression.SetStep(2);
            }
            Console.WriteLine($"Члены арифметической прогрессии:");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine(series[0].GetNext());
            }
            series[0].Reset();
            Console.WriteLine($"Члены геометрической прогрессии:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(series[1].GetNext());
            }
            series[1].Reset();
            Console.ReadKey();
        }
    }
}
