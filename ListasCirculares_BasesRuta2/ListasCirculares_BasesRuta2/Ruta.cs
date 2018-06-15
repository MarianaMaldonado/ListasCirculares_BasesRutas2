using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCirculares_BasesRuta2
{
    class Ruta
    {
        Base inicio, ultima, temporal, buscado;

        public Ruta()
        {
            inicio = null;
        }

        public void Agregar(Base nueva)
        {
            if (inicio == null)
            {
                inicio = nueva;
                ultima = nueva;
            }
            else
            {
                ultima.siguiente = nueva;
                nueva.anterior = ultima;
                nueva.siguiente = inicio;
                ultima = nueva;
                inicio.anterior = ultima;
            }
        }

        public void AgregarInicio (Base BaseInicio)
        {
            if(inicio == null)
            {
                inicio = BaseInicio;
                ultima = BaseInicio;
            }
            else
            {
                inicio.anterior = BaseInicio;
                ultima.siguiente = BaseInicio;
                BaseInicio.siguiente = inicio;
                BaseInicio.anterior = ultima;
                inicio = BaseInicio;
            }
        }

        public Base Buscar(string nuevaBase)
        {
            temporal = inicio;
            buscado = null;

            if(ultima.Nombre == nuevaBase)
                buscado = ultima;
            
            else
            
                while(buscado == null && temporal != inicio.anterior)
                
                    if (temporal.Nombre == nuevaBase)
                    
                        buscado = temporal;
                    
                    else
                    
                        temporal = temporal.siguiente;

            return buscado;
        }

        public bool EliminarInicio()
        {
            if (inicio == null)
                return false;
            else
            {
                if(ultima == inicio)
                {
                    inicio = null;
                    ultima = null;
                }
                else
                {
                    inicio = inicio.siguiente;
                    inicio.anterior = ultima;
                    ultima.siguiente = inicio;
                }

                return true;
            }
        }

        public bool EliminarUltima()
        {
            if (inicio == null)
                return false;

            else
            {
                if (ultima == inicio)
                {
                    inicio = null;
                    ultima = null;
                }
                else
                {
                    ultima = ultima.anterior;
                    ultima.siguiente = inicio;
                    inicio.anterior = ultima;
                }

                return true;
            }
        }

        public bool Eliminar(string nuevaBase)
        {
           
            if(Buscar(nuevaBase) != null)
            {
                if (buscado == inicio)
                    EliminarInicio();

                else if (buscado == ultima)
                    EliminarUltima();

                else
                {
                    buscado.anterior.siguiente = buscado.siguiente;
                    buscado.siguiente.anterior = buscado.anterior;
                }

                return true;
            }
            else
            return false;

        }

        public string Listar()
        {
            string Rutas = "";
            temporal = inicio;

            while (temporal != ultima)
            {
                Rutas += temporal.ToString() + Environment.NewLine;
                temporal = temporal.siguiente;
            }

            if (temporal != null)
                Rutas += temporal.ToString() + Environment.NewLine;

            return Rutas;
        }

        public string RecorridoFinal(string nuevaB, DateTime horaInicio, DateTime horaFin)
        {
            if (Buscar(nuevaB) == null)
                return "No se encontró la base";

            else
            {
                DateTime horaActual = horaInicio;
                string recorrido = "";
                temporal = buscado;

                while (temporal.siguiente != buscado)
                {
                    recorrido += temporal.Nombre.ToString() + "\t";
                    temporal = temporal.siguiente;
                }

                if (temporal != null)
                    recorrido += temporal.Nombre.ToString() + Environment.NewLine;

                temporal = buscado;

                while (horaActual <= horaFin)
                {
                    temporal = temporal.siguiente;
                    recorrido += horaActual.ToString("HH:mm") + "\t";
                    horaActual = horaActual.AddMinutes(temporal.Minutos);

                    if (temporal == buscado)
                        recorrido += Environment.NewLine;
                }

                return recorrido;
            }
        }

        public void Insertar(Base newBase, int posicion)
        {
            if (posicion == 1)
                AgregarInicio(newBase);

            else
            {
                temporal = inicio;

                for (int i = 1; i < posicion - 1; i++)
                {
                    temporal = temporal.siguiente;
                }

                newBase.siguiente = temporal.siguiente;
                newBase.anterior = temporal;
                temporal.siguiente.anterior = newBase;
                temporal.siguiente = newBase;
            }
        }
    }
}
