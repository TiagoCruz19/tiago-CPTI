using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class PessoaDAO
    {
        #region "Operações com Arquivos"

        String dir;
        String nomeArquivo;
        String fullPath = @"C:\Users\Thiago G Ramos\source\repos\20202_aula_exemplo_CPTI\bd.txt";

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
       
        public Dictionary<Int64, Pessoa> GetAll()
        {
            Dictionary<Int64, Pessoa> mapaPessoas = new Dictionary<Int64, Pessoa>();
            try
            {
                String SQL = "SELECT * FROM pessoa;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pessoa p = new Pessoa();

                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Tel = data.GetString(2);
                    p.Email = data.GetString(3);
                    p.TipoEndereco = data.GetInt32(4);
                    p.Logradouro = data.GetString(5);
                    p.Cidade = data.GetInt32(6);
                    p.Estado = data.GetInt32(7);
                    p.Genero = data.GetString(8);
                    p.EstadoCivil = data.GetString(9);
                    p.Filhos = data.GetBoolean(10);
                    p.Animais = data.GetBoolean(11);
                    p.Fumante = data.GetBoolean(12);

                    mapaPessoas.Add(p.Cpf, p);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaPessoas;
        }
       
        public Pessoa GetForID(Int64 _cpf)
        {
            Pessoa p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pessoa WHERE id = {0};", _cpf);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Pessoa();

                    p.Cpf = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Tel = data.GetString(2);
                    p.Email = data.GetString(3);
                    p.TipoEndereco = data.GetInt32(4);
                    p.Logradouro = data.GetString(5);
                    p.Cidade = data.GetInt32(6);
                    p.Estado = data.GetInt32(7);
                    p.Genero = data.GetString(8);
                    p.EstadoCivil = data.GetString(9);
                    p.Filhos = data.GetBoolean(10);
                    p.Animais = data.GetBoolean(11);
                    p.Fumante = data.GetBoolean(12);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return p;
        }

        public Boolean Insert(Pessoa _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO pessoa (" +
                    "cpf, " +
                    "nome, " +
                    "tel, " +
                    "email, " +
                    "tipo_endereco, " +
                    "logradouro, " +
                    "cidade, " +
                    "estado, " +
                    "genero, " +
                    "estado_civil, " +
                    "filhos, " +
                    "animais, " +
                    "fumante) " +
                    "VALUES ({0}, '{1}', '{2}', '{3}', {4}, '{5}', {6}, {7}, '{8}', '{9}', '{10}', '{11}', '{12}')",
                    _obj.Cpf,
                    _obj.Nome,
                    _obj.Tel,
                    _obj.Email,
                    _obj.TipoEndereco,
                    _obj.Logradouro,
                    _obj.Cidade,
                    _obj.Estado,
                    _obj.Genero,
                    _obj.EstadoCivil,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Fumante
                    );

                int linhasAfetadas = BD.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean Delete(Int64 _cpf)
        {
            Boolean resultado = false;
            try
            {
                String SQL = "DELETE FROM pessoa WHERE cpf = " + _cpf.ToString();

                int linhasAfetadas = BD.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean Update(Pessoa _obj)
        {
            Boolean resultado = false;
            try
            {
                String SQL = String.Format("UPDATE pessoa SET " +
                    "nome = '{0}', " +
                    "tel = '{1}', " +
                    "email = '{2}', " +
                    "tipo_endereco = {3}, " +
                    "logradouro = '{4}', " +
                    "cidade = {5}, " +
                    "estado = {6}, " +
                    "genero = '{7}', " +
                    "estado_civil = '{8}', " +
                    "filhos = '{9}', " +
                    "animais = '{10}', " +
                    "fumante = '{11}' WHERE cpf = {12}",
                    _obj.Nome,
                    _obj.Tel,
                    _obj.Email,
                    _obj.TipoEndereco,
                    _obj.Logradouro,
                    _obj.Cidade,
                    _obj.Estado,
                    _obj.Genero,
                    _obj.EstadoCivil,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Fumante,
                    _obj.Cpf
                    );

                int linhasAfetadas = BD.ExecutarIDU(SQL);

                if (linhasAfetadas > 0)
                {
                    resultado = true;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        #endregion
    }
}
