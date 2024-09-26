namespace PatronesCreacionales
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            // Ya debería existir
            return _instance;
        }
    }

    public class DatabaseAccessObject
    {
        private static DatabaseAccessObject _instance;
        private string _connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";

        private DatabaseAccessObject()
        {

        }
        public static DatabaseAccessObject GetInstance() {
            if (_instance == null)
            {
                _instance = new DatabaseAccessObject();
            }

            // Ya debería existir
            return _instance;
        }

        public void EjecutarQuery(string query)
        {
            _instance.EjecutarQuery(query);
        }

        public void EjecutarProcedimientoAlmacenado(string procedimientoAlmacenado)
        {
            // Lógica para ejecutar procedimiento almacenado
        }
    }

    public class Gobierno
    {
        private static Gobierno _instance;
        public string Nombre { get; set; }
        public string? Presidente { get; set; }
        public List<string> ministros;

        private Gobierno()
        {
            Nombre = "Gobierno de Costa Rica";
            Presidente = "X";
            ministros = new List<string>();
        }

        public static Gobierno GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Gobierno();
            }

            return _instance;
        }

        public void AgregarMinistro(string ministro)
        {
            ministros.Add(ministro);
        }

        public void CambiarPresidente(string presidente)
        {
            Presidente = presidente;
        }

        public void CambiarPresidente()
        {
            Presidente = null;
        }
    }

        public class Foo
    {
        public Carro hondaMiedo = new Carro("Honda", "Civic", 4);

        public void Bar()
        {
            hondaMiedo.Bulla();
            Console.WriteLine($"{hondaMiedo.Marca}");
            Singleton singleton = Singleton.GetInstance();
        }
    }

    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int CantidadPuertas { get; set; }

        public Carro(string marca, string modelo, int cantidadPuertas)
        {
            Marca = marca;
            Modelo = modelo;
            CantidadPuertas = cantidadPuertas;
        }

        public void Bulla()
        {
            try
            {
                Console.WriteLine("Bruuum bruuum");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
