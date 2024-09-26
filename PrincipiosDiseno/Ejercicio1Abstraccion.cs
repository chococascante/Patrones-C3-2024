//public class Coche
//{
//    public void Encender()
//    {
//        if (HayCombustible())
//        {
//            Console.WriteLine("Coche encendido.");
//        }
//        else
//        {
//            Console.WriteLine("No hay suficiente combustible.");
//        }
//    }

//    private bool HayCombustible()
//    {
//        // Lógica para verificar el combustible
//        return true; // Supongamos que siempre hay combustible.
//    }
//}

public abstract class Vehiculo
{
    public abstract void Arrancar();
}

public class Coche : Vehiculo
{
    private SensorCombustible sensorCombustible;

    public Coche()
    {
        sensorCombustible = new SensorCombustible();
    }

    public override void Arrancar()
    {
        if (sensorCombustible.HayCombustible())
        {
            Console.WriteLine("El coche está arrancando...");
        }
        else
        {
            Console.WriteLine("No hay suficiente combustible.");
        }
    }
}

public class SensorCombustible
{
    public bool HayCombustible()
    {
        // Lógica interna de comprobación de combustible
        return true; // Simulación de combustible disponible
    }
}

