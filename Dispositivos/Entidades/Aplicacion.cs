using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Aplicacion
    {
        protected string nombre;
        protected ESistemaOperativo sistemaOP;
        protected int tamanioMb;

        /// <summary>
        /// Propiedad de lectura del sistema operativo
        /// </summary>
        public ESistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOP;
            }
        }

        /// <summary>
        /// Propiedad de lectura del tamanio de la app
        /// </summary>
        protected abstract int Tamanio { get; } 
        

        protected Aplicacion(string nombre, ESistemaOperativo sistOp, int tamanio)
        {
            this.nombre = nombre;
            sistemaOP = sistOp;
            tamanioMb = tamanio;
        }

        /// <summary>
        /// Muestra la informacion de la app
        /// </summary>
        /// <returns>Info de la app</returns>
        public virtual string InfoApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} \n", ToString());
            sb.AppendFormat("SO: {0} \n", SistemaOperativo);
            sb.AppendFormat("Tamanio {0} \n", Tamanio);

            return sb.ToString();
        }

        /// <summary>
        /// Sobreescribe el metodo ToString mostrando el nombre de la app
        /// </summary>
        /// <returns>Nombre de la app</returns>
        public override string ToString()
        {
            return nombre;
        }

        /// <summary>
        /// Devuelve la app de mayor tamaño
        /// </summary>
        /// <param name="listaApp"></param>
        public static implicit operator Aplicacion(List<Aplicacion> listaApp)
        { 
            int maxTam = int.MinValue;
            Aplicacion appMax = null;
            foreach(Aplicacion app in listaApp)
            {
                
                if(app.Tamanio > maxTam)
                {
                    maxTam = app.Tamanio;
                    appMax = app;
                }
            }
            return appMax;
        }

        /// <summary>
        /// Una lista es igual a una app si la lista contiene la app
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>TRUE si esta contenida. FALSE si no lo esta</returns>
        public static bool operator ==(List<Aplicacion> listaApp, Aplicacion app)
        {
            foreach(Aplicacion aplicacion in listaApp)
            {
                if(aplicacion.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Una lista es distinta de una app si la lista no contiene la app
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>FALSE si esta contenida. TRUE si no lo esta</returns>
        public static bool operator !=(List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// Añade una app a la lista
        /// </summary>
        /// <param name="listaApp"></param>
        /// <param name="app"></param>
        /// <returns>TRUE si se pudo añadir. False Si no se pudo</returns>
        public static bool operator +(List<Aplicacion> listaApp, Aplicacion app)
        {
            if(listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }
}
