using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos_Pratica_1
{
    public partial class Form1 : Form
    {
        Gestor_Alumnos lista_Alumnos = new Gestor_Alumnos();
        public Form1()
        {
            InitializeComponent();
            Cargar_Data();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            Alumno unAlumno = new Alumno((long)UP_DNI.Value);
            {
                unAlumno.Nombre = TX_NOMBRE.Text;
                unAlumno.Apellido = TX_APELLIDO.Text;
            }

            lista_Alumnos.Alta( unAlumno );

            MessageBox.Show(" Guardado con exito ");
            limpio();
            Cargar_Data();
        }

        private void limpio()
        {
            UP_DNI.Text = null;
            TX_APELLIDO.Text = null;
            TX_NOMBRE.Text = null;
        }

        private void Cargar_Data()
        {
            DGV.Refresh();
            BindingList<Alumno> List = new BindingList<Alumno>(lista_Alumnos.Lista_Alumno());

            DGV.DataSource = List;
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            if ( this.DGV.SelectedRows.Count == 1 )
            {
                Alumno Selecionado = (Alumno)this.DGV.SelectedRows[0].DataBoundItem;

                lista_Alumnos.Baja( Selecionado.DNI );

                Cargar_Data();

            }
        }
    }
}
