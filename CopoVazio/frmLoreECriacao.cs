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
    public partial class frmLoreECriacao : Form
    {
        public frmLoreECriacao()
        {
            InitializeComponent();
        }

        private void lblLore_Click(object sender, EventArgs e)
        {

        }

        private void btnCriarPersonagem_Click(object sender, EventArgs e)
        {
            frmCriarPersonagem criarPersonagem = new frmCriarPersonagem();
            criarPersonagem.Show();
        }
    }
}
