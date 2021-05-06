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
    public partial class Productos : Form
    {
        BackEnd.Archivos Archivos = new BackEnd.Archivos();
        public Productos()
        {
            InitializeComponent();
        }


        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNombreProducto.Text != "" && txtPrecioUnitario.Text != "")
                {
                    Archivos.agregarProducto(txtNombreProducto, txtPrecioUnitario);
                    Close();
                }
                else
                {
                    MessageBox.Show("Debes introducir la información necesaria");
                }
            }
            catch
            {
                MessageBox.Show("Intentalo nuevamente");
            }
        }
    }
}
