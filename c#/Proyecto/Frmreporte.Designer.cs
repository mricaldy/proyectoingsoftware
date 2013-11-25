namespace Proyecto
{
    partial class Frmreporte
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listaDeOficialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeConductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oficialConductorPorFechaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transitoDataSet6 = new Proyecto.transitoDataSet6();
            this.reporte1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte1TableAdapter = new Proyecto.transitoDataSet6TableAdapters.reporte1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeOficialesToolStripMenuItem,
            this.listaDeConductoresToolStripMenuItem,
            this.oficialConductorPorFechaToolStripMenuItem1,
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listaDeOficialesToolStripMenuItem
            // 
            this.listaDeOficialesToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.listaDeOficialesToolStripMenuItem.Name = "listaDeOficialesToolStripMenuItem";
            this.listaDeOficialesToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.listaDeOficialesToolStripMenuItem.Text = "Lista de Oficiales";
            this.listaDeOficialesToolStripMenuItem.Click += new System.EventHandler(this.listaDeOficialesToolStripMenuItem_Click);
            // 
            // listaDeConductoresToolStripMenuItem
            // 
            this.listaDeConductoresToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.listaDeConductoresToolStripMenuItem.Name = "listaDeConductoresToolStripMenuItem";
            this.listaDeConductoresToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.listaDeConductoresToolStripMenuItem.Text = "Lista de Conductores";
            this.listaDeConductoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeConductoresToolStripMenuItem_Click);
            // 
            // oficialConductorPorFechaToolStripMenuItem1
            // 
            this.oficialConductorPorFechaToolStripMenuItem1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.oficialConductorPorFechaToolStripMenuItem1.Name = "oficialConductorPorFechaToolStripMenuItem1";
            this.oficialConductorPorFechaToolStripMenuItem1.Size = new System.Drawing.Size(227, 24);
            this.oficialConductorPorFechaToolStripMenuItem1.Text = "Lista de Oficial atendio accidente";
            this.oficialConductorPorFechaToolStripMenuItem1.Click += new System.EventHandler(this.oficialConductorPorFechaToolStripMenuItem1_Click);
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // transitoDataSet6
            // 
            this.transitoDataSet6.DataSetName = "transitoDataSet6";
            this.transitoDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte1BindingSource
            // 
            this.reporte1BindingSource.DataMember = "reporte1";
            this.reporte1BindingSource.DataSource = this.transitoDataSet6;
            // 
            // reporte1TableAdapter
            // 
            this.reporte1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(609, 341);
            this.reportViewer1.TabIndex = 20;
            // 
            // Frmreporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 378);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmreporte";
            this.Text = "Frmreporte";
            this.Load += new System.EventHandler(this.Frmreporte_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.BindingSource reporte1BindingSource;
        private transitoDataSet6 transitoDataSet6;
        private transitoDataSet6TableAdapters.reporte1TableAdapter reporte1TableAdapter;
        private System.Windows.Forms.ToolStripMenuItem listaDeOficialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeConductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oficialConductorPorFechaToolStripMenuItem1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;



    }
}