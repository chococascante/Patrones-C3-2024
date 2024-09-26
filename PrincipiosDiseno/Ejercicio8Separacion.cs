public class AdministracionDeEmpleados
{
    public void ContratarEmpleado(string nombre)
    {
        Console.WriteLine($"Empleado {nombre} contratado.");
    }
}

public class GestionDePagos
{
    public void ProcesarPago(string nombre, double salario)
    {
        Console.WriteLine($"Procesando pago de {salario} a {nombre}.");
    }
}
