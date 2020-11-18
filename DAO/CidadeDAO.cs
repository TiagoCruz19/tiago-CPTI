using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CidadeDAO
    {
        public Dictionary<Int64, Cidade> ListarCidadesPorEstado(Int64 _idEstado)
        {
            Dictionary<Int64, Cidade> mapaCidades = new Dictionary<Int64, Cidade>();
            try
            {
                String SQL = String.Format("SELECT * FROM cidade WHERE estado_id = {0};", _idEstado);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cidade cidade = new Cidade();

                    cidade.Id = data.GetInt64(0);
                    cidade.Descricao = data.GetString(1);

                    mapaCidades.Add(cidade.Id, cidade);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaCidades;
        }
    }
}
