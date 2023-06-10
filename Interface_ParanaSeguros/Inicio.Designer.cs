
namespace Interface_ParanaSeguros
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblpath = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btn_AgregarRecibos = new System.Windows.Forms.Button();
            this.lbl_path_Cobranzas = new System.Windows.Forms.Label();
            this.btn_Examinar_2 = new System.Windows.Forms.Button();
            this.btn_Procesar_Cobranzas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_GenerarPlanillas = new System.Windows.Forms.Button();
            this.btn_Interfaces = new System.Windows.Forms.Button();
            this.gb_Interfaces = new System.Windows.Forms.GroupBox();
            this.btn_ActualizarRendidos = new System.Windows.Forms.Button();
            this.btn_AvisosVTO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Clientes = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_okvaciar = new System.Windows.Forms.Button();
            this.gb_Vaciar = new System.Windows.Forms.GroupBox();
            this.gb_Interfaces.SuspendLayout();
            this.gb_Vaciar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(25, 76);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(124, 81);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(35, 13);
            this.lblpath.TabIndex = 1;
            this.lblpath.Text = "label1";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Enabled = false;
            this.btnProcesar.Location = new System.Drawing.Point(25, 120);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 2;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(928, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btn_AgregarRecibos
            // 
            this.btn_AgregarRecibos.Location = new System.Drawing.Point(182, 36);
            this.btn_AgregarRecibos.Name = "btn_AgregarRecibos";
            this.btn_AgregarRecibos.Size = new System.Drawing.Size(164, 32);
            this.btn_AgregarRecibos.TabIndex = 4;
            this.btn_AgregarRecibos.Text = "Agregar Recibos";
            this.btn_AgregarRecibos.UseVisualStyleBackColor = true;
            this.btn_AgregarRecibos.Click += new System.EventHandler(this.btn_AgregarRecibos_Click);
            // 
            // lbl_path_Cobranzas
            // 
            this.lbl_path_Cobranzas.AutoSize = true;
            this.lbl_path_Cobranzas.Location = new System.Drawing.Point(119, 230);
            this.lbl_path_Cobranzas.Name = "lbl_path_Cobranzas";
            this.lbl_path_Cobranzas.Size = new System.Drawing.Size(35, 13);
            this.lbl_path_Cobranzas.TabIndex = 6;
            this.lbl_path_Cobranzas.Text = "label1";
            // 
            // btn_Examinar_2
            // 
            this.btn_Examinar_2.Location = new System.Drawing.Point(20, 225);
            this.btn_Examinar_2.Name = "btn_Examinar_2";
            this.btn_Examinar_2.Size = new System.Drawing.Size(75, 23);
            this.btn_Examinar_2.TabIndex = 5;
            this.btn_Examinar_2.Text = "Examinar...";
            this.btn_Examinar_2.UseVisualStyleBackColor = true;
            this.btn_Examinar_2.Click += new System.EventHandler(this.btn_Examinar_2_Click);
            // 
            // btn_Procesar_Cobranzas
            // 
            this.btn_Procesar_Cobranzas.Enabled = false;
            this.btn_Procesar_Cobranzas.Location = new System.Drawing.Point(20, 269);
            this.btn_Procesar_Cobranzas.Name = "btn_Procesar_Cobranzas";
            this.btn_Procesar_Cobranzas.Size = new System.Drawing.Size(75, 23);
            this.btn_Procesar_Cobranzas.TabIndex = 7;
            this.btn_Procesar_Cobranzas.Text = "Procesar";
            this.btn_Procesar_Cobranzas.UseVisualStyleBackColor = true;
            this.btn_Procesar_Cobranzas.Click += new System.EventHandler(this.btn_Procesar_Cobranzas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "EMISIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "COBRANZAS";
            // 
            // btn_GenerarPlanillas
            // 
            this.btn_GenerarPlanillas.Location = new System.Drawing.Point(352, 36);
            this.btn_GenerarPlanillas.Name = "btn_GenerarPlanillas";
            this.btn_GenerarPlanillas.Size = new System.Drawing.Size(164, 32);
            this.btn_GenerarPlanillas.TabIndex = 10;
            this.btn_GenerarPlanillas.Text = "Generar Planillas";
            this.btn_GenerarPlanillas.UseVisualStyleBackColor = true;
            this.btn_GenerarPlanillas.Click += new System.EventHandler(this.btn_GenerarPlanillas_Click);
            // 
            // btn_Interfaces
            // 
            this.btn_Interfaces.Location = new System.Drawing.Point(12, 36);
            this.btn_Interfaces.Name = "btn_Interfaces";
            this.btn_Interfaces.Size = new System.Drawing.Size(164, 32);
            this.btn_Interfaces.TabIndex = 11;
            this.btn_Interfaces.Text = "Cargar Interfaz";
            this.btn_Interfaces.UseVisualStyleBackColor = true;
            this.btn_Interfaces.Click += new System.EventHandler(this.btn_Interfaces_Click);
            // 
            // gb_Interfaces
            // 
            this.gb_Interfaces.Controls.Add(this.label1);
            this.gb_Interfaces.Controls.Add(this.btnExaminar);
            this.gb_Interfaces.Controls.Add(this.lblpath);
            this.gb_Interfaces.Controls.Add(this.label2);
            this.gb_Interfaces.Controls.Add(this.btn_Procesar_Cobranzas);
            this.gb_Interfaces.Controls.Add(this.btnProcesar);
            this.gb_Interfaces.Controls.Add(this.lbl_path_Cobranzas);
            this.gb_Interfaces.Controls.Add(this.btn_Examinar_2);
            this.gb_Interfaces.Location = new System.Drawing.Point(12, 165);
            this.gb_Interfaces.Name = "gb_Interfaces";
            this.gb_Interfaces.Size = new System.Drawing.Size(981, 306);
            this.gb_Interfaces.TabIndex = 12;
            this.gb_Interfaces.TabStop = false;
            this.gb_Interfaces.Text = "Interfaces";
            this.gb_Interfaces.Leave += new System.EventHandler(this.gb_Interfaces_Leave);
            // 
            // btn_ActualizarRendidos
            // 
            this.btn_ActualizarRendidos.Location = new System.Drawing.Point(522, 36);
            this.btn_ActualizarRendidos.Name = "btn_ActualizarRendidos";
            this.btn_ActualizarRendidos.Size = new System.Drawing.Size(164, 32);
            this.btn_ActualizarRendidos.TabIndex = 13;
            this.btn_ActualizarRendidos.Text = "Actualizar Recibos Rendidos";
            this.btn_ActualizarRendidos.UseVisualStyleBackColor = true;
            this.btn_ActualizarRendidos.Click += new System.EventHandler(this.btn_ActualizarRendidos_Click);
            // 
            // btn_AvisosVTO
            // 
            this.btn_AvisosVTO.Location = new System.Drawing.Point(692, 36);
            this.btn_AvisosVTO.Name = "btn_AvisosVTO";
            this.btn_AvisosVTO.Size = new System.Drawing.Size(164, 32);
            this.btn_AvisosVTO.TabIndex = 14;
            this.btn_AvisosVTO.Text = "Avisos de Vencimiento";
            this.btn_AvisosVTO.UseVisualStyleBackColor = true;
            this.btn_AvisosVTO.Click += new System.EventHandler(this.btn_AvisosVTO_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(913, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Vaciar DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Clientes
            // 
            this.btn_Clientes.Location = new System.Drawing.Point(12, 86);
            this.btn_Clientes.Name = "btn_Clientes";
            this.btn_Clientes.Size = new System.Drawing.Size(164, 32);
            this.btn_Clientes.TabIndex = 16;
            this.btn_Clientes.Text = "Clientes...";
            this.btn_Clientes.UseVisualStyleBackColor = true;
            this.btn_Clientes.Click += new System.EventHandler(this.btn_Clientes_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(52, 23);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(119, 20);
            this.tb_password.TabIndex = 17;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pass";
            // 
            // btn_okvaciar
            // 
            this.btn_okvaciar.Location = new System.Drawing.Point(81, 49);
            this.btn_okvaciar.Name = "btn_okvaciar";
            this.btn_okvaciar.Size = new System.Drawing.Size(90, 35);
            this.btn_okvaciar.TabIndex = 10;
            this.btn_okvaciar.Text = "ok";
            this.btn_okvaciar.UseVisualStyleBackColor = true;
            this.btn_okvaciar.Click += new System.EventHandler(this.btn_okvaciar_Click);
            // 
            // gb_Vaciar
            // 
            this.gb_Vaciar.Controls.Add(this.tb_password);
            this.gb_Vaciar.Controls.Add(this.btn_okvaciar);
            this.gb_Vaciar.Controls.Add(this.label3);
            this.gb_Vaciar.Location = new System.Drawing.Point(791, 74);
            this.gb_Vaciar.Name = "gb_Vaciar";
            this.gb_Vaciar.Size = new System.Drawing.Size(196, 90);
            this.gb_Vaciar.TabIndex = 18;
            this.gb_Vaciar.TabStop = false;
            this.gb_Vaciar.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1005, 523);
            this.Controls.Add(this.gb_Vaciar);
            this.Controls.Add(this.btn_Clientes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_AvisosVTO);
            this.Controls.Add(this.btn_ActualizarRendidos);
            this.Controls.Add(this.gb_Interfaces);
            this.Controls.Add(this.btn_Interfaces);
            this.Controls.Add(this.btn_GenerarPlanillas);
            this.Controls.Add(this.btn_AgregarRecibos);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interface Parana Seguros";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gb_Interfaces.ResumeLayout(false);
            this.gb_Interfaces.PerformLayout();
            this.gb_Vaciar.ResumeLayout(false);
            this.gb_Vaciar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btn_AgregarRecibos;
        private System.Windows.Forms.Label lbl_path_Cobranzas;
        private System.Windows.Forms.Button btn_Examinar_2;
        private System.Windows.Forms.Button btn_Procesar_Cobranzas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_GenerarPlanillas;
        private System.Windows.Forms.Button btn_Interfaces;
        private System.Windows.Forms.GroupBox gb_Interfaces;
        private System.Windows.Forms.Button btn_ActualizarRendidos;
        private System.Windows.Forms.Button btn_AvisosVTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Clientes;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_okvaciar;
        private System.Windows.Forms.GroupBox gb_Vaciar;
    }
}

