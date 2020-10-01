using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Pessoa
    {
        public Int64 Cpf { get; set; }

        public String Nome { get; set; }

        public String Tel { get; set; }

        public String Email { get; set; }

        public Int32 TipoEndereco { get; set; }

        public String Logradouro { get; set; }

        public Int32 Cidade { get; set; }

        public Int32 Estado { get; set; }

        public String Genero { get; set; }

        public String EstadoCivil { get; set; }

        public Boolean Filhos { get; set; }

        public Boolean Animais { get; set; }

        public Boolean Fumante { get; set; }

        public List<Endereco> Enderecos { get; set; }
    }
}
