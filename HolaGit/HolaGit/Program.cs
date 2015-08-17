using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = null;
            Console.WriteLine("Hola Git!!");
            Console.WriteLine("Como te llamas?");
            nombre = Console.ReadLine();
            Console.WriteLine(string.Format("Tu Nombre es: {0} ", nombre));
            Console.ReadKey();
        }
    }
}
