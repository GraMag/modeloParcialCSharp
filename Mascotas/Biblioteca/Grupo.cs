using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;

        static Grupo()
        {
            tipo = TipoManada.Unica;
        }

        private Grupo()
        {
            manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            Tipo = tipo;
        }

        public TipoManada Tipo 
        {
           set
            {
                tipo = value;
            }
        }

        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**{e.nombre} {tipo}**");
            sb.AppendLine("Integrantes");
            foreach (Mascota mascota in e.manada)
            {
                sb.AppendLine(mascota.ToString());
            }
            return sb.ToString();
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            if (e.manada.Contains(j))
            {
                return true;
            }
            return false;
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            e.manada.Add(j);
            return e;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            e.manada.Remove(j);
            return e;
        }
        public enum TipoManada
        {
            Unica,
            Mixta
        }


    }
}
