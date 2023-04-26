using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculaMedia
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (TxtNome.Text.Trim() == "")
            {
                MessageBox.Show("Digite um nome");
                return;
            }
            if (TxtSenha.Text != "123")
            {
                MessageBox.Show("Digite a senha");
                return;
            }

            Program.usuario = TxtNome.Text; 
            
            FormPrincipal form = new FormPrincipal();
            form.ShowDialog();

            this.Close();
        }
    }
}
