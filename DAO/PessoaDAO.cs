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
        
        public bool SalvarPessoaNoArquivo(Pessoa _obj)
        {
            bool resultado = false;
            try
            {
                String fullPath = @"C:\Users\Thiago G Ramos\source\repos\20202_aula_exemplo_CPTI\bd.txt";

                StreamWriter escritor = new StreamWriter(fullPath, true);

                escritor.Write(_obj.Cpf + ";");
                escritor.Write(_obj.Nome + ";");
                escritor.Write(_obj.Tel + ";");
                escritor.Write(_obj.Email + ";");
                escritor.Write(_obj.TipoEndereco + ";");
                escritor.Write(_obj.Logradouro + ";");
                escritor.Write(_obj.Estado + ";");
                escritor.Write(_obj.Cidade + ";");
                escritor.Write(_obj.Genero + ";");
                escritor.Write(_obj.EstadoCivil + ";");
                escritor.Write(_obj.Animais + ";");
                escritor.Write(_obj.Filhos + ";");
                escritor.Write(_obj.Fumante + ";");

                escritor.WriteLine();

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
