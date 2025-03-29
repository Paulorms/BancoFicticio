using System.Globalization;

namespace BancoFictio;

public class Cliente
{
    public int Numero { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }

    public Cliente(int numero, string titular)
    {
      Numero = numero;
      Titular = titular;
    }

    public Cliente(int numero, string titular, double saldo) : this(numero, titular)
    {
        Saldo = saldo;
    }

    public void Deposito(double valor)
    {
        Saldo += valor;
    }

    public void Saque(double valor)
    {
        Saldo = Saldo - valor - 5;
    }
    public override string ToString()
    {
        return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
}