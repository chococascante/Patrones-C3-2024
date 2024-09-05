namespace Patrones
{
    class Dog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var empleado = new Empleado("Juan");
            Console.WriteLine($"Hola, {empleado.Nombre}");
        }
    }
}
