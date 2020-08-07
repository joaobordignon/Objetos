using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Aula1
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public string email;
        public string endereco;
        public string matricula;

        public void mostraOsDadosDeAlunoNaTela()
        {
            Console.WriteLine("Nome: "+ nome );
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("email: " + email);
            Console.WriteLine("endereco: " + endereco);
            Console.WriteLine("Matricula: " + matricula);
        }
    }
}
