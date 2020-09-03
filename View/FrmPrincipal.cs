using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mniLogotipo_Click(object sender, EventArgs e)
        {

        }

        private void mniNovo_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            form.ShowDialog();
        }

        private void btiNovo_Click(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            form.ShowDialog();
        }


        private void abrir_janela_novo(object sender, EventArgs e)
        {
            FrmCadPessoa form = new FrmCadPessoa();

            form.ShowDialog();
        }

        private void relogio_Tick(object sender, EventArgs e)
        {
            bsiDataHora.Text = DateTime.Now.ToString();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            relogio.Enabled = true;
            //relogio.Interval = 1000;
        }
    }
}
