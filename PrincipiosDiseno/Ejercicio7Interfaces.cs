public interface IMotor
{
    void Encender();
}

public class MotorCombustion : IMotor
{
    public void Encender()
    {
        Console.WriteLine("Motor de combustión encendido.");
    }
}

public class MotorElectrico : IMotor
{
    public void Encender()
    {
        Console.WriteLine("Motor eléctrico encendido.");
    }
}

public class Automovil
{
    private IMotor motor;

    public Automovil(IMotor motor)
    {
        this.motor = motor;
    }

    public void EncenderMotor()
    {
        motor.Encender();
    }
}
