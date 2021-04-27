using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza) : base (nombre, raza)
        {
            edad = 0;
            esAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : this(nombre, raza)
        {
            Edad = edad;
            EsAlfa = esAlfa;
        }

        public int Edad {
            get
            {   
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public bool EsAlfa {
            get
            {
                return esAlfa;
            }
            set
            {
                esAlfa = value;
            }

        }

        /// <summary>
        /// Compara si dos perros son iguales
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>TRUE si son iguales FALSE sino lo son</returns>
        public override bool Equals(object obj)
        {
            if(obj != null && obj is Perro perro && Nombre == perro.Nombre && Edad == perro.Edad && Raza == perro.Raza)
            {
                return true;
            }
            return false;
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }
  
        /// <summary>
        /// Devuelve los datos del perro
        /// </summary>
        /// <returns>Datos del perro</returns>
        protected override string Ficha()
        {
            if (esAlfa)
            {
                return $"{base.DatosCompletos()}, es alfa de la manada, edad {edad}";
            }
            return $"{base.DatosCompletos()} edad {edad}";
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            return j1.Equals(j2);
        }

        public override string ToString()
        {
            return Ficha();
        }
    }
}
