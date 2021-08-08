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
using System.Data.SqlClient;
using ObjetodeNegocios;
namespace Abogado
{
    public partial class Form1 : Form
    {
        public Form1()   { InitializeComponent(); }




        /*
        #region Hilos_metodos
        int omega = 9;
        int hor = DateTime.Now.TimeOfDay.Hours;
        int con = 0;
        DateTime hore = (Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss tt")));
        public ContextMenu contextMenu1 = new ContextMenu();

        public void Mover()
        {
            while (omega == 9)
            {
                if (Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss tt")) > hore)
                {
                    hore = DateTime.Now.AddHours(5);
                   // hor = hor + 5;                 
                    num = 0;
                    cont = 0;
                    if (DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortDateString()), Convert.ToDateTime(fechade)) > 0 && fechade != "N/A")
                    {//El datecomparador me sirve para cmparar datos de diferentes tipos, mas eficiente que la comparacion del generics
                        while (DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortDateString()), Convert.ToDateTime(fechade)) > 0 && fechade != "N/A" && beta == true)
                        {  //si la fecha del computador es mayor que la audiencia, entonces
                            cont = num++;
                            ClienteSeleccionado = Prueba.Avanza_al_siguiente_registro(cont);
                            fechade = Convert.ToString(ClienteSeleccionado.Fecha);
                            almacena2 = (ClienteSeleccionado.Numeroprocesos);
                            almacenacliente3 = (ClienteSeleccionado.Demandante);
                            if (DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToShortDateString()), Convert.ToDateTime(fechade)) < 0 && fechade != "N/A")
                            {//si la fecha del computador es menor que la audiencia, entonces siga mostrando...
                                
                                notifyIcon1.Visible = true;
                                notifyIcon1.ContextMenu = this.contextMenu1;
                                
                                contextMenu1.MenuItems.Add("&Open Application");
                         
                                     
                                contextMenu1.MenuItems.Add("S&uspend Application");
                                contextMenu1.MenuItems.Add("E&xit");
                                notifyIcon1.ContextMenu = contextMenu1;
                                notifyIcon1.Text = "Activo";
                                notifyIcon1.ShowBalloonTip(20000, "Informativo", "JOSÉ, No olvides que tienes audiencias pendientes del usuario " + almacenacliente3 + " el dia " + fechade + " del proceso " + almacena2,
                                    ToolTipIcon.Info);//este era el error
                            }
                            /*
                            if (fechade == "N/A")
                            {
                                MessageBox.Show("probando error");
                                notifyIcon1.Visible = true;
                                notifyIcon1.ShowBalloonTip(20000, "Informativo", "JOSÉ, por ahora no tienes asuntos pendientes o audiencias ",
                                    ToolTipIcon.Info);//este era el error
                                beta = false;
                            }
                          

                        }
                    }
                    else
                    {

                        ClienteSeleccionado2 = Prueba.Avanza_al_siguiente_registro(num);

                        fechade = Convert.ToString(ClienteSeleccionado.Fecha);

                        //    MessageBox.Show("no cambie el registro");
                        almacena2 = (ClienteSeleccionado.Numeroprocesos);
                        almacenacliente3 = (ClienteSeleccionado.Demandante);
                        notifyIcon1.Visible = true;
                        notifyIcon1.ShowBalloonTip(20000, "Informativo", "JOSÉ, No olvides que tienes audiencias pendientes del usuario " + almacenacliente3 + " el dia " + fechade + " del proceso " + almacena2,
                            ToolTipIcon.Info);//este era el error
                    }




/*

                    if (hor==22 || hor == 23 || hor == 24 || hor == 25 || hor == 26)
                    {
                        hor = 0;
                        hor = hor + 2;
                    }



                }
                else {

                   // hor = hor + 2;
                }
                



                Thread.Sleep(100); //detengo al hilo

            }

        }

        #endregion
                 
        #region Limpiar Pantalla
        void limpiar()
        {         
            txtnumeroproceso.Clear();
            txtjuzgado.Clear();
            txtprueba.Clear();
            no_juzgado.Clear();
            txtciudad.Clear();
            txtdemandante.Clear();
            txtcedula.Clear();
            txttelefono.Clear();
            txtdemandado.Clear();
            txtcedu_nit.Clear();
            txtobservaciones.Clear();
            txtinstancia.Clear();
            fecha.ResetText();
            fecha.Enabled = true;
            txtcorreo_demandante.Clear();
            txtcorreo_demandado.Clear();
            lblestado.Text = "N/A";
            No_audiencias.Text = "No hay audiencias";
            No_audiencias.Enabled = true;
            btnmodifica.Enabled=true;
        }
        #endregion


        #region Timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblcontar.Text = Convert.ToString((200 - txtobservaciones.Text.Length));
            lblcuenta2.Text = Convert.ToString((60 - txtdemandante.Text.Length));
            lblcuenta3.Text = Convert.ToString((90 - txtdemandado.Text.Length));
            lblcontar4.Text = Convert.ToString((48 - txtinstancia.Text.Length));
        }
#endregion 
        
        #region Controles del Menu de Barras
        private void cierraToolStripMenuItem_Click(object sender, EventArgs e) { this.Close(); }

     

        private void generarReporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Generador_de_Reporte reportes = new Generador_de_Reporte();
            reportes.ShowDialog();
        }

        private void notificacionesToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void crearTuNotificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear_Notificaciones notifi = new Crear_Notificaciones();
            notifi.ShowDialog();
        }




        #region Colores del programa
        private void grisToolStripMenuItem_Click(object sender, EventArgs e) { this.BackColor = Color.Gray; }    //color gris    
        private void negroToolStripMenuItem1_Click(object sender, EventArgs e) { this.BackColor = Color.Sienna; }  // color negro      
        private void nieveToolStripMenuItem_Click(object sender, EventArgs e) { this.BackColor = Color.Snow; }       // color nieve
        private void cianToolStripMenuItem_Click(object sender, EventArgs e) { this.BackColor = Color.Cyan; }        // color chicle
        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e) { this.BackColor = Color.ForestGreen; }  //color verde      
        private void cafeToolStripMenuItem_Click(object sender, EventArgs e) { this.BackColor = Color.MidnightBlue; }    //color cafe
        #endregion

         */
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) { }
       


        private void quienesInteronAccederSinPermisoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente de = new Cliente();
            MessageBox.Show("Estos usuarios intentaron acceder sin permiso :" + Abogado.Properties.Settings.Default.Caja4);
        }

        private void limpiarHistorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abogado.Properties.Settings.Default.Caja4 = null;
            Abogado.Properties.Settings.Default.Save();
            MessageBox.Show("El historial se limpio con exito");
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Instancia la clase Personas
            Usuarios objUsuarios = new Usuarios();
            EstadoCivil objEstadoCivil = new EstadoCivil();
         //   Paciente objPaciente = new Paciente();
            //Carga la Grilla dgPPersonas desde el metodo Seleccionar de la clase personas, que a su vez consume el procedimiento
            //almacenado proPersonasConsultar1 en mi caso
      
            txtmotivoconsulta.DataSource = objUsuarios.Seleccionar();
            //Actualiza la Grilla
            txtmotivoconsulta.Refresh();
            //Se debe relacionar el numero de columnas que retorne el procedimiento almacenado dando titulo a los encabezados
            //de cada columna.

            txtmotivoconsulta.Columns[0].Visible = false;
            txtmotivoconsulta.Columns[1].HeaderText = "Datos del Contacto";
            txtmotivoconsulta.Columns[2].HeaderText = "XXXX";
            txtmotivoconsulta.Columns[3].HeaderText = "ZZZZZZ";
            txtmotivoconsulta.Columns[4].HeaderText = "Tipo de Contacto";
            txtmotivoconsulta.Columns[5].HeaderText = "Tipo de Usuario";
            txtmotivoconsulta.Columns[6].HeaderText = "Estado Civil";
            txtmotivoconsulta.Columns[7].HeaderText = "Nombre Demandante";
            txtmotivoconsulta.Columns[8].HeaderText = "Numero de Identificacion";
            txtmotivoconsulta.Columns[9].HeaderText = "Direccion";

            //LLAMAR AL METODO DE SELECCION
            comboestadocivil.DataSource = objEstadoCivil.Seleccionar();

      //      cboTiposIdentificacion.DataSource = objTiposIdentificacion.Seleccionar();
         //   combo_estado.DataSource = objEstadoCivil.Seleccionar();
         //   combo_tiposangre.DataSource = objSangre.Seleccionar();
            //indica al combo cual columna debe mostrar al usuario

            //SELECCIONE LA COLUMNA A MOSTRAR
             comboestadocivil.DisplayMember ="Estado Civil";
        

      //      combo_estado.DisplayMember = "Estado Civil";

            //indica al combo cual columna debe asignar como id
             comboestadocivil.ValueMember = "IdEstadoCivil";
            
        //    combo_estado.ValueMember = "IdEstadoCivil";

          //  combo_tiposangre.DisplayMember = "Nombre";
           // combo_tiposangre.ValueMember = "IdGrupoSanguineo";

        }

        private void boton_guardar_Click(object sender, EventArgs e)
        {
            //Instancia la clase personas en el objeto ObjePersonas
            Usuarios objUsuarios = new Usuarios();
           // GrupoSanguineo objSangre = new GrupoSanguineo();
           // Paciente objPaciente = new Paciente();
            //Envia los valores seleccionados en los combos y cajas de texto a la clase personas
            objUsuarios.IdContacto = Convert.ToInt32(cboTiposIdentificacion.SelectedValue);
          //  objUsuarios.IdEstadoCivil = Convert.ToInt16(combo_estado.SelectedValue);
            objUsuarios.NumeroIdentificacion1 = txtNumeroIdentificacion.Text;
            objUsuarios.NombreP1 = txtPNombre.Text;
            objUsuarios.NombreS1 = txtSNombre.Text;
            objUsuarios.ApellidoA1 = txtPApellido.Text;
            objUsuarios.ApellidoS1 = txtSApellido.Text;
            objUsuarios.Direccion1 = txtDireccion.Text;
            objUsuarios.NombreEmpresa1 = txtNombreEmpresa.Text;
         
            objUsuarios.Insertar();
            //GRUPO SANGUINEO
          
      //      objPaciente.IdPersona = objPersonas.IdPersona;
        //    objPaciente.IdGrupoSanguineo = Convert.ToInt16(combo_tiposangre.SelectedValue);
          //  objPaciente.MotivoConsulta = motivos.Text;
           // objPaciente.IdEnfermedades = 5;
            //llama al metodo insertar que a su vez hace uso del procedimiento almacenado proPersonasInsertar

            //objPaciente.Insertar();
            //if (objPersonas.Insertar())
            // {
            //   MessageBox.Show("fue guardado");
            //}
            txtmotivoconsulta.Refresh();
            txtmotivoconsulta.DataSource = objUsuarios.Seleccionar();
        }

        private void txtmotivoconsulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // se instancia la clase personas en el objeto objPersonas
            Usuarios objUsuarios = new Usuarios();
          //  Paciente objPaciente = new Paciente();
            //si se pulsa e el header el RowIndex sera menos a menos
            if (!(e.RowIndex > -1))
            {
                return;
            }
            //obtienes la fila seleccionada
            DataGridViewRow row = txtmotivoconsulta.Rows[e.RowIndex];
            objUsuarios.IdUsuario = Convert.ToInt32(row.Cells[0].Value.ToString());
         //   objPaciente.IdPersona = Convert.ToInt32(row.Cells[0].Value.ToString());

            // hace uso del metodo Seleccionar IdPersona, que a su vez hace uso del procedimiento almacenado PersonasSeleccionarId
            objUsuarios.SeleccionarId(); //RECUERDE QUE TOCA MODIFICAR EL PROCEDIMIENTO ALMACENADO PROCONSULTARIDPACIENTE
          //  objPaciente.SeleccionarId();
            //carga en el label lblIdPersona el Id de la persona seleccionada, para usarlo mas adelante, este label debe aparecer invisible
            //en sus propiedades para evitar enseñarlo al usuario
            lblUsuario.Text = objUsuarios.IdUsuario.ToString();
            //carga cada una de las cajas de texto con los datos que retorna el procedimiento almacenado

         //   TipoDocumento ti = new TipoDocumento();
            //       ti.IdTipoDocumento = Convert.ToInt32(row.Cells[0].Value.ToString());

      //      combo_estado.SelectedValue = objPersonas.IdEstadoCivil;
            comboestadocivil.SelectedValue = objUsuarios.IdEstadoCivil;
            txtNumeroIdentificacion.Text = objUsuarios.NumeroIdentificacion1;
            txtPNombre.Text = objUsuarios.NombreP1;
           txtSNombre.Text = objUsuarios.NombreS1;
       txtPApellido.Text = objUsuarios.ApellidoA1;
           txtSApellido.Text = objUsuarios.ApellidoS1;
           txtDireccion.Text = objUsuarios.Direccion1;
    txtNombreEmpresa.Text = objUsuarios.NombreEmpresa1;
            txtmotivoconsulta.Refresh();
        }
             
    }
}