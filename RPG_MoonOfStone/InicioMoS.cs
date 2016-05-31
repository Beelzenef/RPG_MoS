using System;

namespace RPG_MoonOfStone
{
    class RPG_MoS
    {
        static void Main(string[] args)
        {
            Console.Title = "Moon of Stone";
            MostrarMenu();
            GestionOpciones();
        }

        

        static void GestionOpciones()
        {
            ConsoleKeyInfo opcion;
            string nombre = string.Empty;
            PJ personaje = new PJ();
            do {
                opcion = Console.ReadKey();
                switch (opcion.KeyChar)
                {
                    case '1':
                        personaje.ModificarNombre();
                        Console.WriteLine(personaje.Nombre);
                        break;
                    case '2':
                        Console.WriteLine("Eleccion de profesion");
                        break;
                    case '3':
                        Console.WriteLine("Eleccion de mundo");
                        break;
                }
                MostrarMenu();
            } while (opcion.Key != ConsoleKey.Q);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Moon of Stone");
            Console.WriteLine();
            Console.WriteLine("1. Elegir nombre");
            Console.WriteLine("2. Elegir profesion");
            Console.WriteLine("3. Elegir nombre del mundo");
            Console.WriteLine("Q. Salir");
            Console.WriteLine();

            Console.WriteLine("Elige tu opcion");
            Console.WriteLine();
        }
    }
}
