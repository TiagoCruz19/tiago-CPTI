using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public class CidadeCtrl
    {
        #region "Operações com banco de dados"
        public Object BD(char _comando, Object _param)
        {
            try
            {
                CidadeDAO dao = new CidadeDAO();

                switch (_comando)
                {
                    /* 
                    case 't':
                        return dao.GetAll();
                       
                    case 'o':
                        //return dao.GetForID((Int64)_param);
                    case 'i':
                        //return dao.Insert((Cidade)_param);
                    case 'd':
                        //return dao.Delete((Int64)_param);
                    case 'u':
                        //return dao.Update((Cidade)_param);
                    */
                    case 'f':
                        return dao.ListarCidadesPorEstado((Int64)_param);
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
