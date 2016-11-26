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
        int posicionX;
        int posicionY;

        public string Nombre { get { return _nombre; } set { _nombre = value; } }

        public int PosicionX {
            get { return posicionX; }
            set {
                if (value < 0)
                    value = 0;
                if (value > 79)
                    value = 79;
                posicionX = value;
            }
        }
        public int PosicionY
        {
            get { return posicionY; }
            set
            {
                if (value <= 0)
                    value = 0;
                if (value >= 23)
                    value = 23;
                posicionY = value;
            }
        }

        public void ControlMov(ConsoleKeyInfo mov)
        {
            if (mov.Key == ConsoleKey.LeftArrow)
                PosicionX -= 1;
            if (mov.Key == ConsoleKey.RightArrow)
                PosicionX += 1;

            if (mov.Key == ConsoleKey.UpArrow)
                PosicionY -= 1;
            if (mov.Key == ConsoleKey.DownArrow)
                PosicionY += 1;
        }

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

        public PJ(int posX, int posY)
        {
            PosicionX = posX;
            PosicionY = posY;
        }

    }

    class Rythmatista
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
        // Campos

        int _nTizoides;
        int _nCirculosProteccion;

        // Propiedades

        public int TizoidesInvocados
        {
            get { return _nTizoides; }
            set { _nTizoides = value; }
        }

        public int CirculosProteccion
        {
            get { return _nCirculosProteccion; }
            set
            {
                if (_nCirculosProteccion <= 0)
                    _nCirculosProteccion = 0;
                else
                    _nCirculosProteccion = value;
            }
        }

        public bool Vivo { get; set; }

        // Métodos

        void CrearLineaCustodia()
        {
            CirculosProteccion++;
        }

        void DestruirLineaCustodia()
        {
            CirculosProteccion--;
        }

        void CrearLineaProhibicion()
        {

        }

        void CrearLineaCreacion()
        {
            TizoidesInvocados++;
        }

        void CrearLineaVigor()
        {

        }

        void Defender()
        {
            if (CirculosProteccion == 0)
                Vivo = false;
        }

        void Atacar()
        {

        }
    }
}