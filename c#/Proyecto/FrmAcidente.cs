using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Proyecto
{
    public partial class FrmAcidente : Form
    {
        public FrmAcidente()
        {
            InitializeComponent();
        }

        private void FrmAcidente_Load(object sender, EventArgs e)
        {
            cargarcboficial();
            cargarcbconductor();
            
        }
        negocio.transitoEntities contexto = new negocio.transitoEntities();

        private void cargarcboficial()
        {
            var cboficial = from o in contexto.oficial
                            select o;
            comboBox2.DataSource = cboficial;
            comboBox2.DisplayMember = "nombreO";
            comboBox2.ValueMember = "idoficial";

        }
        private void cargarcbconductor()
        {
            var cbconductor = from o in contexto.conductor
                              select o;
            comboBox1.DataSource = cbconductor;
            comboBox1.DisplayMember = "nombre";
            comboBox1.ValueMember = "idconductor";
        }
        
        public bool cargarobjaccidente(ref negocio.accidente objacc)
        {
            bool ok = true;
            objacc.zona = vletra12.Text;
            objacc.fecha = DateTime.Parse(dateTimePicker1.Value.ToShortDateString());
            //falta estos datos.......................
            objacc.idconductor = int.Parse(comboBox1.SelectedValue.ToString());
            objacc.idofocial = int.Parse(comboBox2.SelectedValue.ToString());
            objacc.descripcion = vletra11.Text;
            return ok;
        }
        public string guardarAccidente(ref negocio.accidente objacc)
        {   contexto.AddToaccidente(objacc);
            try
            {
                if (contexto.SaveChanges() >= 0)
                {
                    return "Accidente Registrado";
                }
                else
                {
                    return "Accidente no registrado";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return "";
        }
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negocio.accidente objacc = new negocio.accidente();
            if (cargarobjaccidente(ref objacc))
            {
                MessageBox.Show(guardarAccidente(ref objacc));
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmoficial obj = new frmoficial();
            obj.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {}
       
        private void btnconductor_Click(object sender, EventArgs e)
        {}

        private void btnbuscaroficial_Click(object sender, EventArgs e)
        {}
    }
}
