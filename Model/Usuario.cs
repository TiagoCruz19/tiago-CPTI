using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario : Pessoa
    {
        //Declarando atributo Explicitamente
        private String login;
        public String Login 
        { 
            get => login; 
            set => login = value; 
        }

        //Declarando atributo Implicitamente
        public String Senha { get; set; }
    }
}
