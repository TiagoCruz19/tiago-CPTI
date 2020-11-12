using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace DAO
{
    public static class BD
    {
        private static String strConexao = @"Data Source=C:\Users\Thiago G Ramos\source\repos\20202_aula_exemplo_CPTI\app_bd.sdf;Password=123";
        private static SqlCeConnection conexao;

        public static void AbrirConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Closed)
                    {
                        conexao.ConnectionString = strConexao;
                        conexao.Open();
                    }
                }
                else
                {
                    conexao = new SqlCeConnection(strConexao);
                    conexao.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void FecharConexao()
        {
            try
            {
                if (conexao != null)
                {
                    if (conexao.State == ConnectionState.Open)
                    {
                        conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static SqlCeDataReader ExecutarSelect(String _SQL)
        {
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                SqlCeDataReader data = comando.ExecuteReader();

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static int ExecutarIDU(String _SQL)
        {
            int linhasAfetadas = 0;
            try
            {
                AbrirConexao();

                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);

                linhasAfetadas = comando.ExecuteNonQuery();

                FecharConexao();

                return linhasAfetadas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Object ExecutarInsertComRetornoID(String _SQL, List<SqlCeParameter> _parametros)
        {
            try
            {
                // Execução do INSERT
                AbrirConexao();
                SqlCeCommand comando = new SqlCeCommand(_SQL, conexao);
                comando.Parameters.AddRange(_parametros.ToArray());
                comando.ExecuteNonQuery();

                //RETURNO DA CHAVE PRIMEIRA DE FORMA GENÉRICA (Pode ser Qualquer Tipo)
                comando.CommandText = "SELECT @@IDENTITY";
                Object chavePrimaria = comando.ExecuteScalar();

                FecharConexao();

                return chavePrimaria;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
