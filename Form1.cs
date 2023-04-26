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
    public partial class FormPrincipal : Form
    {
        //variaveis globais
        float n1, n2, n3, n4, media;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            DtData.Text = DateTime.Now.ToString();
            LblNome.Text = Program.usuario;
        }

        public void Resultado()
        {
            n1 = float.Parse(TxtNota1.Text);
            n2 = float.Parse(TxtNota2.Text);
            n3 = float.Parse(TxtNota3.Text);
            n4 = float.Parse(TxtNota4.Text);

            media = (n1 + n2 + n3 + n4) / 4;

            LblMedia.Text = media.ToString();
        }

        public void MediaAluno()
        {
            if (media < 7)
            {
                LblStatus.Text = "Reprovado";
            }
            else if (media == 7)
            {
                LblStatus.Text = "Aprovado com nota mínima";
            }
            else if (media > 7)
            {
                LblStatus.Text = "Aprovado, parabéns";
            }
        }

        private void BtnExecutar_Click(object sender, EventArgs e)
        {
            Resultado();
            MediaAluno();
        }
    }
}
