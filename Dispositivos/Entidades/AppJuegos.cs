using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppJuegos : Aplicacion
    {
        /// <summary>
        /// Propuedad de lectura del tamanio de la app
        /// </summary>
        protected override int Tamanio
        {
            get
            {
                return tamanioMb;
            }
        }

        public AppJuegos(string nombre, ESistemaOperativo sistOp, int tamanio)
            : base (nombre, sistOp, tamanio) { }

    }
}
