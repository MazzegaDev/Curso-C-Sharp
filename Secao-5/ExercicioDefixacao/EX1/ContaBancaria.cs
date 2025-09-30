
using System.Globalization;

public class ContaBancaria
{
    public double _saldo { get; private set; }
    public int _numero { get; private set; }
    public string Nome;

    
    public ContaBancaria(double saldo, int numero, string nome)
    {
        _saldo = saldo;
        _numero = numero;
        Nome = nome;
    }

    public void Deposito(double quantia)
    {
        _saldo += quantia;
    }
    public void Saque(double quantia)
    {

        _saldo = _saldo - 5.00;
        _saldo = _saldo - quantia;
    }

    public override string ToString()
    {
        return $"Conta: {_numero}, Titular: {Nome}, Saldo: {_saldo.ToString("F2", CultureInfo.InvariantCulture)}";
    }
}
