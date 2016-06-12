using System;

namespace RPG_MoonOfStone
{
    class RPG_MoS
    {
        static void Main(string[] args)
        {
            Console.Title = "Rythmatismo";
            ControlTeclas();
        }


        #region Posicionamiento de cursor para recibir informacion
        const int POS1 = 20;
        const int POS2 = 15;

        static void PosicionarCursor()
        {
            Console.SetCursorPosition(POS1, POS2);
        }
        #endregion

        static void ControlTeclas()
        {
            ConsoleKeyInfo opcion;

            do
            {
                UIMenu();
                PosicionarCursor();
                opcion = Console.ReadKey();
                switch (opcion.KeyChar)
                {
                    case '1':
                        PosicionarCursor();
                        Console.WriteLine("Has seleccionado Circulear");
                        break;
                    case '2':
                        PosicionarCursor();
                        Console.WriteLine("Has seleccionado Atacar");
                        break;
                    case '3':
                        PosicionarCursor();
                        Console.WriteLine("Has seleccionado Defender");
                        break;
                    case 'Q':
                    case 'q':
                        PosicionarCursor();
                        Console.WriteLine("Fin del programa ...");
                        return;
                    default:
                        Console.WriteLine("Por favor, elija entre las opciones mostradas");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion.Key != ConsoleKey.Q);
        }

        static void UIMenu()
        {

            #region PintaMenu

            int columna = 1;
            const int limLaterales = 11;
            const int limHorizontales = 60;

            Console.Write("\t╔");
            for (int i = 0; i < limHorizontales; i++)
            {

                Console.Write("═");

            }
            Console.Write("╗");

            Console.SetCursorPosition(30, columna);
            Console.WriteLine("Rythmatismo");
            Console.SetCursorPosition(24, ++columna);
            Console.WriteLine("1. Modificar circulo");
            Console.SetCursorPosition(24, ++columna);
            Console.WriteLine("2. Dibujar ataque");
            Console.SetCursorPosition(24, ++columna);
            Console.WriteLine("3. Dibujar defensa");
            Console.SetCursorPosition(24, 7);
            Console.WriteLine("Q. SALIR");
            Console.WriteLine();
            Console.SetCursorPosition(24, 9);
            Console.Write("Por favor, pulsa una opción:");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("\t╚");
            for (int i = 0; i < limHorizontales; i++)
            {

                Console.Write("═");
            }

            Console.Write("╝");


            for (int i = 1; i < limLaterales; i++)
            {

                Console.SetCursorPosition(69, i);
                Console.WriteLine("║");
            }

            for (int i = 1; i < limLaterales; i++)
            {
                Console.SetCursorPosition(8, i);
                Console.WriteLine("║");
            }

            #endregion

            #region El menu de usuario

            // Constantes para dibujar menu pequeño
            const int largoIU = 37;
            const int limIzqIU = 19;
            const int limDerIU = 57;

            Console.SetCursorPosition(limIzqIU, 14);
            Console.Write("╔");
            for (int i = 0; i < largoIU; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");

            Console.SetCursorPosition(limIzqIU, 15);
            Console.Write("║");
            Console.SetCursorPosition(limIzqIU, 16);
            Console.Write("╚");
            for (int i = 0; i < largoIU; i++)
            {
                Console.Write("═");
            }
            Console.SetCursorPosition(limDerIU, 15);
            Console.Write("║");
            Console.SetCursorPosition(limDerIU, 16);
            Console.Write("╝");

            #endregion
        }
    }
}
