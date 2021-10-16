using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleappherencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona m = new Persona();
            Alumno v = new Alumno ();

            Console.WriteLine("nacimiento");
            m.nacimiento = double.Parse(Console.ReadLine());
            Console.WriteLine("nombre");
            m.nombre = Console.ReadLine();

            Console.WriteLine("carrera");
            v.carrera = Console.ReadLine();

            Console.WriteLine("matricula");
            m.matricula = double.Parse(Console.ReadLine());
        }
    }
}
