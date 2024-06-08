using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final.Properties
{
    public partial class Actualizar_y_borrar : Form
    {
        string carnetanterior="";
        public Actualizar_y_borrar()
        {
            InitializeComponent();
            Actualizartabla();

        }

        public void Actualizartabla()
        {
            Controlador_Alumno alum = new Controlador_Alumno();
            if (alum.Alumnos().Rows.Count == 0)
            {
                MessageBox.Show("No hay Alumnos por favor inserte uno.", "Cuadro Informativo");
                dataGridView1.DataSource = alum.Alumnos();
            }
            else
                dataGridView1.DataSource = alum.Alumnos();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Se emplea el begininvoke para que no haya un siclo infinito..
            this.BeginInvoke(new MethodInvoker(() =>
            {
                if (carnetanterior.Equals(""))
                {
                    carnetanterior= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                }
                
                Controlador_Alumno AcAlumno = new Controlador_Alumno();
                
                EstructAlumno Modeloalumno = new EstructAlumno();
                
                Modeloalumno.Carnet = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                Modeloalumno.Nombre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                Modeloalumno.Telefono = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                Modeloalumno.Grado = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                Modeloalumno.UsuarioId= int.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                

                
                MessageBox.Show(AcAlumno.UpdateAlumno(Modeloalumno,carnetanterior)+ dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), "Cuadro Informativo");
                
                Actualizartabla();
            }));
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                carnetanterior = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Controlador_Alumno AcAlumno = new Controlador_Alumno();
                EstructAlumno Modeloalumno = new EstructAlumno();
                Modeloalumno.Carnet = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                AcAlumno.deleteAlumn(Modeloalumno);
                MessageBox.Show("Alumno Eliminado", "Cuadro Informativo");
                Actualizartabla();
            }
        }
    }
}
