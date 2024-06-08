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

        public DataTable Alumnos()
        {
            //referencia a una nueva tabla sin instanciar
            DataTable dt = null;
            string Cadena = string.Empty;
            string resultado = string.Empty;
            try
            {
                //declarando tabla para devolver e instanciando
                dt = new DataTable();
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(Cone);
                //se abre la conexion
                Conexion.Open();

                Cadena = "select * from Alumnos";
                // Variable para ejecutar el comando o cadena del select
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //El resultado se guarda en la variable Adaptador
                Adaptador = new SqlDataAdapter(Ejecutar);
                //todo lo que se tiene almacenado en la variable Adaptador se formatea con Fill y se guarda en la tabla
                //que se declaro al principio.
                Adaptador.Fill(dt);
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
                Adaptador.Dispose();
            }
            //cuando la tabla esta llena se regresa a la clase que invoco este funcion.
            return dt;
        }

        public string UpdateAlumno(EstructAlumno alumno, string carnetanterior)
        {
            string Cadena = string.Empty;
            string Mensaje = string.Empty;
            //se valida que no exista un cliente con el mismo DPI
            try
            {
                //haciendo referencia a la conexion de la base de datos
                Conexion = new SqlConnection(Cone);
                //se abre la conexion
                Conexion.Open();
                //cadena para poder ingresar un paciente
                Cadena = "UPDATE Alumnos SET Carnet = '" + alumno.Carnet + "',Nombre = '" + alumno.Nombre + "',Telefono ='" + alumno.Telefono + "',Grado ='" + alumno.Grado + "' WHERE Carnet = '" + carnetanterior + "'";                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                Ejecutar.ExecuteNonQuery();
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Se termino de Modificar el Alumno con carnet: ";
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
            return Mensaje;

        }

        public void deleteAlumn(EstructAlumno alumno)
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
                Cadena = "delete Alumnos where Carnet= '" + alumno.Carnet + "'";
                //se almacena la cadena y la conexion para poder ejecutarla
                Ejecutar = new SqlCommand(Cadena, Conexion);
                //se da un formato al comando tipo texto
                Ejecutar.CommandType = System.Data.CommandType.Text;
                //se ejecuta el comando con ExecuteNonQuery
                Ejecutar.ExecuteNonQuery();
                //mensaje que se mostrara en el Cuadro de dialogo.
                Mensaje = "Usuario Eliminado";
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
