using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;
        }
        public Publicacion(string nombre, int stock)
            : this(nombre)
        {
            this.stock = stock;
        }

        public Publicacion(string nombre, int stock, float importe)
            : this(nombre, stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor
        {
            get;
        }

        /// <summary>
        /// Retorna True siempre y cuando haya stock y el importe sea mayor a 0
        /// </summary>
        public virtual bool HayStock 
        {
            get 
            {
                if(stock > 0 && importe > 0)
                {
                    return true;
                }
                return false;
            }
        }

        
        public float Importe
        {
            get
            {
                return importe;
            }
        }

        /// <summary>
        /// Stock solo asignará si lo recibido es mayor a 0
        /// </summary>
        public int Stock
        {
            get
            {
                return stock;
            }
         
            set
            {
                if(value >= 0)
                {
                    this.stock = value;
                }
            }
        }

        /// <summary>
        /// Retorna el nombre
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return nombre;
        }

        /// <summary>
        /// Datos de la Publicacion
        /// </summary>
        /// <returns>Retorna los datos de la Publicacion</returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre {ToString()}");
            sb.AppendLine($"Stock: {Stock}");
            if (EsColor)
            {
                sb.AppendLine($"Color: SI");
            } else {
                sb.AppendLine($"Color: NO");
            }
            sb.AppendLine($"Valor: ${Importe}");
            return sb.ToString();
        }
    }
}
