using Objetos.Aula2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario(); // funcionario1 é um Objeto da Classe Funcionário (tipo de)
            funcionario1.nome = "Tiao";
            funcionario1.sobrenome = "Caminhao";
            funcionario1.idade = 55;
            funcionario1.email = "tiaocaminhao@nao.cao";

            funcionario1.MostraNomeESobrenome(); // Chamada do metodo
            funcionario1.MostraODobroDaIdade();
            funcionario1.MostraEmail();

            Console.ReadKey();
        }
    }
}
