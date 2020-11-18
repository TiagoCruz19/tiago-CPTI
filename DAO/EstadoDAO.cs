using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EstadoDAO
    {
        public Dictionary<Int64, Estado> GetAll()
        {
            Dictionary<Int64, Estado> mapaEstados = new Dictionary<Int64, Estado>();
            try
            {
                String SQL = "SELECT * FROM estado;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Estado estado = new Estado();

                    estado.Id = data.GetInt64(0);
                    estado.Descricao = data.GetString(1);
                    
                    mapaEstados.Add(estado.Id, estado);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return mapaEstados;
        }
    }
}
