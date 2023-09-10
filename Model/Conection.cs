using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Desktop.Model
{
    internal class Conection
    {

        private string cnStg = @"Data Source=localhost;Initial Catalog=animal;Integrated Security=True";
        SqlConnection con = new SqlConnection();

        public SqlConnection conectar()
        {
            con.ConnectionString = cnStg;
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
