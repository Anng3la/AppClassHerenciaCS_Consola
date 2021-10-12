using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClassHerenciaCS_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto3D a;
            a = new Punto3D( 60 , 53.7 , 88);
            Console.WriteLine(a.ToString());

            Console.ReadKey();


        }
    }
}
