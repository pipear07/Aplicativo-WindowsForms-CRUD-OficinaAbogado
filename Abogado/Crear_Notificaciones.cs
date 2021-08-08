using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading; //estas son nuevas
using System.Threading.Tasks; //bibliotecas
using System.Data.SqlClient;//Importacion para poder usar todos los comandos de sql

namespace Abogado
{
    public partial class Crear_Notificaciones : Form
    {
        public Crear_Notificaciones()
        {            InitializeComponent();        }
      
        #region Propiedades del formulario Notificaciones
        Thread Hilo;//hace una instanciacion en memoria en esa clase Thread que crea los hilos
        public Notificaciones ClienteSeleccionado3 { get; set; }
        public Notificaciones ClienteSeleccionado4 { get; set; }
        public Notificaciones ClienteSeleccionado5 { get; set; }
        public string fechade;
        public string almacena2;
        public string almacenacliente3;
        public string motivoalmacena;
        int contador = 3;
        bool beta = true;
        int num = 0;
        int cont = 0;
        public Notificaciones ClienteActual { get; set; }
        Boolean alpha = false;
        int omega = 9;
        int hor2 = DateTime.Now.TimeOfDay.Hours;
        int con = 0;
        string fechainicio;
        DateTime hore = (Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss tt")));
        int acu1 = 7, acu2 = 0;
        string beta2;
        #endregion

        /*
        #region Eventos del formulario Notificaciones
        private void btnActivarNotificaciones_Click(object sender, EventArgs e)
        {
            Notificaciones Notificaciones = new Notificaciones();
            Notificaciones.Persona_natural = txtnatural.Text;
            Notificaciones.Motivo = txtmotivo.Text;
            Notificaciones.Fecha2 = ((fecha2.Value.ToShortDateString())); 
            Notificaciones.Proceso2 = txtproces2.Text;
            Notificaciones.Fechadeinicio = (fecha3.Value.ToShortDateString());                      
        

            if (resultado > 0)
            {
                MessageBox.Show("Activado Correctamente", "Datos Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                activadordenoti();
            }else
            {
                MessageBox.Show("No se pudo Activar los datos", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Metodos del formulario Notificaciones
        public void activadordenoti()
        { //El metodo que activa las notificaciones
            Hilo = new Thread(Mover2);
            Hilo.Start();
        }
          */    
      

        void limpiar()//Metodo Limpieza
        {
            txtproces2.Clear();
            txtnatural.Clear();
            txtmotivo.Clear();
            fecha2.ResetText();
            fecha3.ResetText();
        }
 

        #region Ignorar
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) { }
        private void Crear_Notificaciones_Load(object sender, EventArgs e) { }

        #endregion

    }
}
