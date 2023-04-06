using Gestock.Pages;

namespace Gestock
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();

        }

        private void campoUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}