using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Aula1
{
    public class programa
    {
        static void Main (string[] args)
        {
            Aluno aluno1 = new Aluno();
            aluno1.nome = "Joao";
            aluno1.idade = 32;
            aluno1.email = "joaobordignon@gmail.com";
            aluno1.endereco = "512-500 rue Axxxd";
            aluno1.matricula = "";

            Professor professor1 = new Professor();
            professor1.nome = "Luana";
            professor1.idade = 31;
            professor1.endereco = "rua do tal, 45";
            professor1.email = "luana@gmail.com";
            professor1.disciplina = "C#";

            aluno1.mostraOsDadosDeAlunoNaTela();
            professor1.mostraOsDadosDeProfessorNaTela();


            Console.ReadKey();
        }
    }
}
