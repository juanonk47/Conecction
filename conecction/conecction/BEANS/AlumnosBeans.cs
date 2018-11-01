using conecction.DAO;
using conecction.modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conecction.BEANS
{
    class AlumnosBeans
    {
        private Alumno alumno = new Alumno();
        private List<Alumno> lst_Alumno = new List<Alumno>();

        internal Alumno Alumno { get => alumno; set => alumno = value; }
        internal List<Alumno> Lst_Alumno { get => lst_Alumno; set => lst_Alumno = value; }

        public void registrar()
        {
            AlumnoDAO alumnoDao;
            try
            {
                //git
                alumnoDao = new AlumnoDAO();
                alumnoDao.registrar(alumno);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error!!!" + ex.Number + "Ha ocurrido: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Alumno BuscarId(Alumno alu)
        {
            AlumnoDAO alumnoDao;
            try
            {
                alumnoDao = new AlumnoDAO();

                return alumnoDao.Buscarid(alu);
            } catch (SqlException ex)
            {
                MessageBox.Show("Error!!!" + ex.Number + "Ha ocurrido: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public void Modificar()
        {
            AlumnoDAO alumnoDao;
            try
            {
                //git
                alumnoDao = new AlumnoDAO();
                alumnoDao.modificar(alumno);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error!!!" + ex.Number + "Ha ocurrido: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
