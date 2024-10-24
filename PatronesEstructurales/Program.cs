namespace PatronesEstructurales
{
    public interface IPizza
    {
        string GetDescription();
        double GetCost();
    }

    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Pizza simple";
        }

        public double GetCost()
        {
            return 4.00;
        }
    }

    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza _pizza;

        protected PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public abstract string GetDescription();
        public abstract double GetCost();
    }

    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, con queso";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.00;
        }
    }

    public class PepperoniDecorator : PizzaDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, con pepperoni";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.50;
        }
    }

    public class MushroomDecorator : PizzaDecorator
    {
        public MushroomDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, con champiñones";
        }

        public override double GetCost()
        {
            return _pizza.GetCost() + 1.00;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new PlainPizza();
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());

            pizza = new CheeseDecorator(pizza);
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());

            pizza = new PepperoniDecorator(pizza);
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());

            pizza = new MushroomDecorator(pizza);
            Console.WriteLine(pizza.GetDescription());
            Console.WriteLine(pizza.GetCost());
        }

    }
}
