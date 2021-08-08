using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Abogado
{
    public partial class Generador_de_reportes : Form
    {
        public Generador_de_reportes()
        {
            InitializeComponent();
        }

        private void Generador_de_reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Procesos2DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.ClientesTableAdapter.Fill(this.Procesos2DataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
