namespace Abogado
{
    partial class Generador_de_reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Procesos2DataSet = new Abogado.Procesos2DataSet();
            this.ClientesTableAdapter = new Abogado.Procesos2DataSetTableAdapters.ClientesTableAdapter();
            this.Procesos2DataSet1 = new Abogado.Procesos2DataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procesos2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procesos2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Abogado.Informe3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1069, 613);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Clientes";
            this.ClientesBindingSource.DataSource = this.Procesos2DataSet;
            // 
            // Procesos2DataSet
            // 
            this.Procesos2DataSet.DataSetName = "Procesos2DataSet";
            this.Procesos2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesTableAdapter
            // 
            this.ClientesTableAdapter.ClearBeforeFill = true;
            // 
            // Procesos2DataSet1
            // 
            this.Procesos2DataSet1.DataSetName = "Procesos2DataSet1";
            this.Procesos2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Generador_de_reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 608);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Generador_de_reportes";
            this.Text = "Generador_de_reportes";
            this.Load += new System.EventHandler(this.Generador_de_reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procesos2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Procesos2DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private Procesos2DataSet Procesos2DataSet;
        private Procesos2DataSetTableAdapters.ClientesTableAdapter ClientesTableAdapter;
        private Procesos2DataSet1 Procesos2DataSet1;
    }
}