using conecction.daw;
using conecction.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conecction.DAO
{
    class AlumnoDAO: ConexionDAO
    {
        SqlCommand cmd = new SqlCommand();
        public void registrar(Alumno alumno)
        {
            try
            {
                string SQL;
                conectar();
                //SQL = CALL insertar_cliente (?correo, ?contraseña
                SQL = "Insert into Alumno(nombre,apaterno,amaterno," +
                    "direccion,telefono,sexo) values(" +
                    "@nombre,@apaterno,@amaterno,@direccion," +
                    "@telefono,@sexo)";
                Con.Open();
                cmd.Connection = Con;
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apaterno", alumno.Apaterno);
                cmd.Parameters.AddWithValue("@amaterno", alumno.Amaterno);
                cmd.Parameters.AddWithValue("@direccion", alumno.Direccion);
                cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                
                cmd.Parameters.AddWithValue("@sexo", alumno.Sexo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha dado de altaa el registro correco", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Con.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("error" + ex,"Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                Con.Close();
            }
            
               
            }
        public List<Alumno> listar()
        {
            List<Alumno> lista = new List<Alumno> ();
            SqlDataReader rdr;
            try
            {
                string SQL;
                conectar();
                SQL = "SELECT * FROM alumno";
                Con.Open();
                cmd.Connection = Con;
                cmd.CommandText = SQL;
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Alumno alumno = new Alumno();
                        alumno.Idalumno = rdr.GetInt16(1);
                        alumno.Nombre = rdr.GetString(2);
                        alumno.Apaterno = rdr.GetString(3);
                        alumno.Amaterno = rdr.GetString(4);
                        alumno.Direccion = rdr.GetString(5);
                        alumno.Telefono = rdr.GetString(6);
                        alumno.Sexo = rdr.GetString(7);
                        lista.Add(alumno);
                    }
                }
                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Number + "Ha ocurrido: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
            return lista;
        }
        public Alumno Buscarid(Alumno alum)
        {
            Alumno alumno = null;
            SqlDataReader rdr;
            try
            {
                string SQL;
                conectar();
                SQL = "SELECT * FROM alumno WHERE idalumno = '" + alum.Idalumno + "'";
                Con.Open();
                cmd.Connection = Con;
                cmd.CommandText = SQL;
                rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        alumno = new Alumno();
                        alumno.Idalumno = rdr.GetInt16(1);
                        alumno.Nombre = rdr.GetString(2);
                        alumno.Apaterno = rdr.GetString(3);
                        alumno.Amaterno = rdr.GetString(4);
                        alumno.Direccion = rdr.GetString(5);
                        alumno.Telefono = rdr.GetString(6);
                        alumno.Sexo = rdr.GetString(7);
                    }
                }
                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Number + "Ha ocurrido: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
            return alumno;
        }
        public void modificar(Alumno alumno)
        {
            try
            {
                //tt
                string SQL;
                conectar();
                SQL = "UPDATE alumno SET nombre=@nombre," +
                    "apaterno=@apaterno," +
                    "amaterno=@amaterno," +
                    "direccion=@direccion," +
                    "telefono=@telefono," +
                    "sexo=@sexo" +
                    "where idalumno = @idalumno";
                Con.Open();
                cmd.Connection = Con;
                cmd.CommandText = SQL;
                cmd.Parameters.AddWithValue("@idalumno", alumno.Idalumno);
                cmd.Parameters.AddWithValue("@nombre", alumno.Nombre);
                cmd.Parameters.AddWithValue("@apaterno", alumno.Apaterno);
                cmd.Parameters.AddWithValue("@amaterno", alumno.Amaterno);
                cmd.Parameters.AddWithValue("@direccion", alumno.Direccion);
                cmd.Parameters.AddWithValue("@telefono", alumno.Telefono);
                cmd.Parameters.AddWithValue("@sexo", alumno.Sexo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado el Registro correctamente!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error" + ex.Number + "Ha ocurrido: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
