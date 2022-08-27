using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_class
{
    internal class tipo_de_pessoa
    {
        //public string cpf;
       // public string cnpj;
        public string estado;
        public string nome;
        

        public void lerEstado()
        {
            Console.WriteLine("\nA  " + estado);
        }
        public void LerNome()
        {
            Console.WriteLine("o nome é: " + nome);
        }

    }
}
