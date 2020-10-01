using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Endereco
    {
        public Int64 ID { get; set; }

        public String Descricao { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
