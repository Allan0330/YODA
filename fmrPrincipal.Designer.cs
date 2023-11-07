namespace PROYECTO_02
{
    partial class frmPresupuesto
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
            this.lblPedido = new System.Windows.Forms.Label();
            this.grbPedidos = new System.Windows.Forms.GroupBox();
            this.lblPersonas = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtPedido = new System.Windows.Forms.TextBox();
            this.txtNumPersonas = new System.Windows.Forms.TextBox();
            this.btnCotizacion = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.grbPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(16, 37);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(187, 15);
            this.lblPedido.TabIndex = 0;
            this.lblPedido.Text = "Por favor ingrese su pedido:";
            // 
            // grbPedidos
            // 
            this.grbPedidos.Controls.Add(this.btnCotizacion);
            this.grbPedidos.Controls.Add(this.txtNumPersonas);
            this.grbPedidos.Controls.Add(this.txtPedido);
            this.grbPedidos.Controls.Add(this.btnMenu);
            this.grbPedidos.Controls.Add(this.lblPersonas);
            this.grbPedidos.Controls.Add(this.lblPedido);
            this.grbPedidos.Location = new System.Drawing.Point(47, 22);
            this.grbPedidos.Name = "grbPedidos";
            this.grbPedidos.Size = new System.Drawing.Size(842, 158);
            this.grbPedidos.TabIndex = 1;
            this.grbPedidos.TabStop = false;
            this.grbPedidos.Text = "Pedido";
            this.grbPedidos.Enter += new System.EventHandler(this.grbPedidos_Enter);
            // 
            // lblPersonas
            // 
            this.lblPersonas.AutoSize = true;
            this.lblPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonas.Location = new System.Drawing.Point(442, 36);
            this.lblPersonas.Name = "lblPersonas";
            this.lblPersonas.Size = new System.Drawing.Size(145, 15);
            this.lblPersonas.TabIndex = 4;
            this.lblPersonas.Text = "Número de personas:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::PROYECTO_02.Properties.Resources._4115235_exit_logout_sign_out_114030;
            this.btnSalir.Location = new System.Drawing.Point(608, 334);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 55);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::PROYECTO_02.Properties.Resources.cleaning_clean_broom_icon_153281;
            this.btnLimpiar.Location = new System.Drawing.Point(492, 334);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(76, 55);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::PROYECTO_02.Properties.Resources._3709737_call_centre_online_service_support_108089;
            this.btnConsultar.Location = new System.Drawing.Point(382, 334);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(76, 55);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::PROYECTO_02.Properties.Resources.savetheapplication_guardar_2958;
            this.btnGrabar.Location = new System.Drawing.Point(273, 334);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(76, 55);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(19, 112);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(114, 30);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Lista de Banquetes";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtPedido
            // 
            this.txtPedido.Location = new System.Drawing.Point(209, 34);
            this.txtPedido.Name = "txtPedido";
            this.txtPedido.Size = new System.Drawing.Size(200, 20);
            this.txtPedido.TabIndex = 7;
            // 
            // txtNumPersonas
            // 
            this.txtNumPersonas.Location = new System.Drawing.Point(605, 34);
            this.txtNumPersonas.Name = "txtNumPersonas";
            this.txtNumPersonas.Size = new System.Drawing.Size(76, 20);
            this.txtNumPersonas.TabIndex = 8;
            this.txtNumPersonas.TextChanged += new System.EventHandler(this.txtNumPersonas_TextChanged);
            this.txtNumPersonas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumPersonas_KeyPress);
            // 
            // btnCotizacion
            // 
            this.btnCotizacion.Location = new System.Drawing.Point(173, 112);
            this.btnCotizacion.Name = "btnCotizacion";
            this.btnCotizacion.Size = new System.Drawing.Size(119, 30);
            this.btnCotizacion.TabIndex = 6;
            this.btnCotizacion.Text = "Realizar cotización";
            this.btnCotizacion.UseVisualStyleBackColor = true;
            this.btnCotizacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(47, 219);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(842, 82);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 429);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.grbPedidos);
            this.Name = "frmPresupuesto";
            this.Text = "La Langosta Ahumada";
            this.Load += new System.EventHandler(this.frmPresupuesto_Load);
            this.grbPedidos.ResumeLayout(false);
            this.grbPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPedido;
        private System.Windows.Forms.GroupBox grbPedidos;
        private System.Windows.Forms.Label lblPersonas;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtPedido;
        private System.Windows.Forms.TextBox txtNumPersonas;
        private System.Windows.Forms.Button btnCotizacion;
        private System.Windows.Forms.ListView listView1;
    }
}

