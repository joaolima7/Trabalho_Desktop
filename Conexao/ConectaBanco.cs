using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Desktop.Conexao
{
    internal class ConectaBanco
    {
        SqlConnection con;
        string connectionString = @"Server=.;Database=TRABALHO_DESKTOP_SQL;
                                    Trusted_Connection=True;";

        public SqlConnection conectaSqlServer()
        {
            //cria a conexão com o banco de dados
            con = new SqlConnection(connectionString);

            return con;
        }
    }
}
