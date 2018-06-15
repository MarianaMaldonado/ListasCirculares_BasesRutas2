using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares_BasesRuta2
{
    class Base
    {
        public string _nombre; //{ get; set; }
        public int _minutos; //{ get; set; }
        public Base anterior { get; set; }
        public Base siguiente { get; set; }

        /// <summary>
        /// Propiedad de nombre de la base
        /// </summary>
        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }

        /// <summary>
        /// Propiedad de los minutos
        /// </summary>
        public int Minutos
        {
            get
            {
                return _minutos;
            }

            set
            {
                _minutos = value;
            }
        }

        public Base(string Nombre, int Minutos)
        {
            _nombre = Nombre;
            _minutos = Minutos;


            anterior = null;
            siguiente = null;
        }

        public override string ToString()
        {
            string Base = "Nombre: " + Nombre.ToString() + Environment.NewLine +
                          "Minutos desde la base anterior: " + Minutos.ToString() + Environment.NewLine;

            return Base;
        }
    }
}
