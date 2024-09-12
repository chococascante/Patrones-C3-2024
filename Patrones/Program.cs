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
            Empleado empleado = new("Juan", 10, 10);
            Consultor consultor = new("Pedro", 5, 10);
            Gerente gerente = new("Maria", 50, 10);

            Console.WriteLine(empleado.CalcularSalario());
            Console.WriteLine(consultor.CalcularSalario());
            Console.WriteLine(gerente.CalcularSalario());
        }
    }
}
