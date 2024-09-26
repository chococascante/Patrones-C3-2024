public interface IFigura
{
    double CalcularArea();
}

public class Circulo : IFigura
{
    private double radio;

    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }
}

public class Cuadrado : IFigura
{
    private double lado;

    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    public double CalcularArea()
    {
        return lado * lado;
    }
}

public class CalculadoraDeAreas
{
    public double CalcularAreaTotal(List<IFigura> figuras)
    {
        double areaTotal = 0;
        foreach (var figura in figuras)
        {
            areaTotal += figura.CalcularArea();
        }
        return areaTotal;
    }
}
