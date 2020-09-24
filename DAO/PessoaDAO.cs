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
        String fullPath = @"C:\Users\Thiago G Ramos\source\repos\20202_aula_exemplo_CPTI\bd.txt";

        #region "Operações com Arquivos"

        public bool SalvarPessoaNoArquivo(Pessoa _obj)
        {
            bool resultado = false;
            try
            {
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

        public Dictionary<Int64, Pessoa> ListarPessoasDoArquivo()
        {
            Dictionary<Int64, Pessoa> tabelaPessoas = new Dictionary<Int64, Pessoa>();

            try
            {
                StreamReader leitor = new StreamReader(fullPath);

                String arquivo = leitor.ReadToEnd();

                char[] divisorLinhas = { '\n' };
                char[] divisorColunas = { ';' };

                string[] linhas = arquivo.Split(divisorLinhas);

                for (int i = 0; i < linhas.Length -1; i++)
                {
                    string[] colunas = linhas[i].Split(divisorColunas);

                    Pessoa p = new Pessoa();

                    p.Cpf = Convert.ToInt64(colunas[0]);
                    p.Nome = colunas[1];
                    p.Tel = colunas[2];
                    p.Email = colunas[3];
                    p.TipoEndereco = Convert.ToInt32(colunas[4]);
                    p.Logradouro = colunas[5];
                    p.Estado = Convert.ToInt32(colunas[6]);
                    p.Cidade = Convert.ToInt32(colunas[7]);
                    p.Genero = colunas[8];
                    p.EstadoCivil = colunas[9];
                    p.Animais = Convert.ToBoolean(colunas[10]);
                    p.Filhos = Convert.ToBoolean(colunas[11]);
                    p.Fumante = Convert.ToBoolean(colunas[12]);

                    tabelaPessoas.Add(p.Cpf, p);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabelaPessoas;
        }

        #endregion

        #region "Operações com Banco de Dados"
       
       
        #endregion
    }
}
