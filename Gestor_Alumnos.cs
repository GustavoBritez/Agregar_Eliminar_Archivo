using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_Pratica_1
{
    public class Gestor_Alumnos
    {
        string archivo = "Alumnos.txt";
        public void Alta( Alumno unAlumno )
        {
            FileStream fs = new FileStream( archivo , FileMode.Append , FileAccess.Write );
            using ( StreamWriter write = new StreamWriter(fs) )
            {
                write.WriteLine( unAlumno.GenerarAlumno() );
            }
        }
        public void Baja( long DNI )
        {
            string output = string.Empty;

            FileStream fs = new FileStream( archivo, FileMode.OpenOrCreate, FileAccess.Read );

            using ( StreamReader reader = new StreamReader(fs) )
            {
                string linea = reader.ReadLine();

               while ( linea != null)
                {
                    Alumno alumno_ = new Alumno( linea );
                    if ( alumno_.DNI != DNI )
                    {
                        output += linea + Environment.NewLine;
                    }
                    linea = reader.ReadLine();
                }
            }

            fs = new FileStream( archivo, FileMode.Truncate, FileAccess.Write );
            using ( StreamWriter writer = new StreamWriter(fs) )
            {
                writer.Write(output);
            }

        }

        public List<Alumno> Lista_Alumno ()
        {
            List<Alumno> lista_Alumno = new List<Alumno>();

            FileStream fs = new FileStream( archivo , FileMode.OpenOrCreate, FileAccess.Read );
            using ( StreamReader reader = new StreamReader(fs) )
            {
                string linea = reader.ReadLine();

                while ( linea != null ) 
                {
                    Alumno _Alumno = new Alumno(linea);
                    
                    lista_Alumno.Add(_Alumno);

                    linea = reader.ReadLine();

                }
            }
            return lista_Alumno;
        }


    }
}
