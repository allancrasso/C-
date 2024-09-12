using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Combustivel
    {
        public void CalcularCombustivel()
        {
            double precoLitro, valorPagamento,capacidadeDoTanque, quantidadeLitros;

            Console.WriteLine("Informe o preço do litro do combustível: ");
            precoLitro = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o valor do pagamento realizado: ");
            valorPagamento = Convert.ToDouble(Console.ReadLine());

            quantidadeLitros = (valorPagamento / precoLitro);

            Console.WriteLine("A quantidade de litros abastecida foi de: "+quantidadeLitros+" litros");

            
        }

        public void MostrarTeste()
        {
            Console.WriteLine("Teste");
        }
    }
}
