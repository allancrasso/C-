using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class ContraCheque
    {
        public void calcularSalario()
        {
            double salarioAtual, salarioAumento, salarioLiquido, desconto ;
            
            Console.WriteLine("Informe o salário Atual do funcionário: ");
            salarioAtual = Convert.ToDouble(Console.ReadLine());

            salarioAumento = (salarioAtual * 1.15);

            desconto = (salarioAumento * 0.08);

            salarioLiquido = salarioAumento - desconto ;

            Console.WriteLine("------Pagamento em Folha Mensal-------");
            Console.WriteLine("Proventos: R$"+salarioAumento);
            Console.WriteLine("Descontos: R$" + desconto);
            Console.WriteLine("Salário Líquido: R$"+ salarioLiquido);
        }
    }
}
