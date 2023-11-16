using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_Pratica_1
{
    public class Alumno
    {
        public Alumno ( long DNI )
        {
            this.DNI = DNI;
        }
        public Alumno ( string linea )
        {
            string[] dato = linea.Split(',');

            this.DNI = long.Parse( dato[0]);
            this.Nombre = dato[1];
            this.Apellido = dato[2];
        }

        public long DNI {  get; private set; }
        public string Nombre {  get; set; }
        public string Apellido { get; set; }

        public string GenerarAlumno()
        {
            return $"{DNI},{Nombre}, {Apellido}";
        }

    }
}
