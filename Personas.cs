using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleappherencia2
{
    class Persona
    {
        private string Nombre;
        private double Nacimiento;

        public double nacimiento
        {
            get
            {
                return Nacimiento;
            }
            set
            {
                nacimiento = value;
            }
        }

        public string nombre

        {
            get
            {
                return Nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public double matricula { get; internal set; }

        public Persona()
        {
            nombre = "";
            nacimiento = 0;
        }

        public override string ToString()
        {
            return "nombre" + nombre  + "nacimiento";
        }
    }
}