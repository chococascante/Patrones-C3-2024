using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesCreacionales
{
    public class Program
    {
        public void Main()
        {
            // PracticaSingleton
            GameManager gameManager = GameManager.GetInstance();
            gameManager.EmpezarJuego(5, 10);

            gameManager.ImprimirListas();
            /*
             Jugador 1
            Jugador 2
            Jugador 3
            Jugador 4
            Jugador 5
             */

            GameManager gameManager2 = GameManager.GetInstance();
            gameManager2.ImprimirListas();

            /*
             Jugador 1
            Jugador 2
            Jugador 3
            Jugador 4
            Jugador 5
             */
        }
    }
}
