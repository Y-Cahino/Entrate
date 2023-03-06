using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int[] a = new int[13];
            for(int i = 1; i < a.Length; i++)
            {
                Console.WriteLine("Inserire entrata mensile: ");
                a[i] = int.Parse(Console.ReadLine());
                x+=a[i];
            }
            Console.WriteLine("Le entrate totali ammontano a: "+x);
        }
    }
}
