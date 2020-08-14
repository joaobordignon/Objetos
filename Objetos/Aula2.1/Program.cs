using Objetos.Aula2._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Aula2._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = "Geronimo";
            p1.idade = 99;
            p1.salario = 1000;

            p1.Escrever();
            Console.WriteLine(p1.RetornaDezPorcentoDoSalario());
            Console.WriteLine(p1.PorcentoSalario(50));

            Console.ReadKey();
        }
    }
}
