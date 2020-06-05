using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsuleMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Ouf ouf = new Ouf(15, 34F, "hebentiens!");
            Ouf ouf2 = new Ouf(15, 34F, "En capsule à Sion!");

            Console.WriteLine(ouf.Laf + "-" + ouf.Oursk + "-" + ouf.Mixtesas);
            Console.WriteLine(ouf2.Laf + "-" + ouf2.Oursk + "-" + ouf2.Mixtesas);
        }
    }
}
