using System;

namespace TIC_TAC_TOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //0= espacio vacio
            //1 = X
            //2 = O
           int[,] juego = new int[3,3]{{2, 2, 1}, {2, 1, 2, }, {1, 2, 1,}};
           //ganan las X
             if (juego[0,0] == 1 && (juego[0,0] == juego[0,1]) && (juego[0,1] == juego[0,2]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[1, 0] == 1 && (juego[1, 0] == juego[1, 1]) && (juego[1, 1] == juego[1, 2]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[2, 0] == 1 && (juego[2, 0] == juego[2, 1]) && (juego[2, 1] == juego[2, 2]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[0, 0] == 1 && (juego[0, 0] == juego[1, 0]) && (juego[1, 0] == juego[2, 0]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[0, 1] == 1 && (juego[0, 1] == juego[1, 1]) && (juego[1, 1] == juego[2, 1]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[0, 2] == 1 && (juego[0, 2] == juego[1, 2]) && (juego[1, 2] == juego[2, 2]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[0, 0] == 1 && (juego[0, 0] == juego[1, 1]) && (juego[1, 1] == juego[2, 2]))
            {
                Console.WriteLine("ganan las X");
            }
            else if (juego[0, 2] == 1 && (juego[0, 2] == juego[1, 1]) && (juego[1, 1] == juego[2, 0]))
            {
                Console.WriteLine("ganan las x");
            }
            // ganan las O
            if (juego[0,0] == 1 && (juego[0,0] == juego[0,1]) && (juego[0,1] == juego[0,2]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[1, 0] == 2 && (juego[1, 0] == juego[1, 1]) && (juego[1, 1] == juego[1, 2]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[2, 0] == 2 && (juego[2, 0] == juego[2, 1]) && (juego[2, 1] == juego[2, 2]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[0, 0] == 2 && (juego[0, 0] == juego[1, 0]) && (juego[1, 0] == juego[2, 0]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[0, 1] == 2 && (juego[0, 1] == juego[1, 1]) && (juego[1, 1] == juego[2, 1]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[0, 2] == 2 && (juego[0, 2] == juego[1, 2]) && (juego[1, 2] == juego[2, 2]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[0, 0] == 2 && (juego[0, 0] == juego[1, 1]) && (juego[1, 1] == juego[2, 2]))
            {
                Console.WriteLine("ganan las O");
            }
            else if (juego[0, 2] == 2 && (juego[0, 2] == juego[1, 1]) && (juego[1, 1] == juego[2, 0]))
            {
                Console.WriteLine("ganan las O");
            }
            else 
            {
                Console.WriteLine("Empate");
            }

        }
    }
}
