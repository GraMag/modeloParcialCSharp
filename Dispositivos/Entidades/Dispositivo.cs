using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static ESistemaOperativo sistemaOP;

        static Dispositivo()
        {
            appInstaladas = new List<Aplicacion>();
            sistemaOP = ESistemaOperativo.ANDROID;
        }

        /// <summary>
        /// Muestra la informacion del dispositivo
        /// </summary>
        /// <returns>Sistema operativo y aplicaciones instaladas</returns>
        public static string InformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Sistema operativo {0}\n\n", sistemaOP);
            foreach(Aplicacion app in appInstaladas)
            {
                sb.AppendLine(app.InfoApp());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega la app a la lista si es compatible con el SO
        /// </summary>
        /// <param name="app"></param>
        /// <returns>TRUE si se puede instalar, FALSE si no es compatible</returns>
        public static bool InstalarApp(Aplicacion app)
        {
            return app.SistemaOperativo == sistemaOP && appInstaladas + app;
        }

    }
        public enum ESistemaOperativo
        {
            ANDROID,
            IOS
        }
}
