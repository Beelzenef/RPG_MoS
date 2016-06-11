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