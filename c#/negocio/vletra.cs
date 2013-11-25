using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace negocio
{
    public partial class vletra : TextBox
    {
        public vletra()
        {
            InitializeComponent();
        }

        public vletra(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
          protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!(e.KeyData >= Keys.A && e.KeyData <= Keys.Z) &&
                !(e.KeyData == Keys.Space) && !(e.KeyData == Keys.Back))
            {
                e.SuppressKeyPress = true;
                return;
            }
            base.OnKeyDown(e);
        }
    }
}
