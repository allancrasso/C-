using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class Lanchonete
    {
        public void calcularQuantidade()
        {
            int quantidadeLanches;
            const double pesoQueijo = 50.0;
            const double pesoPresunto = 50.0;
            const double pesoHamburguer = 100.0;
            const double valorQueijo = 49.12;
            const double valorPresunto = 28.30;
            const double valorCarne = 39.89;
            const double valorPao = 0.92;
            

            double qtdQueijo, qtdPresunto, qtdHamburguer, faturamento, lucro,kgPao;
            faturamento = 32.40;


            Console.WriteLine("Informe a quantidade de lanches a ser feito: ");
            quantidadeLanches = Convert.ToInt32(Console.ReadLine());

            qtdQueijo = quantidadeLanches * 2 * pesoQueijo;
            qtdPresunto = quantidadeLanches * pesoPresunto;
            qtdHamburguer = quantidadeLanches * pesoHamburguer;
            kgPao = (50 * quantidadeLanches) / 1000;

            qtdQueijo /= 1000.0;  // Equivale a qtdQueijoKg = qtdQueijo/1000
            qtdPresunto /= 1000.0;
            qtdHamburguer /= 1000.0;

            faturamento = quantidadeLanches * faturamento;
            double despesa = ((valorQueijo * 0.1) + (valorPresunto / 20) + (valorCarne * 0.1) + valorPao)*quantidadeLanches;
            lucro = faturamento - despesa;

            Console.WriteLine("Quantidade de material necessário para fazer "+quantidadeLanches+" lanches");
            Console.WriteLine("Quantidade de queijo (Kg):" + qtdQueijo);
            Console.WriteLine("Quantidade de presunto (Kg)"+ qtdPresunto);
            Console.WriteLine("Quantidade de carne de hamburguer (Kg):" + qtdHamburguer);
            Console.WriteLine("Quantidade de Pães (Kg):" + kgPao);
            Console.WriteLine("Faturamento:R$ " + faturamento);
            Console.WriteLine("Despesa:R$ " + despesa);
            Console.WriteLine("Lucro:R$ " + lucro);



        }
    }
}
