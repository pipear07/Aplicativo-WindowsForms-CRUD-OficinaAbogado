using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abogado
{
   public class Notificaciones
   {
       #region Propiedades
       private string persona_natural;

        public string Persona_natural
        {
            get { return persona_natural; }
            set { persona_natural = value; }
        }
        private string motivo;

        public string Motivo
        {
            get { return motivo; }
            set { motivo = value; }
        }
        private string fecha2;

        public string Fecha2
        {
            get { return fecha2; }
            set { fecha2 = value; }
        }
        private string proceso2;

        public string Proceso2
        {
            get { return proceso2; }
            set { proceso2 = value; }
        }

        private String fechadeinicio;

        public String Fechadeinicio
        {
            get { return fechadeinicio; }
            set { fechadeinicio = value; }
        }
       #endregion

       #region Contructor
        public Notificaciones() { }
       #endregion

        public Notificaciones(string pnatural, string pmotivo, string pfecha2, string pproceso2, string pfechadeinicio) {

            Persona_natural = pnatural;
            Motivo = pmotivo;
            Fecha2 = pfecha2;
            Proceso2 = pproceso2;
            Fechadeinicio = pfechadeinicio;
        
        }

   }
}
