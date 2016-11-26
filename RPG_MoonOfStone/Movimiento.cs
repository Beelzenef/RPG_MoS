using System;

namespace RPG_MoonOfStone
{
    class Movimiento
    {
        char personaje = 'x';
        char caracterBorrado = ' ';    

        PJ pjtillo = new PJ(10, 10);

        public void PosicionPJ()
        {
            ConsoleKeyInfo tecla;
            do
            {
                tecla = Console.ReadKey();
                Console.SetCursorPosition(pjtillo.PosicionX, pjtillo.PosicionY);
                Console.Write(caracterBorrado);
                MovimientoPJ(tecla);
                Console.SetCursorPosition(pjtillo.PosicionX, pjtillo.PosicionY);
                Console.Write(personaje);
            } while (tecla.Key != ConsoleKey.Escape);
        }

        void MovimientoPJ(ConsoleKeyInfo mov)
        {
            if (mov.Key == ConsoleKey.LeftArrow)
                pjtillo.PosicionX += 1;
            if (mov.Key == ConsoleKey.RightArrow)
                pjtillo.PosicionX -= 1;

            if (mov.Key == ConsoleKey.UpArrow)
                pjtillo.PosicionY += 1;
            if (mov.Key == ConsoleKey.DownArrow)
                pjtillo.PosicionY -= 1;

        }
    }
}
