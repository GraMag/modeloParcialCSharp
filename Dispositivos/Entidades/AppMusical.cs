using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {
        private List<string> listaCanciones;
        
        /// <summary>
        /// Propiedad de lectura del tamaño de la app.
        /// Al tamaño inicial de la app se le suman 2Mb por cancion contenida en la lista
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                return tamanioMb + listaCanciones.Count * 2;
            }
        }

        public AppMusical(string nombre, ESistemaOperativo sistOp, int tamanioInicial)
            :base (nombre, sistOp, tamanioInicial)
        {
            listaCanciones = new List<string>();
        }

        public AppMusical(string nombre, ESistemaOperativo sistOp, int tamanioInicial, List<string> lista)
            : this (nombre, sistOp, tamanioInicial)
        {
            listaCanciones = lista;
        }

        /// <summary>
        /// Muestra la informacion de la app y las canciones
        /// </summary>
        /// <returns></returns>
        public override string InfoApp()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(base.InfoApp());
            foreach(string cancion in listaCanciones)
            {
                sb.AppendLine(cancion);
            }
            return sb.ToString();
        }
    }
}
