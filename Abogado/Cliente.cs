using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abogado
{
   public class Cliente
   {
       #region propiedades
     

        private double  numeroprocesos;

        public double Numeroprocesos
        {
            get { return numeroprocesos; }
            set { numeroprocesos = value; }
        }
        private string demandante;

        public string Demandante
        {
            get { return demandante; }
            set { demandante = value; }
        }
        private string demandado;

        public string Demandado
        {
            get { return demandado; }
            set { demandado = value; }
        }
        private string observaciones;

        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        private string instancia;

        public string Instancia
        {
            get { return instancia; }
            set { instancia = value; }
        }
        private String fecha;

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private String Juzgado;

        public String Juzgado1
        {
            get { return Juzgado; }
            set { Juzgado = value; }
        }

        private Double prueba1;

        public Double Prueba1
        {
            get { return prueba1; }
            set { prueba1 = value; }
        }

        private int no_juzgado1;

        public int No_juzgado1
        {
            get { return no_juzgado1; }
            set { no_juzgado1 = value; }
        }

        private string telefono_Demandante;

        public string Telefono_Demandante
        {
            get { return telefono_Demandante; }
            set { telefono_Demandante = value; }
        }
        private string cedula_del_demandante;

        public string Cedula_del_demandante
        {
            get { return cedula_del_demandante; }
            set { cedula_del_demandante = value; }
        }
        private string nit_ced_demandado;

        public string Nit_ced_demandado
        {
            get { return nit_ced_demandado; }
            set { nit_ced_demandado = value; }
        }

        private string correo_demandante;

        public string Correo_demandante
        {
            get { return correo_demandante; }
            set { correo_demandante = value; }
        }

        private string correo_demandado;

        public string Correo_demandado
        {
            get { return correo_demandado; }
            set { correo_demandado = value; }
        }

        private String tipo;

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private string guarda;

        public string Guarda
        {
            get { return guarda; }
            set { guarda = value; }
        }
       #endregion

       #region constructor
        public Cliente() { }

        public Cliente(double pnumeroprocesos, string pdemandante, string pdemandado, string pobservaciones, string pinstancia, string pfecha, string pJuzgado, Double pprueba, int pno_juzgado, string ptelefono_Demandante, string pcedula_del_demandante, string pnit_ced_demandado, string ptipo, string pcorreodemandado, string pcorreodemandante, string pestado,string pguarda)
        {
         
            this.Numeroprocesos = pnumeroprocesos;
            this.Demandante = pdemandante;
            this.Demandado = pdemandado;
            this.Observaciones = pobservaciones;
            this.Instancia = pinstancia;
            this.Fecha = pfecha;
            this.Juzgado1 = pJuzgado;
            this.Prueba1 = pprueba;
            this.No_juzgado1 = pno_juzgado;
            this.Telefono_Demandante = ptelefono_Demandante;
            this.Cedula_del_demandante = pcedula_del_demandante;
            this.Nit_ced_demandado = pnit_ced_demandado;
            this.Tipo = ptipo;
            this.Correo_demandado = pcorreodemandado;
            this.Correo_demandante = pcorreodemandante;
            this.Estado = pestado;
            this.Guarda = pguarda;
       }

       #endregion

   }
}
