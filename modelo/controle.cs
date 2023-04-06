using Gestock.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestock.modelo
{
    public class controle
    {
        public bool existe;
        public string mensagem = "";
        public bool Entrar(string login, string senha)
        {
            loginDal loginDal = new loginDal();
            existe = loginDal.verificarLogin(login, senha);
            if (!loginDal.mensagem.Equals(""))
            {
                this.mensagem = loginDal.mensagem;
            }
            return existe;
        }
        public string Cadastro(string nome, string email, string senha, string codigo)
        {
            //Comando para inserir no banco
            return mensagem;
        }
    }
    
}
