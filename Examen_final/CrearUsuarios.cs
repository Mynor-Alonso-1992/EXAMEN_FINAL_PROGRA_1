using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examen_final
{
    public partial class CrearUsuarios : Form
    {
        public CrearUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estructUsuario user= new estructUsuario();
            Controlador_Usuarios cuser = new Controlador_Usuarios();
            user.Usuario=textBox1.Text;
            user.Nombre=textBox2.Text;
            cuser.insertarUser(user);
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Se Agrego Correctamente", "Cuadro Informativo");
        }
    }
}
