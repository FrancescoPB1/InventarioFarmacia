﻿
namespace Farmacia
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.i_btn_cancelar1 = new System.Windows.Forms.Button();
            this.i_btn_agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.i_txt_codigo = new System.Windows.Forms.TextBox();
            this.i_txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.i_txt_nombre = new System.Windows.Forms.TextBox();
            this.i_txt_cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.i_btn_cancelar2 = new System.Windows.Forms.Button();
            this.i_eliminar = new System.Windows.Forms.Button();
            this.i_txt_codigoEliminar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.I_Lista = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.i_btn_buscarCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.i_btn_buscar = new System.Windows.Forms.Button();
            this.i_txt_buscar = new System.Windows.Forms.TextBox();
            this.i_listaMedicamentos = new System.Windows.Forms.DataGridView();
            this.Ic_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_PrecioU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ic_Montototal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.I_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_listaMedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1004, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista de Medicamentos G9";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.i_btn_cancelar1);
            this.groupBox2.Controls.Add(this.i_btn_agregar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.i_txt_codigo);
            this.groupBox2.Controls.Add(this.i_txt_precio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.i_txt_nombre);
            this.groupBox2.Controls.Add(this.i_txt_cantidad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(497, 268);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar Medicamento";
            // 
            // i_btn_cancelar1
            // 
            this.i_btn_cancelar1.Location = new System.Drawing.Point(212, 203);
            this.i_btn_cancelar1.Name = "i_btn_cancelar1";
            this.i_btn_cancelar1.Size = new System.Drawing.Size(200, 54);
            this.i_btn_cancelar1.TabIndex = 10;
            this.i_btn_cancelar1.Text = "Cancelar";
            this.i_btn_cancelar1.UseVisualStyleBackColor = true;
            this.i_btn_cancelar1.Click += new System.EventHandler(this.i_btn_cancelar1_Click);
            // 
            // i_btn_agregar
            // 
            this.i_btn_agregar.Location = new System.Drawing.Point(17, 203);
            this.i_btn_agregar.Name = "i_btn_agregar";
            this.i_btn_agregar.Size = new System.Drawing.Size(189, 54);
            this.i_btn_agregar.TabIndex = 9;
            this.i_btn_agregar.Text = "Agregar";
            this.i_btn_agregar.UseVisualStyleBackColor = true;
            this.i_btn_agregar.Click += new System.EventHandler(this.i_btn_agregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio U.";
            // 
            // i_txt_codigo
            // 
            this.i_txt_codigo.Location = new System.Drawing.Point(203, 50);
            this.i_txt_codigo.Multiline = true;
            this.i_txt_codigo.Name = "i_txt_codigo";
            this.i_txt_codigo.Size = new System.Drawing.Size(167, 32);
            this.i_txt_codigo.TabIndex = 4;
            // 
            // i_txt_precio
            // 
            this.i_txt_precio.Location = new System.Drawing.Point(203, 165);
            this.i_txt_precio.Multiline = true;
            this.i_txt_precio.Name = "i_txt_precio";
            this.i_txt_precio.Size = new System.Drawing.Size(167, 32);
            this.i_txt_precio.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // i_txt_nombre
            // 
            this.i_txt_nombre.Location = new System.Drawing.Point(203, 88);
            this.i_txt_nombre.Multiline = true;
            this.i_txt_nombre.Name = "i_txt_nombre";
            this.i_txt_nombre.Size = new System.Drawing.Size(167, 32);
            this.i_txt_nombre.TabIndex = 8;
            // 
            // i_txt_cantidad
            // 
            this.i_txt_cantidad.Location = new System.Drawing.Point(203, 126);
            this.i_txt_cantidad.Multiline = true;
            this.i_txt_cantidad.Name = "i_txt_cantidad";
            this.i_txt_cantidad.Size = new System.Drawing.Size(167, 32);
            this.i_txt_cantidad.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.i_btn_cancelar2);
            this.groupBox1.Controls.Add(this.i_eliminar);
            this.groupBox1.Controls.Add(this.i_txt_codigoEliminar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(536, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 180);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Medicamento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // i_btn_cancelar2
            // 
            this.i_btn_cancelar2.Location = new System.Drawing.Point(230, 124);
            this.i_btn_cancelar2.Name = "i_btn_cancelar2";
            this.i_btn_cancelar2.Size = new System.Drawing.Size(225, 52);
            this.i_btn_cancelar2.TabIndex = 10;
            this.i_btn_cancelar2.Text = "Cancelar";
            this.i_btn_cancelar2.UseVisualStyleBackColor = true;
            this.i_btn_cancelar2.Click += new System.EventHandler(this.i_btn_cancelar2_Click);
            // 
            // i_eliminar
            // 
            this.i_eliminar.Location = new System.Drawing.Point(14, 124);
            this.i_eliminar.Name = "i_eliminar";
            this.i_eliminar.Size = new System.Drawing.Size(185, 52);
            this.i_eliminar.TabIndex = 9;
            this.i_eliminar.Text = "Eliminar";
            this.i_eliminar.UseVisualStyleBackColor = true;
            this.i_eliminar.Click += new System.EventHandler(this.i_eliminar_Click);
            // 
            // i_txt_codigoEliminar
            // 
            this.i_txt_codigoEliminar.Location = new System.Drawing.Point(176, 76);
            this.i_txt_codigoEliminar.Multiline = true;
            this.i_txt_codigoEliminar.Name = "i_txt_codigoEliminar";
            this.i_txt_codigoEliminar.Size = new System.Drawing.Size(201, 32);
            this.i_txt_codigoEliminar.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 46);
            this.label10.TabIndex = 0;
            this.label10.Text = "Código";
            // 
            // I_Lista
            // 
            this.I_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.I_Lista.Controls.Add(this.label7);
            this.I_Lista.Controls.Add(this.i_btn_buscarCancelar);
            this.I_Lista.Controls.Add(this.label6);
            this.I_Lista.Controls.Add(this.i_btn_buscar);
            this.I_Lista.Controls.Add(this.i_txt_buscar);
            this.I_Lista.Controls.Add(this.i_listaMedicamentos);
            this.I_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_Lista.Location = new System.Drawing.Point(12, 384);
            this.I_Lista.Margin = new System.Windows.Forms.Padding(4);
            this.I_Lista.Name = "I_Lista";
            this.I_Lista.Padding = new System.Windows.Forms.Padding(4);
            this.I_Lista.Size = new System.Drawing.Size(1023, 422);
            this.I_Lista.TabIndex = 13;
            this.I_Lista.TabStop = false;
            this.I_Lista.Text = "Lista";
            this.I_Lista.Enter += new System.EventHandler(this.I_Lista_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(529, 46);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ingresa el nombre a buscar";
            // 
            // i_btn_buscarCancelar
            // 
            this.i_btn_buscarCancelar.Location = new System.Drawing.Point(505, 99);
            this.i_btn_buscarCancelar.Name = "i_btn_buscarCancelar";
            this.i_btn_buscarCancelar.Size = new System.Drawing.Size(224, 54);
            this.i_btn_buscarCancelar.TabIndex = 10;
            this.i_btn_buscarCancelar.Text = "Cancelar";
            this.i_btn_buscarCancelar.UseVisualStyleBackColor = true;
            this.i_btn_buscarCancelar.Click += new System.EventHandler(this.i_btn_buscarCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(640, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 46);
            this.label6.TabIndex = 4;
            // 
            // i_btn_buscar
            // 
            this.i_btn_buscar.Location = new System.Drawing.Point(318, 99);
            this.i_btn_buscar.Name = "i_btn_buscar";
            this.i_btn_buscar.Size = new System.Drawing.Size(169, 54);
            this.i_btn_buscar.TabIndex = 2;
            this.i_btn_buscar.Text = "Buscar";
            this.i_btn_buscar.UseVisualStyleBackColor = true;
            this.i_btn_buscar.Click += new System.EventHandler(this.I_Buscar_Click);
            // 
            // i_txt_buscar
            // 
            this.i_txt_buscar.Location = new System.Drawing.Point(8, 99);
            this.i_txt_buscar.Multiline = true;
            this.i_txt_buscar.Name = "i_txt_buscar";
            this.i_txt_buscar.Size = new System.Drawing.Size(292, 53);
            this.i_txt_buscar.TabIndex = 1;
            // 
            // i_listaMedicamentos
            // 
            this.i_listaMedicamentos.AllowUserToAddRows = false;
            this.i_listaMedicamentos.AllowUserToDeleteRows = false;
            this.i_listaMedicamentos.AllowUserToOrderColumns = true;
            this.i_listaMedicamentos.AllowUserToResizeRows = false;
            this.i_listaMedicamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.i_listaMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.i_listaMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.i_listaMedicamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ic_Codigo,
            this.Ic_Nombre,
            this.Ic_Cantida,
            this.Ic_PrecioU,
            this.Ic_Montototal});
            this.i_listaMedicamentos.Enabled = false;
            this.i_listaMedicamentos.Location = new System.Drawing.Point(8, 181);
            this.i_listaMedicamentos.Margin = new System.Windows.Forms.Padding(4);
            this.i_listaMedicamentos.Name = "i_listaMedicamentos";
            this.i_listaMedicamentos.RowHeadersWidth = 102;
            this.i_listaMedicamentos.Size = new System.Drawing.Size(1007, 247);
            this.i_listaMedicamentos.TabIndex = 0;
            this.i_listaMedicamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.i_listaMedicamentos_CellContentClick);
            // 
            // Ic_Codigo
            // 
            this.Ic_Codigo.HeaderText = "Codigo";
            this.Ic_Codigo.MinimumWidth = 12;
            this.Ic_Codigo.Name = "Ic_Codigo";
            // 
            // Ic_Nombre
            // 
            this.Ic_Nombre.HeaderText = "Nombre";
            this.Ic_Nombre.MinimumWidth = 12;
            this.Ic_Nombre.Name = "Ic_Nombre";
            // 
            // Ic_Cantida
            // 
            this.Ic_Cantida.HeaderText = "Cantidad";
            this.Ic_Cantida.MinimumWidth = 12;
            this.Ic_Cantida.Name = "Ic_Cantida";
            // 
            // Ic_PrecioU
            // 
            this.Ic_PrecioU.HeaderText = "Precio Unitario";
            this.Ic_PrecioU.MinimumWidth = 12;
            this.Ic_PrecioU.Name = "Ic_PrecioU";
            // 
            // Ic_Montototal
            // 
            this.Ic_Montototal.HeaderText = "Monto Invertido";
            this.Ic_Montototal.MinimumWidth = 12;
            this.Ic_Montototal.Name = "Ic_Montototal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 830);
            this.Controls.Add(this.I_Lista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Farmacia";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.I_Lista.ResumeLayout(false);
            this.I_Lista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.i_listaMedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button i_btn_cancelar1;
        private System.Windows.Forms.Button i_btn_agregar;
        public System.Windows.Forms.TextBox i_txt_nombre;
        public System.Windows.Forms.TextBox i_txt_cantidad;
        public System.Windows.Forms.TextBox i_txt_precio;
        public System.Windows.Forms.TextBox i_txt_codigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button i_btn_cancelar2;
        private System.Windows.Forms.Button i_eliminar;
        public System.Windows.Forms.TextBox i_txt_codigoEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox I_Lista;
        private System.Windows.Forms.Button i_btn_buscarCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button i_btn_buscar;
        private System.Windows.Forms.TextBox i_txt_buscar;
        private System.Windows.Forms.DataGridView i_listaMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_PrecioU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ic_Montototal;
        private System.Windows.Forms.Label label7;
    }
}

