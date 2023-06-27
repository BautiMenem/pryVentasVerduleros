namespace pryVentasVerduleros
{
    partial class Form2
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
            this.lstVendedor = new System.Windows.Forms.ComboBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.lblkilos = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lstProducto = new System.Windows.Forms.ComboBox();
            this.lblventas = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstVendedor
            // 
            this.lstVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedor.FormattingEnabled = true;
            this.lstVendedor.Location = new System.Drawing.Point(28, 94);
            this.lstVendedor.Name = "lstVendedor";
            this.lstVendedor.Size = new System.Drawing.Size(205, 21);
            this.lstVendedor.TabIndex = 0;
            this.lstVendedor.SelectedIndexChanged += new System.EventHandler(this.lstVendedor_SelectedIndexChanged);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(25, 62);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(109, 13);
            this.lblVendedor.TabIndex = 1;
            this.lblVendedor.Text = "Seleccione Vendedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(267, 62);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(109, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Seleccione  Producto";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(28, 188);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(205, 20);
            this.dtpFecha.TabIndex = 4;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(270, 188);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(205, 20);
            this.txtKilos.TabIndex = 5;
            // 
            // lblkilos
            // 
            this.lblkilos.AutoSize = true;
            this.lblkilos.Location = new System.Drawing.Point(267, 154);
            this.lblkilos.Name = "lblkilos";
            this.lblkilos.Size = new System.Drawing.Size(116, 13);
            this.lblkilos.TabIndex = 6;
            this.lblkilos.Text = "Peso del Producto (Kg)";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(25, 154);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha de Venta";
            // 
            // lstProducto
            // 
            this.lstProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProducto.FormattingEnabled = true;
            this.lstProducto.Location = new System.Drawing.Point(270, 94);
            this.lstProducto.Name = "lstProducto";
            this.lstProducto.Size = new System.Drawing.Size(205, 21);
            this.lstProducto.TabIndex = 8;
            // 
            // lblventas
            // 
            this.lblventas.AutoSize = true;
            this.lblventas.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblventas.Location = new System.Drawing.Point(219, 9);
            this.lblventas.Name = "lblventas";
            this.lblventas.Size = new System.Drawing.Size(70, 34);
            this.lblventas.TabIndex = 9;
            this.lblventas.Text = "Ventas";
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(400, 230);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 265);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblventas);
            this.Controls.Add(this.lstProducto);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblkilos);
            this.Controls.Add(this.txtKilos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lstVendedor);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.Label lblkilos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox lstProducto;
        private System.Windows.Forms.Label lblventas;
        private System.Windows.Forms.Button btnCargar;
    }
}