using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        public string nom;
        public int ed;
        public string cor;


        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("Escribe tu nombre");
            p.nom = Console.ReadLine();

            Console.WriteLine("Escribe tu edad");
            p.ed = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe tu correo");
            p.cor = Console.ReadLine();

            Console.WriteLine("tus datos son los siguientes:\n" + "Nombre:" + p.nom + "\n" + "Edad:" + p.ed + " años\n" + "Correo:" + p.cor);
            Console.Read();
        }
    }
}
