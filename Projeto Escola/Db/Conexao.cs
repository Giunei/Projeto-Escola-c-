using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Escola.Db
{
    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = ""
        }

        public SqlConnection Conectar()
        {

        }

        public void Desconectar()
        {

        }
    }
}
