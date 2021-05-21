using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CopoVazio
{
    public partial class frmCriarPersonagem : Form
    {
        public frmCriarPersonagem()
        {
            InitializeComponent();
        }

        private void frmCriarPersonagem_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmarIniciar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(cbRacas.Text))
            {
                MessageBox.Show("Você precisa selecionar uma raça");
                return;
            }
            if (String.IsNullOrEmpty(cbClasse.Text) || cbClasse.Text[0] == ' ')
            {
                MessageBox.Show("Você precisa selecionar uma classe");
                return;
            }
            String saida = "";
            saida += "\nRaça: " + cbRacas.Text;
            saida += "\nClasse: " + cbClasse.Text;

            void desabilitar()
            {
                cbRacas.Enabled = false;
                cbClasse.Enabled = false;
            }

            frmCopoVazio CopoVazio = new frmCopoVazio();
            desabilitar();
            CopoVazio.Show();

        }
    }
}
