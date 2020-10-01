using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Login = txbUsuario.Text;
            user.Senha = txbSenha.Text;

            if (ValidarLogin(user))
            {
                this.DialogResult = DialogResult.OK;

                this.Tag = user;

                this.Close();
            }
            else
            {
                lblMsg.Visible = true;
            }
        }

        private bool ValidarLogin(Usuario _user)
        {
            bool resultado;
            try
            {
                if (_user.Login.Equals("thiago") && _user.Senha.Equals("thiago"))
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO de Validação: " + ex.Message);
                return false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    this.Close();
                    break;
                case Keys.Enter:
                    this.btnLogin_Click(null, null);
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
