namespace Ejercicio_1
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
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.rbBanco = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.cmBorrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.lbDescripcionPeriodo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnCerrarPre = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.gbProductos.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.label6);
            this.gbProductos.Controls.Add(this.label5);
            this.gbProductos.Controls.Add(this.label4);
            this.gbProductos.Controls.Add(this.label3);
            this.gbProductos.Controls.Add(this.rbMesa);
            this.gbProductos.Controls.Add(this.rbBanco);
            this.gbProductos.Controls.Add(this.label2);
            this.gbProductos.Controls.Add(this.tbGrosor);
            this.gbProductos.Controls.Add(this.tbLargo);
            this.gbProductos.Controls.Add(this.tbCodigo);
            this.gbProductos.Controls.Add(this.tbAncho);
            this.gbProductos.Controls.Add(this.tbPrecio);
            this.gbProductos.Controls.Add(this.btnAgregar);
            this.gbProductos.Location = new System.Drawing.Point(319, 14);
            this.gbProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProductos.Size = new System.Drawing.Size(365, 225);
            this.gbProductos.TabIndex = 14;
            this.gbProductos.TabStop = false;
            this.gbProductos.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Grosor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Largo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ancho:";
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(26, 180);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(51, 17);
            this.rbMesa.TabIndex = 23;
            this.rbMesa.TabStop = true;
            this.rbMesa.Text = "Mesa";
            this.rbMesa.UseVisualStyleBackColor = true;
            // 
            // rbBanco
            // 
            this.rbBanco.AutoSize = true;
            this.rbBanco.Location = new System.Drawing.Point(26, 150);
            this.rbBanco.Name = "rbBanco";
            this.rbBanco.Size = new System.Drawing.Size(56, 17);
            this.rbBanco.TabIndex = 22;
            this.rbBanco.TabStop = true;
            this.rbBanco.Text = "Banco";
            this.rbBanco.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Precio B:";
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(261, 68);
            this.tbGrosor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(92, 20);
            this.tbGrosor.TabIndex = 19;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(261, 29);
            this.tbLargo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(92, 20);
            this.tbLargo.TabIndex = 18;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(82, 104);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(92, 20);
            this.tbCodigo.TabIndex = 17;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(82, 68);
            this.tbAncho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(92, 20);
            this.tbAncho.TabIndex = 16;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(82, 29);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(92, 20);
            this.tbPrecio.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(228, 107);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.cmBorrar);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.tbDir);
            this.gbCliente.Controls.Add(this.lbDescripcionPeriodo);
            this.gbCliente.Controls.Add(this.tbNombre);
            this.gbCliente.Controls.Add(this.btnCerrarPre);
            this.gbCliente.Controls.Add(this.btnBorrar);
            this.gbCliente.Controls.Add(this.btnPresupuesto);
            this.gbCliente.Location = new System.Drawing.Point(13, 14);
            this.gbCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCliente.Size = new System.Drawing.Size(298, 225);
            this.gbCliente.TabIndex = 13;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // cmBorrar
            // 
            this.cmBorrar.FormattingEnabled = true;
            this.cmBorrar.Location = new System.Drawing.Point(29, 187);
            this.cmBorrar.Name = "cmBorrar";
            this.cmBorrar.Size = new System.Drawing.Size(121, 21);
            this.cmBorrar.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Direccion";
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(91, 65);
            this.tbDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(152, 20);
            this.tbDir.TabIndex = 13;
            // 
            // lbDescripcionPeriodo
            // 
            this.lbDescripcionPeriodo.AutoSize = true;
            this.lbDescripcionPeriodo.Location = new System.Drawing.Point(8, 29);
            this.lbDescripcionPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcionPeriodo.Name = "lbDescripcionPeriodo";
            this.lbDescripcionPeriodo.Size = new System.Drawing.Size(44, 13);
            this.lbDescripcionPeriodo.TabIndex = 12;
            this.lbDescripcionPeriodo.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(91, 29);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(152, 20);
            this.tbNombre.TabIndex = 11;
            // 
            // btnCerrarPre
            // 
            this.btnCerrarPre.Location = new System.Drawing.Point(158, 115);
            this.btnCerrarPre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarPre.Name = "btnCerrarPre";
            this.btnCerrarPre.Size = new System.Drawing.Size(118, 59);
            this.btnCerrarPre.TabIndex = 0;
            this.btnCerrarPre.Text = "Cerrar Presupuesto";
            this.btnCerrarPre.UseVisualStyleBackColor = true;
            this.btnCerrarPre.Click += new System.EventHandler(this.btnCerrarPre_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(157, 183);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(118, 35);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(21, 115);
            this.btnPresupuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(129, 59);
            this.btnPresupuesto.TabIndex = 5;
            this.btnPresupuesto.Text = "Iniciar Presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 246);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.gbCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbMesa;
        private System.Windows.Forms.RadioButton rbBanco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.ComboBox cmBorrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Label lbDescripcionPeriodo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnCerrarPre;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnPresupuesto;
    }
}

