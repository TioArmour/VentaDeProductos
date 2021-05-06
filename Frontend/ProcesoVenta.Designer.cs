
namespace Frontend
{
    partial class ProcesoVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rbMinorista = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.RadioButton();
            this.rbMayorista = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.SeleccionFecha = new System.Windows.Forms.DateTimePicker();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.lstPrecioUnitario = new System.Windows.Forms.ListBox();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.gbPedidos = new System.Windows.Forms.GroupBox();
            this.lblPU = new System.Windows.Forms.Label();
            this.lstPrecioPedido = new System.Windows.Forms.ListBox();
            this.btnProcesarPedido = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lstCantidadPedidos = new System.Windows.Forms.ListBox();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.gbVentas = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalBs = new System.Windows.Forms.Label();
            this.lstCantidadVenta = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtDineroRecibido = new System.Windows.Forms.TextBox();
            this.lblDineroRecibido = new System.Windows.Forms.Label();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.lstTotalBs = new System.Windows.Forms.ListBox();
            this.lstVentas = new System.Windows.Forms.ListBox();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.gbCliente.SuspendLayout();
            this.gbFecha.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.gbPedidos.SuspendLayout();
            this.gbVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.rbMinorista);
            this.gbCliente.Controls.Add(this.rbVendedor);
            this.gbCliente.Controls.Add(this.rbMayorista);
            this.gbCliente.Controls.Add(this.rbEmpleado);
            this.gbCliente.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(774, 60);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Tipo de Cliente";
            // 
            // rbMinorista
            // 
            this.rbMinorista.AutoSize = true;
            this.rbMinorista.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMinorista.Location = new System.Drawing.Point(597, 27);
            this.rbMinorista.Name = "rbMinorista";
            this.rbMinorista.Size = new System.Drawing.Size(105, 25);
            this.rbMinorista.TabIndex = 3;
            this.rbMinorista.TabStop = true;
            this.rbMinorista.Text = "Minorista";
            this.rbMinorista.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.AutoSize = true;
            this.rbVendedor.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVendedor.Location = new System.Drawing.Point(226, 27);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(110, 25);
            this.rbVendedor.TabIndex = 1;
            this.rbVendedor.TabStop = true;
            this.rbVendedor.Text = "Vendedor";
            this.rbVendedor.UseVisualStyleBackColor = true;
            // 
            // rbMayorista
            // 
            this.rbMayorista.AutoSize = true;
            this.rbMayorista.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMayorista.Location = new System.Drawing.Point(415, 27);
            this.rbMayorista.Name = "rbMayorista";
            this.rbMayorista.Size = new System.Drawing.Size(111, 25);
            this.rbMayorista.TabIndex = 2;
            this.rbMayorista.TabStop = true;
            this.rbMayorista.Text = "Mayorista";
            this.rbMayorista.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmpleado.Location = new System.Drawing.Point(51, 27);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(112, 25);
            this.rbEmpleado.TabIndex = 0;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.SeleccionFecha);
            this.gbFecha.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFecha.Location = new System.Drawing.Point(792, 12);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(387, 60);
            this.gbFecha.TabIndex = 1;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Fecha";
            // 
            // SeleccionFecha
            // 
            this.SeleccionFecha.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeleccionFecha.Location = new System.Drawing.Point(13, 24);
            this.SeleccionFecha.Name = "SeleccionFecha";
            this.SeleccionFecha.Size = new System.Drawing.Size(365, 27);
            this.SeleccionFecha.TabIndex = 0;
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.lstPrecioUnitario);
            this.gbProductos.Controls.Add(this.btnAgregarProductos);
            this.gbProductos.Controls.Add(this.lblPrecioUnitario);
            this.gbProductos.Controls.Add(this.lstProductos);
            this.gbProductos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProductos.Location = new System.Drawing.Point(12, 79);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(573, 285);
            this.gbProductos.TabIndex = 2;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // lstPrecioUnitario
            // 
            this.lstPrecioUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPrecioUnitario.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrecioUnitario.FormattingEnabled = true;
            this.lstPrecioUnitario.ItemHeight = 21;
            this.lstPrecioUnitario.Location = new System.Drawing.Point(455, 45);
            this.lstPrecioUnitario.Name = "lstPrecioUnitario";
            this.lstPrecioUnitario.Size = new System.Drawing.Size(110, 193);
            this.lstPrecioUnitario.TabIndex = 7;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProductos.Location = new System.Drawing.Point(8, 244);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(443, 33);
            this.btnAgregarProductos.TabIndex = 6;
            this.btnAgregarProductos.Text = "Agregar Nuevos Productos";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(457, 19);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(116, 21);
            this.lblPrecioUnitario.TabIndex = 5;
            this.lblPrecioUnitario.Text = "Precio Unit.";
            // 
            // lstProductos
            // 
            this.lstProductos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 21;
            this.lstProductos.Location = new System.Drawing.Point(8, 45);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(443, 193);
            this.lstProductos.TabIndex = 0;
            this.lstProductos.SelectedIndexChanged += new System.EventHandler(this.lstProductos_SelectedIndexChanged);
            // 
            // gbPedidos
            // 
            this.gbPedidos.Controls.Add(this.lblPU);
            this.gbPedidos.Controls.Add(this.lstPrecioPedido);
            this.gbPedidos.Controls.Add(this.btnProcesarPedido);
            this.gbPedidos.Controls.Add(this.lblCantidad);
            this.gbPedidos.Controls.Add(this.lstCantidadPedidos);
            this.gbPedidos.Controls.Add(this.lstPedidos);
            this.gbPedidos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPedidos.Location = new System.Drawing.Point(597, 79);
            this.gbPedidos.Name = "gbPedidos";
            this.gbPedidos.Size = new System.Drawing.Size(582, 285);
            this.gbPedidos.TabIndex = 3;
            this.gbPedidos.TabStop = false;
            this.gbPedidos.Text = "Pedidos";
            // 
            // lblPU
            // 
            this.lblPU.AutoSize = true;
            this.lblPU.Location = new System.Drawing.Point(460, 21);
            this.lblPU.Name = "lblPU";
            this.lblPU.Size = new System.Drawing.Size(40, 21);
            this.lblPU.TabIndex = 9;
            this.lblPU.Text = "P/U";
            // 
            // lstPrecioPedido
            // 
            this.lstPrecioPedido.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrecioPedido.FormattingEnabled = true;
            this.lstPrecioPedido.ItemHeight = 21;
            this.lstPrecioPedido.Location = new System.Drawing.Point(457, 45);
            this.lstPrecioPedido.Name = "lstPrecioPedido";
            this.lstPrecioPedido.Size = new System.Drawing.Size(55, 193);
            this.lstPrecioPedido.TabIndex = 8;
            // 
            // btnProcesarPedido
            // 
            this.btnProcesarPedido.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesarPedido.Location = new System.Drawing.Point(7, 244);
            this.btnProcesarPedido.Name = "btnProcesarPedido";
            this.btnProcesarPedido.Size = new System.Drawing.Size(443, 33);
            this.btnProcesarPedido.TabIndex = 7;
            this.btnProcesarPedido.Text = "Procesar Pedido";
            this.btnProcesarPedido.UseVisualStyleBackColor = true;
            this.btnProcesarPedido.Click += new System.EventHandler(this.btnProcesarPedido_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(514, 21);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(59, 21);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cant.";
            // 
            // lstCantidadPedidos
            // 
            this.lstCantidadPedidos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCantidadPedidos.FormattingEnabled = true;
            this.lstCantidadPedidos.ItemHeight = 21;
            this.lstCantidadPedidos.Location = new System.Drawing.Point(518, 45);
            this.lstCantidadPedidos.Name = "lstCantidadPedidos";
            this.lstCantidadPedidos.Size = new System.Drawing.Size(55, 193);
            this.lstCantidadPedidos.TabIndex = 5;
            // 
            // lstPedidos
            // 
            this.lstPedidos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.ItemHeight = 21;
            this.lstPedidos.Location = new System.Drawing.Point(7, 45);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(443, 193);
            this.lstPedidos.TabIndex = 4;
            // 
            // gbVentas
            // 
            this.gbVentas.Controls.Add(this.label2);
            this.gbVentas.Controls.Add(this.lblTotalBs);
            this.gbVentas.Controls.Add(this.lstCantidadVenta);
            this.gbVentas.Controls.Add(this.groupBox1);
            this.gbVentas.Controls.Add(this.lstTotalBs);
            this.gbVentas.Controls.Add(this.lstVentas);
            this.gbVentas.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVentas.Location = new System.Drawing.Point(11, 370);
            this.gbVentas.Name = "gbVentas";
            this.gbVentas.Size = new System.Drawing.Size(1168, 267);
            this.gbVentas.TabIndex = 4;
            this.gbVentas.TabStop = false;
            this.gbVentas.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cantidad";
            // 
            // lblTotalBs
            // 
            this.lblTotalBs.AutoSize = true;
            this.lblTotalBs.Location = new System.Drawing.Point(594, 11);
            this.lblTotalBs.Name = "lblTotalBs";
            this.lblTotalBs.Size = new System.Drawing.Size(90, 21);
            this.lblTotalBs.TabIndex = 11;
            this.lblTotalBs.Text = "Total Bs.";
            // 
            // lstCantidadVenta
            // 
            this.lstCantidadVenta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCantidadVenta.FormattingEnabled = true;
            this.lstCantidadVenta.ItemHeight = 21;
            this.lstCantidadVenta.Location = new System.Drawing.Point(455, 35);
            this.lstCantidadVenta.Name = "lstCantidadVenta";
            this.lstCantidadVenta.Size = new System.Drawing.Size(110, 214);
            this.lstCantidadVenta.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinalizarVenta);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.txtCambio);
            this.groupBox1.Controls.Add(this.lblCambio);
            this.groupBox1.Controls.Add(this.txtDineroRecibido);
            this.groupBox1.Controls.Add(this.lblDineroRecibido);
            this.groupBox1.Controls.Add(this.txtTotalPago);
            this.groupBox1.Controls.Add(this.lblTotalPago);
            this.groupBox1.Location = new System.Drawing.Point(708, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 229);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasarela de Pago";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(184, 34);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(144, 25);
            this.txtTotal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(343, 190);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 33);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(184, 155);
            this.txtCambio.Multiline = true;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(144, 25);
            this.txtCambio.TabIndex = 5;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(19, 157);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(82, 21);
            this.lblCambio.TabIndex = 4;
            this.lblCambio.Text = "Cambio:";
            // 
            // txtDineroRecibido
            // 
            this.txtDineroRecibido.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDineroRecibido.Location = new System.Drawing.Point(184, 114);
            this.txtDineroRecibido.Multiline = true;
            this.txtDineroRecibido.Name = "txtDineroRecibido";
            this.txtDineroRecibido.Size = new System.Drawing.Size(144, 25);
            this.txtDineroRecibido.TabIndex = 3;
            // 
            // lblDineroRecibido
            // 
            this.lblDineroRecibido.AutoSize = true;
            this.lblDineroRecibido.Location = new System.Drawing.Point(19, 116);
            this.lblDineroRecibido.Name = "lblDineroRecibido";
            this.lblDineroRecibido.Size = new System.Drawing.Size(159, 21);
            this.lblDineroRecibido.TabIndex = 2;
            this.lblDineroRecibido.Text = "Dinero Recibido:";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPago.Location = new System.Drawing.Point(184, 73);
            this.txtTotalPago.Multiline = true;
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(144, 25);
            this.txtTotalPago.TabIndex = 1;
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(16, 75);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(142, 21);
            this.lblTotalPago.TabIndex = 0;
            this.lblTotalPago.Text = "Total a Pagar:";
            // 
            // lstTotalBs
            // 
            this.lstTotalBs.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTotalBs.FormattingEnabled = true;
            this.lstTotalBs.ItemHeight = 21;
            this.lstTotalBs.Location = new System.Drawing.Point(571, 35);
            this.lstTotalBs.Name = "lstTotalBs";
            this.lstTotalBs.Size = new System.Drawing.Size(118, 214);
            this.lstTotalBs.TabIndex = 8;
            // 
            // lstVentas
            // 
            this.lstVentas.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVentas.FormattingEnabled = true;
            this.lstVentas.ItemHeight = 21;
            this.lstVentas.Location = new System.Drawing.Point(6, 35);
            this.lstVentas.Name = "lstVentas";
            this.lstVentas.Size = new System.Drawing.Size(443, 214);
            this.lstVentas.TabIndex = 7;
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarVenta.Location = new System.Drawing.Point(183, 190);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(145, 33);
            this.btnFinalizarVenta.TabIndex = 10;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // ProcesoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 649);
            this.Controls.Add(this.gbVentas);
            this.Controls.Add(this.gbPedidos);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.gbCliente);
            this.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProcesoVenta";
            this.Text = "Proceso de Venta";
            this.Load += new System.EventHandler(this.ProcesoVenta_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.gbFecha.ResumeLayout(false);
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            this.gbPedidos.ResumeLayout(false);
            this.gbPedidos.PerformLayout();
            this.gbVentas.ResumeLayout(false);
            this.gbVentas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.RadioButton rbMinorista;
        private System.Windows.Forms.RadioButton rbVendedor;
        private System.Windows.Forms.RadioButton rbMayorista;
        private System.Windows.Forms.RadioButton rbEmpleado;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.DateTimePicker SeleccionFecha;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnProcesarPedido;
        private System.Windows.Forms.GroupBox gbVentas;
        private System.Windows.Forms.ListBox lstTotalBs;
        private System.Windows.Forms.ListBox lstVentas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDineroRecibido;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtDineroRecibido;
        private System.Windows.Forms.ListBox lstCantidadVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalBs;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListBox lstPrecioUnitario;
        private System.Windows.Forms.Label lblPU;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ListBox lstCantidadPedidos;
        public System.Windows.Forms.GroupBox gbPedidos;
        public System.Windows.Forms.ListBox lstPedidos;
        public System.Windows.Forms.ListBox lstPrecioPedido;
        private System.Windows.Forms.Button btnFinalizarVenta;
    }
}

