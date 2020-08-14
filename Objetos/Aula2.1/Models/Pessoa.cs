using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Aula2._1.Models
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public int salario;


        public void Escrever()
        {
            Console.WriteLine($"eu me chamo {nome} e sou uma pessoa!");
        }

        public double RetornaDezPorcentoDoSalario()
        {
            double dezPorcento = salario * 0.1;
            return dezPorcento;
        }

        public double PorcentoSalario(double porcento)
        {
            double p = (salario * porcento) / 100;
            return p;
        }
    }
}
