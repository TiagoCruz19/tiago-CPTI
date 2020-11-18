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
    public partial class FrmReadAll : Form
    {
        private Dictionary<Int64, Pessoa> tabelaPessoas;
        public FrmReadAll()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmReadAll_Load(object sender, EventArgs e)
        {
            CarregarGrid("");
        }

        private void CarregarGrid(String _filtro)
        {
            try
            {
                dgvDados.Rows.Clear();

                //Chamada para o controller (busca dos dados)
                PessoaCtrl control = new PessoaCtrl();

                //Alterado para atender a operação de Filtro por CPF e Nome
                if (_filtro.Equals(""))
                {
                    this.tabelaPessoas = (Dictionary<Int64, Pessoa>)control.BD('t', null);
                }
                else
                {
                    this.tabelaPessoas = (Dictionary<Int64, Pessoa>)control.BD('f', _filtro);
                }

                foreach (Pessoa p in tabelaPessoas.Values)
                {
                    dgvDados.Rows.Add(p.Cpf, p.Nome, p.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR GRID: " + ex.Message);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int64 cpf = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

            Pessoa p = tabelaPessoas[cpf];

            FrmCadPessoa fp = new FrmCadPessoa();

            fp.Tag = p;

            fp.ShowDialog();
        }

        private void imDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 cpf = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                PessoaCtrl control = new PessoaCtrl();

                if ((Boolean)control.BD('d', cpf))
                {
                    MessageBox.Show("Pessoa deletada com sucesso!");

                    CarregarGrid("");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR UM CADASTRO: " + ex.Message);
            }
           
        }

        //Adicionado para implementar as opções de filtro
        private void txbPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CarregarGrid(txbPesquisa.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO FILTRAR O DATA GRID: " + ex.Message);
            }
        }
    }
}
