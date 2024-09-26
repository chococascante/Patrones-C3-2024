public class Motor
{
    public void Encender()
    {
        Console.WriteLine("Motor encendido.");
    }
}

public class Bicicleta
{
    public void Pedalear()
    {
        Console.WriteLine("Pedaleando...");
    }
}

public class Carro
{
    private Motor motor = new Motor();

    public void Encender()
    {
        motor.Encender();
    }
}
