using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCreacionales
{
    /*
    1. Crear una clase GameManager que sea Singleton.
    2. La clase GameManager debe tener un método para iniciar el juego, que recibe la cantidad
    de jugadores y enemigos.
    4. La clase GameManager debe tener un arreglo de jugadores.
    5. La clase GameManager debe tener un arreglo de enemigos.
    6. La clase GameManager debe tener un método que imprima la cantidad de jugadores y enemigos.
    
    ¿Cómo lo probamos?
    1. Llamamos al GetInstance del singleton una primera vez.
    2. Llamamos al método de iniciar juego.
    3. Llamamos al método de imprimir cantidad de jugadores y enemigos.
    4. Llamamos al GetInstance una segunda vez.
    5. Llamamos al método de imprimir cantidad de jugadores y enemigos.
     */
    public class GameManager
    {
        private static GameManager _instance;
        private List<Jugador> _listaJugadores;
        private List<Enemigo> _listaEnemigos;

        private GameManager()
        {
            _listaJugadores = new();
            _listaEnemigos = new();
        }

        public static GameManager GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GameManager();
            }

            return _instance;
        }

        public void EmpezarJuego(int numeroJugadores, int numeroEnemigos)
        {
            for (int i = 0; i < numeroJugadores; i++)
            {
                _listaJugadores.Add(new Jugador($"Jugador#{i}"));
            }

            for (int i = 0; i < numeroEnemigos; i++)
            {
                _listaEnemigos.Add(new Enemigo($"Enemigo#{i}"));
            }
        }

        public void ImprimirListas()
        {
            foreach (var jugador in _listaJugadores)
            {
                Console.WriteLine($"Jugador: {jugador.Nombre}");
            }

            foreach (var enemigo in _listaEnemigos)
            {
                Console.WriteLine($"Enemigo: {enemigo.Nombre}");
            }
        }
    }
        public class Jugador
        {
            public string Nombre { get; set; }
            public int Puntaje { get; set; }

            public Jugador(string nombre)
            {
                Nombre = nombre;
            }

        }
    public class Enemigo
    {
        public string Nombre { get; set; }
        public int Danno { get; set; }

        public Enemigo(string nombre)
        {
            Nombre = nombre;
        }
    }
}

