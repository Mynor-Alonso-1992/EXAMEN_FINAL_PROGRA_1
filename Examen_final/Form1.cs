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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
            Controlador_Usuarios controlador_Usuarios = new Controlador_Usuarios();
            if (controlador_Usuarios.Usuarios().Rows.Count>0)
            {
                comboBox1.DataSource = controlador_Usuarios.Usuarios();
                comboBox1.DisplayMember = "Usuario";
                comboBox1.ValueMember = "Id";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu principal = new Menu();
            this.Hide();
            principal.ShowDialog();
            this.Close();
        }
    }
}
