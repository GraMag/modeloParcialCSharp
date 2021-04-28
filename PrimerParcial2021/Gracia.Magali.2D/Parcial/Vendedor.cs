using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor()
        {
            ventas = new List<Publicacion>();
        }
        public Vendedor(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Información del vendedor, sus ventas y la
        /// ganancia total
        /// </summary>
        /// <returns>Retorna la informacion del vendedor</returns>
        public string InformeDeVentas()
        {
            float ganancia = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nombre}");
            foreach (Publicacion publicacion in ventas)
            {
                sb.AppendLine("--------------------------------------");
                sb.AppendLine(publicacion.Informacion());
                ganancia += publicacion.Importe;
            }
            sb.AppendLine($"Ganancia Total: ${ganancia}");
            return sb.ToString();
        }

        /// <summary>
        /// agregará siempre y cuando haya stock suficiente para realizar una venta del producto, 
        /// agregando en ese caso la información de la venta a la lista y descontando Stock de
        /// la publicación.
        /// </summary>
        /// <param name="v"></param>
        /// <param name="p"></param>
        /// <returns>TRUE si hay stock y se agregó FALSE si no hay stock</returns>
        public static bool operator +(Vendedor v, Publicacion p)
        {
            if(p != null && p.Stock > 0)
            {
                v.ventas.Add(p);
                p.Stock -= 1;
                return true;
            }
            return false;
        }
    }
}
