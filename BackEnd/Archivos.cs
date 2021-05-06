using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BackEnd
{
    public class Archivos
    {
        public void getProductos(ListBox listaProductos)
        {
            string ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\VentaDeProductos\Archivos\Productos.txt";
            string producto;
            try
            {
                StreamReader sr = new StreamReader(ruta);
                producto = sr.ReadLine();
                while(producto != null)
                {
                    listaProductos.Items.Add(producto);
                    producto = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("No hemos podido encontrar el archivo donde estan almacenados los productos.");
            }
        }
        public void getPrecioUnitario(ListBox listaPrecios)
        {
            string ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\VentaDeProductos\Archivos\Precios.txt";
            string precio;
            try
            {
                StreamReader sr = new StreamReader(ruta);
                precio = sr.ReadLine();
                while (precio != null)
                {
                    listaPrecios.Items.Add(precio);
                    precio = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("No hemos podido encontrar el archivo donde estan almacenados los precios de los productos" );
            }
        }

        public void agregarProducto(TextBox nombreProducto, TextBox precioUnitario)
        {
            string rutaProducto = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\VentaDeProductos\Archivos\Productos.txt";
            string rutaPrecios = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\VentaDeProductos\Archivos\Precios.txt";
            try
            {
                if(nombreProducto.Text != "" && precioUnitario.Text != "")
                {

                    StreamWriter swP = new StreamWriter(rutaProducto,true);
                    swP.WriteLine(nombreProducto.Text);
                    swP.Close();
                    StreamWriter swPr = new StreamWriter(rutaPrecios,true);
                    swPr.WriteLine(precioUnitario.Text);
                    swPr.Close();
                }
                else
                {
                    MessageBox.Show("Debes introducir toda la información.");
                }
            }
            catch
            {
                MessageBox.Show("Ocurrio un error al guardar el producto");
            }
        }
        public void registarVenta(ListBox ventas, ListBox cantidades, ListBox total, TextBox precioTotal, RadioButton tipoCliente, TextBox totalPago, DateTimePicker fecha)
        {
            string ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\VentaDeProductos\Archivos\Ventas.txt";
            try
            {

            string[] listaVentas = new string[50];
            string[] listaCantidades = new string[50];
            string[] listaPrecios = new string[50];
            int v = 0;
            foreach(string producto in ventas.Items)
            {
                listaVentas[v] = producto;
                v++;
            }
            v = 0;
            foreach (string cantidad in cantidades.Items)
            {
                listaCantidades[v] = cantidad;
                v++;
            }
            v = 0;
            foreach (string precio in total.Items)
            {
                listaPrecios[v] = precio;
                v++;
            }
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.WriteLine($"Fecha: {fecha.Text}");
            sw.WriteLine($"Productos              Cantidad         Precio");
            for (int i=0; i < ventas.Items.Count; i++)
            {
                string linea = $"{listaVentas[i]}              {listaCantidades[i]}         {listaPrecios[i]}";
                sw.WriteLine(linea);
            }
            sw.WriteLine($"Tipo de Cliente: {tipoCliente.Text}");
            sw.WriteLine($"Precio Total: {precioTotal.Text}");
            sw.WriteLine($"Total a Pagar: {totalPago.Text}");
            sw.WriteLine();
            sw.Close();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error en el registro de la venta");
            }
        }
    }
}
