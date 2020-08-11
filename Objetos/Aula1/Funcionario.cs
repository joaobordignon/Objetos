using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Aula1
{
    public class Funcionario
    {
        public string nome;
        public string sobrenome;
        public string email;
        public int idade;

        public void MostraEmail()
        {
            Console.WriteLine($"E-mail: {email}");
        }

        public void MostraODobroDaIdade()
        {
            Console.WriteLine($"O Dobro da idade é {idade*2}.");
        }

        public void MostraNomeESobrenome()
        {
            Console.WriteLine($"{nome} {sobrenome}.");
        }
    }

}
