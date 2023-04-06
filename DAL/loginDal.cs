using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestock.DAL
{
    internal class loginDal
    {
        public bool existe = false;
        public string mensagem = "";
        SqlCommand cmd = new SqlCommand();
        conexao con = new conexao();
        SqlDataReader dr;
        public bool verificarLogin(string login, string senha)
        {

            //Comando sql para verificar se existe os dados no banco
            cmd.CommandText = "select*from logins where email=@login and senha=@senha";
            cmd.Parameters.AddWithValue("@login",login);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = con.conectar();
                dr= cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    existe = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro com banco de dados!";
            }
            return existe;
        }
        public string Cadastrar(string nome, string email, string senha, string codigo)
        {

        }
    }
}
