using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Proyecto
{
    public partial class Frmreporte : Form
    {
        public Frmreporte()
        {
            InitializeComponent();
        }

        negocio.transitoEntities contex = new negocio.transitoEntities();
        
        private void Frmreporte_Load(object sender, EventArgs e)
        {
           // this.mostrar(0);
            this.reportViewer1.RefreshReport();
        }

        private void mostrar(Int32 nro) {
            ReportDataSource data = new ReportDataSource();
            switch (nro)
            {
                case 1:
                    var objcon = from c in contex.conductor
                                 select new {
                                 c.nombre,
                                 c.apellido,
                                 c.direccion,
                                 c.ci,
                                 c.telefono
                                 };
                   // data.Name = "DataSet1";
                   // data.Value = objcon;
                    this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\ingieneria de  software\Proyecto\Proyecto\Reportpconductor.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1",objcon));
                    this.reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.Refresh();
                    
                    break;
                case 2:
                       var objOficial = from i in contex.oficial
                                 select new {
                                    i.nombreO,
                                    i.direccionO,
                                    i.rango,
                                    i.apellidoO,
                                    i.telefono,
                                    i.ci
                                 };
                   // data.Name = "DataSet1";
                   // data.Value = objcon;
                    this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\ingieneria de  software\Proyecto\Proyecto\Reportpoficial.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", objOficial));
                    this.reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.Refresh();
                    break;

                case 3:
                    var objOC = from o in contex.oficial
                                join a in contex.accidente
                                on o.idoficial equals a.idofocial
                                join c in contex.conductor
                                on a.idconductor equals c.idconductor
                                     select new
                                     {
                                       o.nombreO,
                                       o.apellidoO,
                                       o.rango,
                                       c.nombre,
                                       c.apellido,
                                       c.telefono,
                                       a.zona,
                                       a.descripcion
                                     };
                    // data.Name = "DataSet1";
                    // data.Value = objcon;
                    this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                    this.reportViewer1.LocalReport.ReportPath = @"D:\ingieneria de  software\Proyecto\Proyecto\ReportOC.rdlc";
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", objOC));
                    this.reportViewer1.LocalReport.Refresh();
                    this.reportViewer1.Refresh();
                    break;
                default:
                    break;
            }

        }
        
        private void listaDeOficialesToolStripMenuItem_Click(object sender, EventArgs e)
        { this.mostrar(2); }
        private void listaDeConductoresToolStripMenuItem_Click(object sender, EventArgs e)
        { this.mostrar(1); }
        private void oficialConductorPorFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        { this.mostrar(3); }
        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmoficial ob = new frmoficial();
            ob.Show();
        }
        private void listaOficiaLConductorToolStripMenuItem_Click(object sender, EventArgs e)
        { }
        private void oficialConductorPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        { }


    }
}
