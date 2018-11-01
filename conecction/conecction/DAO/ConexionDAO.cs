using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conecction.daw
{
    class ConexionDAO
    {
        SqlConnection conn;
        public SqlConnection Con { get => conn; set => conn = value; }
        
        public void conectar()
        {
            string connectionString = "Server=DESKTOP-NIH2TEG;" +
                    "persist security info= True; Integrated Security = true;" +
                    "Database = it707;";
            try
            {
                conn = new SqlConnection(connectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
        }
    }
}
