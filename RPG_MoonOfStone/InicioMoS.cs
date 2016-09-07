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
                PintarCaja(11, 60);
                SeccionOpcion();
                Descripcion(" ");
                PosicionarCursor();
                opcion = Console.ReadKey();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        PosicionarCursor();
                        Console.WriteLine("Has seleccionado Explorar");
                        break;
                    case ConsoleKey.D2:
                        PosicionarCursor();
                        Console.WriteLine("Has seleccionado Avanzar");
                        break;
                    //case ConsoleKey.D3:
                    //    PosicionarCursor();
                    //    Console.WriteLine("Has seleccionado Defender");
                    //    break;
                    case ConsoleKey.Q:
                        PosicionarCursor();
                        Console.WriteLine("Fin del programa ...");
                        return;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion.Key != ConsoleKey.Q);
        }

        #region PintaMenu

        static void PintarCaja(int limLaterales, int limHorizontales)
        {           

            int columna = 1;

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
            //Console.SetCursorPosition(24, ++columna);
            //Console.WriteLine("3. Dibujar defensa");
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
        }
        #endregion

        #region El menu de usuario

        static void SeccionOpcion()
        {
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
        }

        static void Descripcion(string entradaTexto)
        {
            //string contenido = "Bienvenido a la biblioteca de Rythmatismo. Aquí aprenderás todo lo necesario para dibujar los Circulos que te permitirán sobrevivir en este mundo lleno de magia. Porque la noche es oscura y alberga horrores";
            string[] separadores = {" ", ".", "," };
            string[] palabras = entradaTexto.Split(separadores, StringSplitOptions.RemoveEmptyEntries);

            int posicion = 18;            

            for (int i = 0; i < palabras.Length; i++)
            {
                if (i % 10 == 0)
                {
                    posicion++;
                    Console.SetCursorPosition(5, posicion);
                }
                Console.Write(palabras[i] + " ");
            }


        }

        #endregion
    }
}
