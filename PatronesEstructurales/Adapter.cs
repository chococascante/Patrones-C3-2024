namespace PatronesEstructurales
{
    public interface IDistance
    {
        double GetDistanceInKilometers(double miles);
    }

    public static class MilesToKilometersConverter
    {
        public static double ConvertMilesToKilometers(double miles)
        {
            return miles * 1.60934;
        }
    }

    public class MilesAdapter : IDistance
    {
        public double GetDistanceInKilometers(double miles)
        {
            return MilesToKilometersConverter.ConvertMilesToKilometers(miles);
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Ingrese las millas: ");
    //        string input = Console.ReadLine();

    //        if (double.TryParse(input, out double miles))
    //        {
    //            IDistance adapter = new MilesAdapter();
    //            Console.WriteLine($"Las {miles} millas son {adapter.GetDistanceInKilometers(miles)} kilómetros");
    //        }
    //        else
    //        {
    //            Console.WriteLine("El valor ingresado no es válido");
    //        }
    //    }
    //}
}
