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
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            try
            {
                dgvDados.Rows.Clear();

                //Chamada para o controller (busca dos dados)
                PessoaCtrl control = new PessoaCtrl();

                this.tabelaPessoas = control.ListarPessoasDoArquivo();

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
    }
}
