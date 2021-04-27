using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Parcial2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Grupo grupo = new Grupo("Pepito");
            grupo += new Perro("Moro", "Pitbull");
            grupo += new Perro("Julio", "Cruza", 13, false);
            grupo += new Perro("Ramon", "Salchica", 2, true);
            grupo += new Gato("Jose", "Angora");
            grupo += new Gato("Hernan", "Cruza");
            grupo += new Gato("Fer", "Siames");

            Console.WriteLine(grupo);

            grupo -= new Perro("Ramon", "Salchica", 2, true); 

            Console.WriteLine(grupo);
            Console.ReadKey();
        }
    }
}
