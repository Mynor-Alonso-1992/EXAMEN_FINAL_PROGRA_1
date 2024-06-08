using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
            Controlador_Alumno alum = new Controlador_Alumno();
            if (alum.Alumnos().Rows.Count == 0)
            {
                MessageBox.Show("No hay Alumnos por favor inserte uno.", "Cuadro Informativo");
                dataGridView1.DataSource = alum.Alumnos();
            }
            else
                dataGridView1.DataSource = alum.Alumnos();
        }
    }
}
