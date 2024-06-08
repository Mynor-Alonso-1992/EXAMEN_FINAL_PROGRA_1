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
    public partial class CrearAlumno : Form
    {
        public CrearAlumno()
        {
            InitializeComponent();
            Controlador_Usuarios controlador_Usuarios = new Controlador_Usuarios();
            comboBox1.DataSource = controlador_Usuarios.Usuarios();
            comboBox1.DisplayMember = "Usuario";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstructAlumno alumno = new EstructAlumno();
            alumno.Carnet = textBox1.Text;
            alumno.Nombre = textBox2.Text;
            alumno.Telefono = textBox3.Text;
            alumno.Grado = textBox4.Text;
            comboBox1.ValueMember.ToString();
            alumno.UsuarioId = int.Parse(comboBox1.ValueMember.ToString());
            Controlador_Alumno controlador =new Controlador_Alumno();
            controlador.insertarAlumn(alumno);
        }
    }
}
