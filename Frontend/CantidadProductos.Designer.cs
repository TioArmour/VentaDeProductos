
namespace Frontend
{
    partial class CantidadProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCantidadProductos = new System.Windows.Forms.GroupBox();
            this.btnHecho = new System.Windows.Forms.Button();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCantidadProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCantidadProductos
            // 
            this.gbCantidadProductos.Controls.Add(this.btnHecho);
            this.gbCantidadProductos.Controls.Add(this.txtCantidadProducto);
            this.gbCantidadProductos.Controls.Add(this.label1);
            this.gbCantidadProductos.Location = new System.Drawing.Point(13, 13);
            this.gbCantidadProductos.Margin = new System.Windows.Forms.Padding(4);
            this.gbCantidadProductos.Name = "gbCantidadProductos";
            this.gbCantidadProductos.Padding = new System.Windows.Forms.Padding(4);
            this.gbCantidadProductos.Size = new System.Drawing.Size(254, 92);
            this.gbCantidadProductos.TabIndex = 0;
            this.gbCantidadProductos.TabStop = false;
            // 
            // btnHecho
            // 
            this.btnHecho.Location = new System.Drawing.Point(106, 54);
            this.btnHecho.Margin = new System.Windows.Forms.Padding(4);
            this.btnHecho.Name = "btnHecho";
            this.btnHecho.Size = new System.Drawing.Size(125, 30);
            this.btnHecho.TabIndex = 2;
            this.btnHecho.Text = "Hecho";
            this.btnHecho.UseVisualStyleBackColor = true;
            this.btnHecho.Click += new System.EventHandler(this.btnHecho_Click);
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(106, 20);
            this.txtCantidadProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(124, 27);
            this.txtCantidadProducto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad : ";
            // 
            // CantidadProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 117);
            this.Controls.Add(this.gbCantidadProductos);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CantidadProductos";
            this.Text = "Cantidad de Productos";
            this.gbCantidadProductos.ResumeLayout(false);
            this.gbCantidadProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCantidadProductos;
        private System.Windows.Forms.Button btnHecho;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCantidadProducto;
    }
}