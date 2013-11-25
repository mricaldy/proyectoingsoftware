using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ValidarDatos;
namespace Proyecto
{
    public partial class frmoficial : Form
    {
        public frmoficial()
        {
            InitializeComponent();
        }
        negocio.Coficial objo = new negocio.Coficial();
        Validar obj = new Validar();
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (obj.IsNumeric(textBox3.Text) && obj.IsNumeric(textBox4.Text))
            {
                objo.guardar(vletra7.Text, vletra10.Text, vletra9.Text, vletra8.Text, int.Parse(textBox4.Text), int.Parse(textBox3.Text));
                MessageBox.Show("transaccion correcta");
            }
            else {
                MessageBox.Show("Datos incorectos en CI, Telefono(numero)");
            }
          
        }

        private void frmoficial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transitoDataSet5.VistaOficial' Puede moverla o quitarla según sea necesario.
            this.vistaOficialTableAdapter.Fill(this.transitoDataSet5.VistaOficial);

        }

        private void conductorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.ShowDialog();
            

        }

        private void accidenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAcidente obja = new FrmAcidente();
            obja.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmreporte objr = new Frmreporte();
            objr.Show();
        }
    }
}
