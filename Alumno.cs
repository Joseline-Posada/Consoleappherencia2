using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleappherencia2
{
    class Alumno
    {
        private string Carrera;
        private double Matricula;

        public double matricula
        {
            get
            {
                return Matricula;
            }
            set
            {
                matricula = value;
            }
        }

        public string carrera

        {
            get
            {
                return Carrera;
            }
            set
            {
                carrera = value;
            }
        }
        public Alumno()
        {
            Carrera = "";
            Matricula = 0;
        }

        public override string ToString()
        {
            return "carrera" + carrera + "matricula";
        }
    }
}
