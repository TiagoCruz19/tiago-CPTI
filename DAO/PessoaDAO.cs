using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class PessoaDAO
    {
        String dir;
        String nomeArquivo;

        #region "Operações com Arquivos"
        
        public bool SalvarPessoaNoArquivo(Pessoa _o)
        {
            bool resultado = false;
            try
            {
                String fullPath = @"C:\Users\Thiago G Ramos\source\repos\20202_aula_exemplo_CPTI\bd.txt";

                StreamWriter escritor = new StreamWriter(fullPath, true);

                escritor.Write(_o.Cpf + ";");
                escritor.Write(_o.Nome + ";");

                escritor.Close();
                resultado = true;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        #endregion

        #region "Operações com Banco de Dados"

        #endregion
    }
}
