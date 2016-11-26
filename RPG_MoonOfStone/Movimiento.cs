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
                pjtillo.ControlMov(tecla);
                Console.SetCursorPosition(pjtillo.PosicionX, pjtillo.PosicionY);
                Console.Write(personaje);
            } while (tecla.Key != ConsoleKey.Escape);
        }
    }
}
