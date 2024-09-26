public class CalculadoraDeImpuestos
{
    public void CalcularImpuestos()
    {
        Console.WriteLine("Calculando impuestos...");
    }
}

public class ProcesadorDePagos
{
    public void ProcesarPago()
    {
        Console.WriteLine("Procesando pago...");
    }
}

public class ProcesadorDeOrdenes
{
    private CalculadoraDeImpuestos calculadora;
    private ProcesadorDePagos procesador;

    public ProcesadorDeOrdenes()
    {
        calculadora = new CalculadoraDeImpuestos();
        procesador = new ProcesadorDePagos();
    }

    public void ProcesarOrden()
    {
        calculadora.CalcularImpuestos();
        procesador.ProcesarPago();
    }
}
