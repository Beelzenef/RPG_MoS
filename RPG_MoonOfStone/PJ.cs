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
        int _nivel;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public void ModificarNombre()
        {
            Console.WriteLine("Escribe el nombre del personaje: ");
            Nombre = Console.ReadLine();
        }
        public int Nivel
        {
            get { return _nivel; }
            private set { _nivel = value; }
        }

    }

    class Rythmatista : PJ
    {
        // Campos

        TiposTiza _tiza;
        CirculoInvocacion _circuloRythmatico;

        // Propiedades

        public TiposTiza Tiza
        {
            get { return _tiza; }
            private set { _tiza = value; }
        }

        public CirculoInvocacion Circulo
        {
            get { return _circuloRythmatico; }
            set { _circuloRythmatico = value; }
        }

        public bool Activacion { get; set; }

        // Metodos

        void DibujarCirculo()
        {
            Circulo = new CirculoInvocacion();
            Activacion = true;
        }

        void DestruccionDeCirculo()
        {
            Circulo = null;
        }

        // Datos privados

        public enum TiposTiza
        {
            Roja, Blanca, Azul
        }
    }

    class CirculoInvocacion
    {
    }
}