namespace Steven_Rocha_Ordenamientos
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbCantidad = new System.Windows.Forms.GroupBox();
            this.btnCantidadClientes = new System.Windows.Forms.Button();
            this.txtCantidadClientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gpbServicios = new System.Windows.Forms.GroupBox();
            this.rbTelefono = new System.Windows.Forms.RadioButton();
            this.rbTelevision = new System.Windows.Forms.RadioButton();
            this.rbInternet = new System.Windows.Forms.RadioButton();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdentificadorCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.gpbMostrar = new System.Windows.Forms.GroupBox();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbCantidad.SuspendLayout();
            this.gpbDatos.SuspendLayout();
            this.gpbServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gpbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbCantidad
            // 
            this.gpbCantidad.Controls.Add(this.btnCantidadClientes);
            this.gpbCantidad.Controls.Add(this.txtCantidadClientes);
            this.gpbCantidad.Controls.Add(this.label1);
            this.gpbCantidad.Location = new System.Drawing.Point(205, 12);
            this.gpbCantidad.Name = "gpbCantidad";
            this.gpbCantidad.Size = new System.Drawing.Size(245, 103);
            this.gpbCantidad.TabIndex = 0;
            this.gpbCantidad.TabStop = false;
            // 
            // btnCantidadClientes
            // 
            this.btnCantidadClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnCantidadClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCantidadClientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidadClientes.Location = new System.Drawing.Point(58, 58);
            this.btnCantidadClientes.Name = "btnCantidadClientes";
            this.btnCantidadClientes.Size = new System.Drawing.Size(136, 28);
            this.btnCantidadClientes.TabIndex = 2;
            this.btnCantidadClientes.Text = "Aceptar";
            this.btnCantidadClientes.UseVisualStyleBackColor = false;
            this.btnCantidadClientes.Click += new System.EventHandler(this.btnCantidadClientes_Click);
            // 
            // txtCantidadClientes
            // 
            this.txtCantidadClientes.Location = new System.Drawing.Point(58, 32);
            this.txtCantidadClientes.Name = "txtCantidadClientes";
            this.txtCantidadClientes.Size = new System.Drawing.Size(136, 20);
            this.txtCantidadClientes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese maximo Clientes:";
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.btnGuardar);
            this.gpbDatos.Controls.Add(this.gpbServicios);
            this.gpbDatos.Controls.Add(this.txtDescuento);
            this.gpbDatos.Controls.Add(this.label5);
            this.gpbDatos.Controls.Add(this.txtPrecioProducto);
            this.gpbDatos.Controls.Add(this.label4);
            this.gpbDatos.Controls.Add(this.txtNombreCliente);
            this.gpbDatos.Controls.Add(this.label3);
            this.gpbDatos.Controls.Add(this.txtIdentificadorCliente);
            this.gpbDatos.Controls.Add(this.label2);
            this.gpbDatos.ForeColor = System.Drawing.Color.White;
            this.gpbDatos.Location = new System.Drawing.Point(33, 121);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(557, 231);
            this.gpbDatos.TabIndex = 1;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(135, 184);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(282, 38);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gpbServicios
            // 
            this.gpbServicios.Controls.Add(this.rbTelefono);
            this.gpbServicios.Controls.Add(this.rbTelevision);
            this.gpbServicios.Controls.Add(this.rbInternet);
            this.gpbServicios.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbServicios.ForeColor = System.Drawing.Color.White;
            this.gpbServicios.Location = new System.Drawing.Point(135, 96);
            this.gpbServicios.Name = "gpbServicios";
            this.gpbServicios.Size = new System.Drawing.Size(282, 81);
            this.gpbServicios.TabIndex = 11;
            this.gpbServicios.TabStop = false;
            this.gpbServicios.Text = "Servicio/Producto";
            // 
            // rbTelefono
            // 
            this.rbTelefono.AutoSize = true;
            this.rbTelefono.Location = new System.Drawing.Point(191, 35);
            this.rbTelefono.Name = "rbTelefono";
            this.rbTelefono.Size = new System.Drawing.Size(87, 27);
            this.rbTelefono.TabIndex = 2;
            this.rbTelefono.TabStop = true;
            this.rbTelefono.Text = "Telefonica";
            this.rbTelefono.UseVisualStyleBackColor = true;
            // 
            // rbTelevision
            // 
            this.rbTelevision.AutoSize = true;
            this.rbTelevision.Location = new System.Drawing.Point(98, 35);
            this.rbTelevision.Name = "rbTelevision";
            this.rbTelevision.Size = new System.Drawing.Size(85, 27);
            this.rbTelevision.TabIndex = 1;
            this.rbTelevision.TabStop = true;
            this.rbTelevision.Text = "Televisión";
            this.rbTelevision.UseVisualStyleBackColor = true;
            // 
            // rbInternet
            // 
            this.rbInternet.AutoSize = true;
            this.rbInternet.Location = new System.Drawing.Point(19, 35);
            this.rbInternet.Name = "rbInternet";
            this.rbInternet.Size = new System.Drawing.Size(72, 27);
            this.rbInternet.TabIndex = 0;
            this.rbInternet.TabStop = true;
            this.rbInternet.Text = "Internet";
            this.rbInternet.UseVisualStyleBackColor = true;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(403, 52);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(135, 20);
            this.txtDescuento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descuento:";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(154, 54);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(135, 20);
            this.txtPrecioProducto.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio Produto/Servicio:";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(403, 24);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(135, 20);
            this.txtNombreCliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre Cliente:";
            // 
            // txtIdentificadorCliente
            // 
            this.txtIdentificadorCliente.Location = new System.Drawing.Point(154, 25);
            this.txtIdentificadorCliente.Name = "txtIdentificadorCliente";
            this.txtIdentificadorCliente.Size = new System.Drawing.Size(135, 20);
            this.txtIdentificadorCliente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Identificacion Cliente:";
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDatos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvDatos.Location = new System.Drawing.Point(109, 54);
            this.dgvDatos.Name = "dgvDatos";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDatos.Size = new System.Drawing.Size(343, 147);
            this.dgvDatos.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto/Servicio";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Cliente";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Total a Pagar";
            this.Column3.Name = "Column3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(176, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ordenar Por:";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "BARAJA",
            "QUICKSORT"});
            this.cmbOrdenar.Location = new System.Drawing.Point(264, 19);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 29);
            this.cmbOrdenar.TabIndex = 4;
            this.cmbOrdenar.TextChanged += new System.EventHandler(this.cmbOrdenar_TextChanged);
            // 
            // gpbMostrar
            // 
            this.gpbMostrar.Controls.Add(this.btnNuevoRegistro);
            this.gpbMostrar.Controls.Add(this.dgvDatos);
            this.gpbMostrar.Controls.Add(this.cmbOrdenar);
            this.gpbMostrar.Controls.Add(this.label6);
            this.gpbMostrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gpbMostrar.Location = new System.Drawing.Point(33, 371);
            this.gpbMostrar.Name = "gpbMostrar";
            this.gpbMostrar.Size = new System.Drawing.Size(557, 242);
            this.gpbMostrar.TabIndex = 5;
            this.gpbMostrar.TabStop = false;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.btnNuevoRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistro.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(416, 207);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(135, 28);
            this.btnNuevoRegistro.TabIndex = 6;
            this.btnNuevoRegistro.Text = "Nuevo Registro";
            this.btnNuevoRegistro.UseVisualStyleBackColor = false;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Steven_Rocha_Ordenamientos.Properties.Resources.tigoazul;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(622, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbMostrar);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.gpbCantidad);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gpbCantidad.ResumeLayout(false);
            this.gpbCantidad.PerformLayout();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.gpbServicios.ResumeLayout(false);
            this.gpbServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gpbMostrar.ResumeLayout(false);
            this.gpbMostrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCantidad;
        private System.Windows.Forms.Button btnCantidadClientes;
        private System.Windows.Forms.TextBox txtCantidadClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gpbServicios;
        private System.Windows.Forms.RadioButton rbTelefono;
        private System.Windows.Forms.RadioButton rbTelevision;
        private System.Windows.Forms.RadioButton rbInternet;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdentificadorCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.GroupBox gpbMostrar;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

