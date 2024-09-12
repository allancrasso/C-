using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Media
    {
        public void calcularMedia() {

            double nota1, nota2, media;

            Console.WriteLine("Informe a nota 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if (media >= 7.0)
            {
                Console.WriteLine("O aluno foi aprovado com média: " + media);
            }
            else
            {

                Console.WriteLine("O aluno foi reprovado com média: " + media);
            }

        }
    }
}
