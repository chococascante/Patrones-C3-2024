public class CuentaBancaria
{
    private decimal saldo;

    public decimal ObtenerSaldo()
    {
        return saldo;
    }

    public void Depositar(decimal cantidad)
    {
        saldo += cantidad;
    }
}
