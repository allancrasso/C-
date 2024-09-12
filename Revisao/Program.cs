using Revisao;
using System;

public class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Método principal do pacote");

        Combustivel combustivel = new Combustivel();
        ContraCheque contraCheque = new ContraCheque();

        Lanchonete lanchonete = new Lanchonete();

        Media media = new Media();

        //combustivel.CalcularCombustivel();

        //contraCheque.calcularSalario();

        //combustivel.MostrarTeste();

        //lanchonete.calcularQuantidade();
        media.calcularMedia();
    }


}
