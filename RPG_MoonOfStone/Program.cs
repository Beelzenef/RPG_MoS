using System;

namespace RPG_MoonOfStone
{
    class RPG_MoS
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcion = 0;
            string nombre = string.Empty;

            while (opcion != 4)
            {
                Console.WriteLine("Menu para RPG");
                Console.WriteLine();
                Console.WriteLine("1. Elegir nombre");
                Console.WriteLine("2. Elegir profesion");
                Console.WriteLine("3. Elegir nombre del mundo");
                Console.WriteLine("4. Salir");
                Console.WriteLine();

                Console.Write("Elige tu opcion");
                opcion = ObtenerNum();
            }
        }

        static int ObtenerNum()
        {
            int num = 0;
            bool valido = false;

            while (!valido)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Numero no valido");
                    Console.WriteLine("Intentalo de nuevo");
                }
            }
            return num;
        }
    }
}
