namespace Models.ContaBancaria;

public class ContaBancaria
{
    public decimal Saldo { get; private set; }

    public ContaBancaria(decimal saldoInicial)
    {
        Saldo = saldoInicial;
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
            throw new Exercicios.SaldoInsuficienteException("Saque excede o saldo disponível.");
        Saldo -= valor;
    }
}