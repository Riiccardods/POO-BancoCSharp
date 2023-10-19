using BancoCSharp.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*******************************************************");
        Console.WriteLine("****************** Banco CSharp ***********************");
        Console.WriteLine("*******************************************************");
        Console.WriteLine();



        var endereco = new Endereco
        {
            Cep = "28000485",
            Rua = "Rua xyz",
            Numero = 52
        };
        var titular01 = new Titular("jose da silva", "12345678912345", "219877542150", endereco);


        var conta01 = new ContaBancaria(titular01, 100);



        Console.WriteLine(conta01.Saldo);
    }
}