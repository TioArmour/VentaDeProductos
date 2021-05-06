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
    public partial class ProcesoVenta : Form
    {
        BackEnd.Archivos Archivos = new BackEnd.Archivos();
        BackEnd.Ventas Ventas = new BackEnd.Ventas();
        public ProcesoVenta()
        {
            InitializeComponent();
        }

        private void ProcesoVenta_Load(object sender, EventArgs e)
        {
            gbFecha.Enabled = false;
            txtTotalPago.Enabled = false;
            txtCambio.Enabled = false;
            Archivos.getProductos(lstProductos);
            Archivos.getPrecioUnitario(lstPrecioUnitario);
            
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            try
            {
                Form Productos = new Productos();
                Productos.ShowDialog();
                lstPrecioUnitario.Items.Clear();
                lstProductos.Items.Clear();
                Archivos.getProductos(lstProductos);
                Archivos.getPrecioUnitario(lstPrecioUnitario);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. Intentalo Nuevamente");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                lstPrecioUnitario.SelectedIndex = lstProductos.SelectedIndex;
                CantidadProductos cantidadProductos = new CantidadProductos();
                cantidadProductos.ShowDialog();
                Ventas.getCantidad(lstCantidadPedidos, cantidadProductos.txtCantidadProducto);
                lstPrecioPedido.Items.Add(lstPrecioUnitario.SelectedItem);
                lstPedidos.Items.Add(lstProductos.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void btnProcesarPedido_Click(object sender, EventArgs e)
        {
            try
            {   
                Ventas.setVenta(lstPedidos, lstCantidadPedidos, lstPrecioPedido, lstTotalBs, lstVentas, lstCantidadVenta);
                if (rbEmpleado.Checked)
                {
                    Ventas.pagoVenta(lstTotalBs, rbEmpleado, txtTotal, txtTotalPago);
                }
                else
                {
                    if (rbVendedor.Checked)
                    {
                        Ventas.pagoVenta(lstTotalBs, rbVendedor, txtTotal, txtTotalPago);
                    }
                    else
                    {
                        if (rbMinorista.Checked)
                        {
                            Ventas.pagoVenta(lstTotalBs, rbMinorista, txtTotal, txtTotalPago);
                        }
                        else
                        {
                            if (rbMayorista.Checked)
                            {
                                Ventas.pagoVenta(lstTotalBs, rbMayorista, txtTotal, txtTotalPago);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. Intentalo Nuevamente");
            }
        }

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                Ventas.finalizarVenta(txtDineroRecibido, txtTotalPago, txtCambio);
                if (rbEmpleado.Checked)
                {
                    Archivos.registarVenta(lstVentas, lstCantidadVenta, lstTotalBs, txtTotal, rbEmpleado, txtTotalPago, SeleccionFecha);
                }
                else
                {
                    if (rbVendedor.Checked)
                    {
                        Archivos.registarVenta(lstVentas, lstCantidadVenta, lstTotalBs, txtTotal, rbVendedor, txtTotalPago, SeleccionFecha);
                    }
                    else
                    {
                        if (rbMinorista.Checked)
                        {
                            Archivos.registarVenta(lstVentas, lstCantidadVenta, lstTotalBs, txtTotal, rbMinorista, txtTotalPago, SeleccionFecha);
                        }
                        else
                        {
                            if (rbMayorista.Checked)
                            {
                                Archivos.registarVenta(lstVentas, lstCantidadVenta, lstTotalBs, txtTotal, rbMayorista, txtTotalPago, SeleccionFecha);
                            }
                        }
                    }
                }
                lstCantidadVenta.Items.Clear();
                lstTotalBs.Items.Clear();
                lstVentas.Items.Clear();
                }
            catch
            {
                MessageBox.Show("Ha ocurrido un error.Intentalo Nuevamente");
            }
        }
    }
    
}