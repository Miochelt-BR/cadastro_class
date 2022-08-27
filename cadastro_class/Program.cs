using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastro_class
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            bool lopp = true;
            do
            {
                pessoafisica pessoaf = new pessoafisica();
                pessoajuridica pj = new pessoajuridica();
                Console.WriteLine("digite seu cpf");
                pessoaf.cpf = Console.ReadLine();
                Console.WriteLine("digiteo seu cnpj");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("digiteo seu nome");
                pessoaf.nome = Console.ReadLine();
                pessoaf.LerNome();  
                Console.WriteLine("digite s para sair ou n para continuar ");

               var texto= Console.ReadLine();
                if (texto == "s") lopp= false;
            } while  (lopp); 
              



        }
    }
}
