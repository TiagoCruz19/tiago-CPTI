using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace Control
{
    public class PessoaCtrl
    {
        #region "Métodos de acesso ao arquivo"

        public bool SalvarPessoaNoArquivo(Pessoa _obj)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.SalvarPessoaNoArquivo(_obj);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO SALVAR PESSOA NO ARQUIVO" + ex.Message);
            }

        }

        #endregion
    }
}
