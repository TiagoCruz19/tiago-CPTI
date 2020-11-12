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

        public Dictionary<Int64, Pessoa> ListarPessoasDoArquivo()
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                return dao.ListarPessoasDoArquivo();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ACESSAR O ARQUIVO: " + ex.Message);
            }
        }

        #endregion

        #region "Operações com banco de dados"
        public Object BD(char _comando, Object _param)
        {
            try
            {
                PessoaDAO dao = new PessoaDAO();

                switch (_comando)
                {
                    case 't':
                        return dao.GetAll();
                    case 'o':
                        return dao.GetForID((Int64)_param);
                    case 'i':
                        return dao.Insert((Pessoa)_param);
                    case 'd':
                        return dao.Delete((Int64)_param);
                    case 'u':
                        return dao.Update((Pessoa)_param);
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
