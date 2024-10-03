using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCreacionales
{
    public class Pizza
    {
        public bool Queso { get; set; }
        public bool Pepperoni { get; set; }
        public bool Piña { get; set; }
        public bool Jamón { get; set; }
        public bool Hongos { get; set; }

        public void MostrarIngredientes()
        {
            Console.WriteLine($"Pizza con: " +
                               $"{(Queso ? "Queso" : "")}" +
                               $"{(Pepperoni ? "Pepperoni" : "")}" +
                               $"{(Piña ? "Piña" : "")}" +
                               $"{(Jamón ? "Jamón" : "")}" +
                               $"{(Hongos ? "Hongos" : "")}");
        }
    }
    public class PizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public PizzaBuilder AgregarQueso()
        {
            _pizza.Queso = true;
            return this;
        }

        public PizzaBuilder AgregarPepperoni()
        {
            _pizza.Pepperoni = true;
            return this;
        }

        public PizzaBuilder AgregarPiña()
        {
            _pizza.Piña = true;
            return this;
        }

        public PizzaBuilder AgregarJamón()
        {
            _pizza.Jamón = true;
            return this;
        }

        public PizzaBuilder AgregarHongos()
        {
            _pizza.Hongos = true;
            return this;
        }

        public Pizza Build() => _pizza;
    }

    public class Program
    {
        public static void Main()
        {
            Pizza pizza = new PizzaBuilder().AgregarQueso().AgregarPepperoni().Build();
            pizza.MostrarIngredientes();
        }
    }
}
