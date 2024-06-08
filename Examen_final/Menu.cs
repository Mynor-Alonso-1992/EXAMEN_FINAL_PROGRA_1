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
    }
}
