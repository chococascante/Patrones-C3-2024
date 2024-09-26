public class SistemaDeVentas
{
    private INotificacion notificacion;

    public SistemaDeVentas(INotificacion notificacion)
    {
        this.notificacion = notificacion;
    }

    public void Facturar()
    {
        Console.WriteLine("Facturando...");
        notificacion.Enviar("Factura enviada.");
    }
}

public interface INotificacion
{
    void Enviar(string mensaje);
}

public class EmailService : INotificacion
{
    public void Enviar(string mensaje)
    {
        Console.WriteLine($"Enviando email: {mensaje}");
    }
}
