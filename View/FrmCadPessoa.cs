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
using Control;

namespace View
{
    public partial class FrmCadPessoa : Form
    {
        public FrmCadPessoa()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = CarregarPessoaDoForm();

                PessoaCtrl control = new PessoaCtrl();

                if(control.SalvarPessoaNoArquivo(p))
                {
                    MessageBox.Show("Cadastro efetuado com sucesso!!!");
                }
                else
                {
                    MessageBox.Show("Cadastro NÃO efetuado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Pessoa CarregarPessoaDoForm()
        {
            Pessoa p = new Pessoa();
            try
            {
                p.Cpf = Convert.ToInt64(mtbCpf.Text.Replace(".", "").Replace("-", ""));

                p.Nome = txbNome.Text;

                p.Tel = mtbTel.Text;

                p.Email = txbEmail.Text;

                p.TipoEndereco = ltbTipoLogr.SelectedIndex;

                p.Logradouro = txbLogradouro.Text;

                p.Estado = cmbEstado.SelectedIndex;

                p.Cidade = cmbCidade.SelectedIndex;

                if (rdbMasculino.Checked)
                {
                    p.Genero = "masculino";
                }
                else if (rdbFeminino.Checked)
                {
                    p.Genero = "feminino";
                }
                else
                {
                    p.Genero = "semresposta";
                }

                if (rdbCasado.Checked)
                {
                    p.EstadoCivil = "casado";
                }
                else if (rdbSolteiro.Checked)
                {
                    p.EstadoCivil = "solteiro";
                }
                else
                {
                    p.EstadoCivil = "viuvo";
                }

                p.Filhos = ckbFilhos.Checked;

                p.Animais = ckbAnimais.Checked;

                p.Fumante = ckbFumante.Checked;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS DO FORM: " + ex.Message);
            }

            return p;
        }

        private void CarregarFormDePessoa(Pessoa _pessoa)
        {
            try
            {
                mtbCpf.Text = _pessoa.Cpf.ToString();

                txbNome.Text = _pessoa.Nome;

                txbEmail.Text = _pessoa.Email;

                mtbTel.Text = _pessoa.Tel;

                ltbTipoLogr.SelectedIndex = _pessoa.TipoEndereco;

                txbLogradouro.Text = _pessoa.Logradouro;

                cmbEstado.SelectedIndex = _pessoa.Estado;

                cmbCidade.SelectedIndex = _pessoa.Cidade;

                if (_pessoa.Genero.Equals("masculino"))
                {
                    rdbMasculino.Checked = true;
                }
                else if (_pessoa.Genero.Equals("feminino"))
                {
                    rdbFeminino.Checked = true;
                }
                else
                {
                    rdbSemReposta.Checked = true;
                }

                if (_pessoa.EstadoCivil.Equals("casado"))
                {
                    rdbCasado.Checked = true;
                }
                else if (_pessoa.EstadoCivil.Equals("solteiro"))
                {
                    rdbSolteiro.Checked = true;
                }
                else
                {
                    rdbViuvo.Checked = true;
                }

                ckbFilhos.Checked = _pessoa.Filhos;
                ckbAnimais.Checked = _pessoa.Animais;
                ckbFumante.Checked = _pessoa.Fumante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM: " + ex.Message);
            }
            
        }
    }
}
