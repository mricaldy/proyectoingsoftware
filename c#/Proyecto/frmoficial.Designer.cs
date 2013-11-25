namespace Proyecto
{
    partial class frmoficial
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accidenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.vletra7 = new negocio.vletra(this.components);
            this.vletra8 = new negocio.vletra(this.components);
            this.vletra9 = new negocio.vletra(this.components);
            this.vletra10 = new negocio.vletra(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaOficialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transitoDataSet5 = new Proyecto.transitoDataSet5();
            this.vistaOficialTableAdapter = new Proyecto.transitoDataSet5TableAdapters.VistaOficialTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaOficialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(21, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Rango";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(18, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.conductorToolStripMenuItem,
            this.accidenteToolStripMenuItem,
            this.reporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 28);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // conductorToolStripMenuItem
            // 
            this.conductorToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.conductorToolStripMenuItem.Name = "conductorToolStripMenuItem";
            this.conductorToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.conductorToolStripMenuItem.Text = "Conductor";
            this.conductorToolStripMenuItem.Click += new System.EventHandler(this.conductorToolStripMenuItem_Click);
            // 
            // accidenteToolStripMenuItem
            // 
            this.accidenteToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.accidenteToolStripMenuItem.Name = "accidenteToolStripMenuItem";
            this.accidenteToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.accidenteToolStripMenuItem.Text = "Accidente";
            this.accidenteToolStripMenuItem.Click += new System.EventHandler(this.accidenteToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(11, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Direccion";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(85, 225);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 25;
            // 
            // vletra7
            // 
            this.vletra7.Location = new System.Drawing.Point(85, 99);
            this.vletra7.Name = "vletra7";
            this.vletra7.Size = new System.Drawing.Size(123, 20);
            this.vletra7.TabIndex = 26;
            // 
            // vletra8
            // 
            this.vletra8.Location = new System.Drawing.Point(85, 128);
            this.vletra8.Name = "vletra8";
            this.vletra8.Size = new System.Drawing.Size(123, 20);
            this.vletra8.TabIndex = 27;
            // 
            // vletra9
            // 
            this.vletra9.Location = new System.Drawing.Point(85, 159);
            this.vletra9.Name = "vletra9";
            this.vletra9.Size = new System.Drawing.Size(123, 20);
            this.vletra9.TabIndex = 28;
            // 
            // vletra10
            // 
            this.vletra10.Location = new System.Drawing.Point(85, 193);
            this.vletra10.Name = "vletra10";
            this.vletra10.Size = new System.Drawing.Size(123, 20);
            this.vletra10.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(57, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "CI";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 70);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 31;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreODataGridViewTextBoxColumn,
            this.direccionODataGridViewTextBoxColumn,
            this.rangoDataGridViewTextBoxColumn,
            this.apellidoODataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.ciDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaOficialBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(236, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 139);
            this.dataGridView1.TabIndex = 32;
            // 
            // nombreODataGridViewTextBoxColumn
            // 
            this.nombreODataGridViewTextBoxColumn.DataPropertyName = "nombreO";
            this.nombreODataGridViewTextBoxColumn.HeaderText = "nombreO";
            this.nombreODataGridViewTextBoxColumn.Name = "nombreODataGridViewTextBoxColumn";
            // 
            // direccionODataGridViewTextBoxColumn
            // 
            this.direccionODataGridViewTextBoxColumn.DataPropertyName = "direccionO";
            this.direccionODataGridViewTextBoxColumn.HeaderText = "direccionO";
            this.direccionODataGridViewTextBoxColumn.Name = "direccionODataGridViewTextBoxColumn";
            // 
            // rangoDataGridViewTextBoxColumn
            // 
            this.rangoDataGridViewTextBoxColumn.DataPropertyName = "rango";
            this.rangoDataGridViewTextBoxColumn.HeaderText = "rango";
            this.rangoDataGridViewTextBoxColumn.Name = "rangoDataGridViewTextBoxColumn";
            // 
            // apellidoODataGridViewTextBoxColumn
            // 
            this.apellidoODataGridViewTextBoxColumn.DataPropertyName = "apellidoO";
            this.apellidoODataGridViewTextBoxColumn.HeaderText = "apellidoO";
            this.apellidoODataGridViewTextBoxColumn.Name = "apellidoODataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // ciDataGridViewTextBoxColumn
            // 
            this.ciDataGridViewTextBoxColumn.DataPropertyName = "ci";
            this.ciDataGridViewTextBoxColumn.HeaderText = "ci";
            this.ciDataGridViewTextBoxColumn.Name = "ciDataGridViewTextBoxColumn";
            // 
            // vistaOficialBindingSource
            // 
            this.vistaOficialBindingSource.DataMember = "VistaOficial";
            this.vistaOficialBindingSource.DataSource = this.transitoDataSet5;
            // 
            // transitoDataSet5
            // 
            this.transitoDataSet5.DataSetName = "transitoDataSet5";
            this.transitoDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaOficialTableAdapter
            // 
            this.vistaOficialTableAdapter.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(104, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "OFICIALES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(279, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "LISTA DE OFICIALES";
            // 
            // frmoficial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 254);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vletra10);
            this.Controls.Add(this.vletra9);
            this.Controls.Add(this.vletra8);
            this.Controls.Add(this.vletra7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmoficial";
            this.Text = "frmoficial";
            this.Load += new System.EventHandler(this.frmoficial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaOficialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transitoDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.Label label4;
       //private negocio.vletra vletra1;
        //private negocio.vletra vletra2;
        //private negocio.vletra vletra3;
        //private negocio.vletra vletra4;
        private System.Windows.Forms.TextBox textBox4;
        private negocio.vletra vletra7;
        private negocio.vletra vletra8;
        private negocio.vletra vletra9;
        private negocio.vletra vletra10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private transitoDataSet5 transitoDataSet5;
        private System.Windows.Forms.BindingSource vistaOficialBindingSource;
        private transitoDataSet5TableAdapters.VistaOficialTableAdapter vistaOficialTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem conductorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accidenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}