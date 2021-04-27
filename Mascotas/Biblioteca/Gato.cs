using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza)
            : base(nombre, raza) { }

        /// <summary>
        /// Compara 2 gatos
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE si son iguales FALSE si no lo son</returns>
        public override bool Equals(object obj)
        {
            
            if(obj != null && (obj is Gato gato) && Nombre == gato.Nombre && Raza == gato.Raza)
            {     
                return true; 
            }
            return false;
        }

        /// <summary>
        /// Datos del gato
        /// </summary>
        /// <returns></returns>
        protected override string Ficha()
        {
            return $"{base.DatosCompletos()}";
        }


        public static bool operator !=(Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// Compara 2 gatos
        /// </summary>
        /// <param name="obj1">un gato</param>
        /// <param name="obj2">otro gato</param>
        /// <returns></returns>
        public static bool operator ==(Gato obj1, Gato obj2)
        {
            return obj1.Equals(obj2);
        }

        public override string ToString()
        {
            return Ficha();
        }
    }
}
