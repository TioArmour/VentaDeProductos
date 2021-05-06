using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackEnd
{
    public class Ventas
    {
        public string cantidad;
        public void getCantidad(ListBox cantidadProductos, TextBox txtCantidad)
        {
            cantidad = txtCantidad.Text;
            cantidadProductos.Items.Add(cantidad);
        }
       
        public void setVenta(ListBox pedidos, ListBox cantidadPedidos, ListBox precioPedido, ListBox totalBs, ListBox ventas, ListBox cantidadVenta)
        {
            foreach (var pedido in pedidos.Items)
            {
                ventas.Items.Add(pedido);
            }
            foreach (var cantidad in cantidadPedidos.Items)
            {
                cantidadVenta.Items.Add(cantidad);
            }
            string[] precios = new string[50];
            string[] cantidades = new string[50];
            int v = 0;
            foreach (string precio in precioPedido.Items)
            {
                precios[v] = precio;
                v++;
            }
            v = 0;
            foreach (string cantidad in cantidadPedidos.Items)
            {
                
                cantidades[v] = cantidad;
                v++;
            }
            for(int i=0; i<precioPedido.Items.Count; i++)
            {
                double total = double.Parse(precios[i]) * double.Parse(cantidades[i]);
                totalBs.Items.Add(Convert.ToString(total));
            }
            pedidos.Items.Clear();
            cantidadPedidos.Items.Clear();
            precioPedido.Items.Clear();
        }
        public void pagoVenta(ListBox totalPrecio,RadioButton tipoComprador, TextBox totalVenta, TextBox totalPago)
        {
            double pagoTotal = 0;
            foreach(string precioTotal in totalPrecio.Items)
            {
                pagoTotal += double.Parse(precioTotal);
            }
            totalVenta.Text = Convert.ToString(pagoTotal);
            
            if(tipoComprador.Text == "Empleado")
            {
                pagoTotal = pagoTotal - pagoTotal * 0.10;
                totalPago.Text = Convert.ToString(pagoTotal);
            }
            else
            {
                if (tipoComprador.Text == "Vendedor")
                {
                    pagoTotal = pagoTotal - pagoTotal * 0.05;
                    totalPago.Text = Convert.ToString(pagoTotal);
                }
                else
                {
                    if (tipoComprador.Text == "Minorista")
                    {
                        pagoTotal = pagoTotal - pagoTotal * 0.20;
                        totalPago.Text = Convert.ToString(pagoTotal);
                    }
                    else
                    {
                        if (tipoComprador.Text == "Mayorista")
                        {
                            pagoTotal = pagoTotal - pagoTotal * 0.30;
                            totalPago.Text = Convert.ToString(pagoTotal);
                        }
                    }
                }
            }
        }
        public void finalizarVenta(TextBox dineroRecibido, TextBox totalPago, TextBox cambio)
        {
            if (double.Parse(dineroRecibido.Text) >= Double.Parse(totalPago.Text))
            {
                cambio.Text = Convert.ToString(Math.Round((double.Parse(dineroRecibido.Text) - double.Parse(totalPago.Text)), 2));
            }
            else
            {
                MessageBox.Show("No tienes suficiente dinero.");
            }
        }
    }
}
