using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Biografia : Publicacion
    {
        public Biografia(string nombre)
            : base(nombre) { }

        public Biografia(string nombre, int stock)
            : base(nombre, stock) { }

        public Biografia(string nombre, int stock, float valor)
            : base(nombre, stock, valor) { }

        public override bool HayStock
        {
            get
            { 
                if(Stock > 0)
                {
                    return true;
                }
                return false;
            }
        }
        
        protected override bool EsColor
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Devuelve el nombre de la Biografia
        /// </summary>
        /// <param name="nombre"></param>
        public static explicit operator Biografia(string nombre)
        {
            return new Biografia(nombre);
        }
    }
        
}
