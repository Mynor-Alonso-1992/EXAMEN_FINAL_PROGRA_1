using Examen_final.Properties;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearAlumno Fpaciente = new CrearAlumno();
            panel1.Controls.Clear();
            Fpaciente.TopLevel = false;
            panel1.Controls.Add(Fpaciente);
            Fpaciente.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Actualizar_y_borrar Fpaciente = new Actualizar_y_borrar();
            panel1.Controls.Clear();
            Fpaciente.TopLevel = false;
            panel1.Controls.Add(Fpaciente);
            Fpaciente.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar Fpaciente = new Consultar();
            panel1.Controls.Clear();
            Fpaciente.TopLevel = false;
            panel1.Controls.Add(Fpaciente);
            Fpaciente.Show();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearUsuarios Fpaciente = new CrearUsuarios();
            panel1.Controls.Clear();
            Fpaciente.TopLevel = false;
            panel1.Controls.Add(Fpaciente);
            Fpaciente.Show();
        }
    }
}
