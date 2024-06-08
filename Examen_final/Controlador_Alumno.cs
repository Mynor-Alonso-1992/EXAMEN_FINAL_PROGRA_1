using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_final
{
    public class Controlador_Alumno
    {
        string Cone = string.Empty;
        SqlConnection Conexion = null;
        SqlCommand Ejecutar = null;
        SqlDataAdapter Adaptador = null;
        DataTable TablaGenerica = null;
        public Controlador_Alumno() {
            stringcone stringcone = new stringcone();
            Cone = stringcone.cone();
        } 

        public void insertarAlumn(EstructAlumno alumno)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            try
            {
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(Cone);
                //se abre la conexion
                Conexion.Open();
                //cadena para poder ingresar un paciente
                Cadena = "INSERT INTO Alumnos VALUES('" + alumno.Carnet+ "','" + alumno.Nombre + "','" + alumno.Telefono + "','" + alumno.Grado+ "'," + alumno.UsuarioId + ")";
                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                Ejecutar.ExecuteNonQuery();
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Usuario Insertado";
            }
            //exepciones.
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                //finaliza la conexion y todo lo que se ejecuto y almaceno
                Conexion.Dispose();
                Ejecutar.Dispose();
            }
        }




    }
}
