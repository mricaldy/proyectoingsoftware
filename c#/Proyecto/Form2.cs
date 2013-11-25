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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        negocio.Cconductor objc = new negocio.Cconductor();
        Validar obj = new Validar();
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (obj.IsNumeric(textBox4.Text) && obj.IsNumeric(textBox3.Text))
            {
                objc.guardar(vletra3.Text, vletra2.Text, vletra1.Text, int.Parse(textBox4.Text), int.Parse(textBox3.Text));
                MessageBox.Show("transaccion correcta");
            }
            else
            {
                MessageBox.Show("Datos incorectos en CI, Telefono(numero)");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'transitoDataSet4.VistaConductor' Puede moverla o quitarla según sea necesario.
            this.vistaConductorTableAdapter.Fill(this.transitoDataSet4.VistaConductor);
            // TODO: esta línea de código carga datos en la tabla 'transitoDataSet3.VistaOficial' Puede moverla o quitarla según sea necesario.
            this.vistaOficialTableAdapter.Fill(this.transitoDataSet3.VistaOficial);

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmoficial ob = new frmoficial();
            ob.Show();
        }
    }
}
