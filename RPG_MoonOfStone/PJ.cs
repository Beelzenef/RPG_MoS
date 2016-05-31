using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_MoonOfStone
{
    class PJ
    {
        string _nombre;

        public string Nombre { get; set; }

        public void ModificarNombre()
        {
            Console.WriteLine("Escribe el nombre del personaje: ");
            Nombre = Console.ReadLine();
        }
    }
}
