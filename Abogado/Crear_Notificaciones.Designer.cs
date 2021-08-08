namespace Abogado
{
    partial class Crear_Notificaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crear_Notificaciones));
            this.txtnatural = new System.Windows.Forms.TextBox();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnActivarNotificaciones = new System.Windows.Forms.Button();
            this.txtproces2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fecha3 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtnatural
            // 
            this.txtnatural.Location = new System.Drawing.Point(112, 69);
            this.txtnatural.Name = "txtnatural";
            this.txtnatural.Size = new System.Drawing.Size(248, 20);
            this.txtnatural.TabIndex = 0;
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(112, 153);
            this.txtmotivo.Multiline = true;
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(543, 29);
            this.txtmotivo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la persona:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cual es el motivo de notificarlo? (Sea breve)";
            // 
            // fecha2
            // 
            this.fecha2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecha2.Location = new System.Drawing.Point(455, 333);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(274, 22);
            this.fecha2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Hasta que lapso de tiempo?";
            // 
            // btnActivarNotificaciones
            // 
            this.btnActivarNotificaciones.Location = new System.Drawing.Point(314, 383);
            this.btnActivarNotificaciones.Name = "btnActivarNotificaciones";
            this.btnActivarNotificaciones.Size = new System.Drawing.Size(229, 32);
            this.btnActivarNotificaciones.TabIndex = 26;
            this.btnActivarNotificaciones.Text = "Activar";
            this.btnActivarNotificaciones.UseVisualStyleBackColor = true;
       
            // 
            // txtproces2
            // 
            this.txtproces2.Location = new System.Drawing.Point(112, 231);
            this.txtproces2.Name = "txtproces2";
            this.txtproces2.Size = new System.Drawing.Size(134, 20);
            this.txtproces2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Numero de Proceso";
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon2.Icon")));
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            this.notifyIcon2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // fecha3
            // 
            this.fecha3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fecha3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fecha3.Location = new System.Drawing.Point(112, 333);
            this.fecha3.Name = "fecha3";
            this.fecha3.Size = new System.Drawing.Size(274, 22);
            this.fecha3.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(455, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Que termine el...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Que empiece avisarme desde...";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(110, 358);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(592, 12);
            this.label28.TabIndex = 64;
            this.label28.Text = "Nota: Cuando la fecha de inicio sea igual a la fecha actual, empezara a notificar" +
    "lo, y cuando la fecha sea la misma para su fin, dejara de notificarlo";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(110, 254);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 12);
            this.label20.TabIndex = 88;
            this.label20.Text = "Ejemplo: 2016-0051";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(110, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 12);
            this.label7.TabIndex = 89;
            this.label7.Text = "Ejemplo: Pendiente de hablar con los testigos para interrogatorio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(110, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 12);
            this.label8.TabIndex = 90;
            this.label8.Text = "Ejemplo: Jhon Jaime Suarez";
            // 
            // Crear_Notificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(858, 427);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtproces2);
            this.Controls.Add(this.btnActivarNotificaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmotivo);
            this.Controls.Add(this.txtnatural);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crear_Notificaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creador de Notificaciones";
            this.Load += new System.EventHandler(this.Crear_Notificaciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnatural;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnActivarNotificaciones;
        private System.Windows.Forms.TextBox txtproces2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.DateTimePicker fecha3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}