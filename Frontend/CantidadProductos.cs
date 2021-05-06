using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class CantidadProductos : Form
    {
        BackEnd.Ventas Ventas = new BackEnd.Ventas();
        public CantidadProductos()
        {
            InitializeComponent();
        }

        private void btnHecho_Click(object sender, EventArgs e)
        {
            Ventas.cantidad = txtCantidadProducto.Text;
            Close();
        }
    }
}
