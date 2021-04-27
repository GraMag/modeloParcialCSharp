using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Mascota
    {
        private string nombre;
        private string raza;
        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Raza
        {
            get
            {
                return this.raza;
            }
        }

        /// <summary>
        /// Devuelve el nombre y raza de la mascota
        /// </summary>
        /// <returns>Nombre y raza</returns>
        protected virtual string DatosCompletos()
        {
            return string.Format("{0} {1}", nombre, raza);
        }

        /// <summary>
        /// Ficha de la mascota
        /// </summary>
        /// <returns></returns>
        protected abstract string Ficha();
    
    }
}
