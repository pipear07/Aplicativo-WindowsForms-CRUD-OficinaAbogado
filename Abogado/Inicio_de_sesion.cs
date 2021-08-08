using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading; //estas son nuevas
using System.Threading.Tasks; //bibliotecas
using System.Windows.Forms;

namespace Abogado
{
    public partial class Inicio_de_sesion : Form
    {
        public Inicio_de_sesion()       {    InitializeComponent();  }
             
        #region Metodos del formulario
        string vender1=" ",vender2;
        Cliente cly = new Cliente();
        public void comandos() {
            if (check.Checked) //El boton de chequeo(el boton que se selecciona conun chulo) para verificar si fue seleccionado o no se hace con el nombre de la variable y la palabra check y si fue presionado es true de lo contrario es false
            {//ESTA FUNCION DE AQUI ABAJO, es para guardar datos en el programa, como por ejemplo: recordar logins, recordar configuracion de usuarios,etc.                 
                Abogado.Properties.Settings.Default.Caja1 = txtusuario.Text; //Para activarla y configurarla es sencillo, Vayase a la pestaña Proyecto/Porpiedades de abogado/En la pestaña Configuracion/creamos dos celdas que almacenaran los datos, 
                Abogado.Properties.Settings.Default.Caja2 = txtcontraseña.Text;//en este caso el usuario y contraseña, tiene que manipulase desde las configuraciones de todo el paquete, NO EL PROYECTO.
                Abogado.Properties.Settings.Default.Save();//El Save(guardado de las configuraciones) siempre debe ir de ultimo, para que el guarde todos los cambios de codigo en el programa mientras se ejecuta en segundo o primer plano
            }
            if (txtusuario.Text == "pipe" && txtcontraseña.Text == "1234")
            {
                this.Hide();
                Form1 programa = new Form1();
                /*
                if (check.Checked) //El boton de chequeo(el boton que se selecciona conun chulo) para verificar si fue seleccionado o no se hace con el nombre de la variable y la palabra check y si fue presionado es true de lo contrario es false
                {//ESTA FUNCION DE AQUI ABAJO, es para guardar datos en el programa, como por ejemplo: recordar logins, recordar configuracion de usuarios,etc.                 
                    Abogado.Properties.Settings.Default.Caja1 = txtusuario.Text; //Para activarla y configurarla es sencillo, Vayase a la pestaña Proyecto/Porpiedades de abogado/En la pestaña Configuracion/creamos dos celdas que almacenaran los datos, 
                    Abogado.Properties.Settings.Default.Caja2 = txtcontraseña.Text;//en este caso el usuario y contraseña, tiene que manipulase desde las configuraciones de todo el paquete, NO EL PROYECTO.
                    Abogado.Properties.Settings.Default.Save();//El Save(guardado de las configuraciones) siempre debe ir de ultimo, para que el guarde todos los cambios de codigo en el programa mientras se ejecuta en segundo o primer plano
                }
                 * */
                programa.ShowDialog();
            }
            else
            {
                Abogado.Properties.Settings.Default.Caja3 = txtusuario.Text;
              
                Abogado.Properties.Settings.Default.Caja4 = " " + Abogado.Properties.Settings.Default.Caja4 + ", " + Abogado.Properties.Settings.Default.Caja3;
                cly.Guarda = Abogado.Properties.Settings.Default.Caja4;
                Abogado.Properties.Settings.Default.Save();
                MessageBox.Show("Error en los datos");
                this.Hide();
                this.Close();
            }
        }
        #endregion

        #region Eventos del formulario
        Thread Hilo;//hace una instanciacion en memoria en esa clase Thread que crea los hilos
        private void Inicio_de_sesion_Load(object sender, EventArgs e)
        {
            Crear_Notificaciones noti = new Crear_Notificaciones();
            Form1 j = new Form1();
         //   Hilo = new Thread(j.Mover);
          //  Hilo.Start();
        //    noti.activadordenoti();
            txtusuario.Text = Abogado.Properties.Settings.Default.Caja1;//Le decimos que la celda de guardado del programa va almacenar lo que haya dentro del string
            txtcontraseña.Text = Abogado.Properties.Settings.Default.Caja2;//Ahora lo va a guardar en una celda del programa, para que el programa no la olvide(como una base de datos) y no en una variable.
        }

        private void btnEntrar_Click(object sender, EventArgs e) { comandos(); }

        private void btnCancelar_Click(object sender, EventArgs e)  {  this.Close();  } //Cierra el programa con el boton cancelar, pero sigue funcionando en segundo plano
 
        private void Cualquier_tecla(object sender, KeyEventArgs e)
        {    if (e.KeyData == Keys.Space || e.KeyData == Keys.Enter) { comandos(); }   } //Verifica si la caja de texto, en este caso la caja contraseña, es presionado la barra de espacio o el enter para seguir con el programa

        private void presionar_lasteclas(object sender, KeyEventArgs e)
        { if (e.KeyData == Keys.Space || e.KeyData == Keys.Enter)    { comandos(); }   } //Este tambien verifica si fue presionado la barra espaciadora o la tecla enter para seguir con el otro paso    
        #endregion


        #region Ignorar
        private void check_CheckedChanged(object sender, EventArgs e) {}            
        private void check_Click(object sender, EventArgs e) {}      
        private void Presionando_la_tecla(object sender, KeyPressEventArgs e) { }               
        #endregion

    }
}
