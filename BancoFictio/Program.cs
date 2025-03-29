using System.Globalization;

namespace BancoFictio;

class Program
{
    static void Main(string[] args)
    {
        Cliente cliente;
        Console.Write("Entre o número da conta: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial? (s/n) ");
        char haveraDeposito = char.Parse(Console.ReadLine().ToLower());
        if (haveraDeposito == 's')
        {
            Console.Write("Entre o valor do saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             cliente = new Cliente(numero, titular, saldo);
        }
        else
        {
             cliente = new Cliente(numero, titular);
        }

        Console.WriteLine();
        
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(cliente);
        Console.WriteLine();

        Console.Write("Entre um valor para depósito: ");
        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        cliente.Deposito(deposito);
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine(cliente);
        Console.WriteLine();

        Console.Write("Entre um valor para saque: ");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        cliente.Saque(saque);
        Console.WriteLine("Dados atualizados: ");
        Console.WriteLine(cliente);
        
    }
}