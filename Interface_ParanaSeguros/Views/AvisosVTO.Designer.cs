
namespace Interface_ParanaSeguros.Views
{
    partial class AvisosVTO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvisosVTO));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.gb = new System.Windows.Forms.GroupBox();
            this.btn_Vto7dias = new System.Windows.Forms.Button();
            this.btn_VtoHoy = new System.Windows.Forms.Button();
            this.btn_7diasvencido = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Refacturaciones = new System.Windows.Forms.Button();
            this.btn_Refactu_10dias = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BuscarVtoCuota = new System.Windows.Forms.Button();
            this.dtp_Vto_Cuota = new System.Windows.Forms.DateTimePicker();
            this.text_Mensaje = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EnviarMsjs = new System.Windows.Forms.Button();
            this.btn_ActualizarTelefono = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1074, 213);
            this.dgv.TabIndex = 0;
            this.dgv.Visible = false;
            this.dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_CellFormatting);
            this.dgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_RowsAdded);
            this.dgv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_MouseClick);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.dgv);
            this.gb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb.Location = new System.Drawing.Point(0, 202);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(1080, 232);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Listado";
            // 
            // btn_Vto7dias
            // 
            this.btn_Vto7dias.Location = new System.Drawing.Point(528, 9);
            this.btn_Vto7dias.Name = "btn_Vto7dias";
            this.btn_Vto7dias.Size = new System.Drawing.Size(120, 52);
            this.btn_Vto7dias.TabIndex = 2;
            this.btn_Vto7dias.Text = "Vencimiento próximos 7 días";
            this.btn_Vto7dias.UseVisualStyleBackColor = true;
            this.btn_Vto7dias.Click += new System.EventHandler(this.btn_Vto7dias_Click);
            // 
            // btn_VtoHoy
            // 
            this.btn_VtoHoy.Location = new System.Drawing.Point(396, 9);
            this.btn_VtoHoy.Name = "btn_VtoHoy";
            this.btn_VtoHoy.Size = new System.Drawing.Size(120, 52);
            this.btn_VtoHoy.TabIndex = 3;
            this.btn_VtoHoy.Text = "Vencimientos hoy";
            this.btn_VtoHoy.UseVisualStyleBackColor = true;
            this.btn_VtoHoy.Click += new System.EventHandler(this.btn_VtoHoy_Click);
            // 
            // btn_7diasvencido
            // 
            this.btn_7diasvencido.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_7diasvencido.Location = new System.Drawing.Point(654, 9);
            this.btn_7diasvencido.Name = "btn_7diasvencido";
            this.btn_7diasvencido.Size = new System.Drawing.Size(120, 52);
            this.btn_7diasvencido.TabIndex = 5;
            this.btn_7diasvencido.Text = "7 días vencido";
            this.btn_7diasvencido.UseVisualStyleBackColor = false;
            this.btn_7diasvencido.Click += new System.EventHandler(this.btn_7diasvencido_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.Location = new System.Drawing.Point(1013, 9);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(55, 31);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Refacturaciones
            // 
            this.btn_Refacturaciones.Location = new System.Drawing.Point(185, 12);
            this.btn_Refacturaciones.Name = "btn_Refacturaciones";
            this.btn_Refacturaciones.Size = new System.Drawing.Size(120, 47);
            this.btn_Refacturaciones.TabIndex = 13;
            this.btn_Refacturaciones.Text = "Refacturaciones hoy";
            this.btn_Refacturaciones.UseVisualStyleBackColor = true;
            this.btn_Refacturaciones.Click += new System.EventHandler(this.btn_Refacturaciones_Click);
            // 
            // btn_Refactu_10dias
            // 
            this.btn_Refactu_10dias.Location = new System.Drawing.Point(12, 11);
            this.btn_Refactu_10dias.Name = "btn_Refactu_10dias";
            this.btn_Refactu_10dias.Size = new System.Drawing.Size(120, 48);
            this.btn_Refactu_10dias.TabIndex = 15;
            this.btn_Refactu_10dias.Text = "Refacturaciones 10 dias";
            this.btn_Refactu_10dias.UseVisualStyleBackColor = true;
            this.btn_Refactu_10dias.Click += new System.EventHandler(this.btn_Refactu_10dias_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImage = global::Interface_ParanaSeguros.Properties.Resources.excel;
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcel.Location = new System.Drawing.Point(450, 70);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(66, 70);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(15, 120);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(105, 20);
            this.dtp_fecha.TabIndex = 16;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(135, 118);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(55, 28);
            this.btn_Buscar.TabIndex = 17;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar Refacturaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar Vto. Cuota";
            // 
            // btn_BuscarVtoCuota
            // 
            this.btn_BuscarVtoCuota.Location = new System.Drawing.Point(383, 118);
            this.btn_BuscarVtoCuota.Name = "btn_BuscarVtoCuota";
            this.btn_BuscarVtoCuota.Size = new System.Drawing.Size(55, 28);
            this.btn_BuscarVtoCuota.TabIndex = 20;
            this.btn_BuscarVtoCuota.Text = "Buscar";
            this.btn_BuscarVtoCuota.UseVisualStyleBackColor = true;
            this.btn_BuscarVtoCuota.Click += new System.EventHandler(this.btn_BuscarVtoCuota_Click);
            // 
            // dtp_Vto_Cuota
            // 
            this.dtp_Vto_Cuota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Vto_Cuota.Location = new System.Drawing.Point(263, 120);
            this.dtp_Vto_Cuota.Name = "dtp_Vto_Cuota";
            this.dtp_Vto_Cuota.Size = new System.Drawing.Size(105, 20);
            this.dtp_Vto_Cuota.TabIndex = 19;
            // 
            // text_Mensaje
            // 
            this.text_Mensaje.Location = new System.Drawing.Point(578, 94);
            this.text_Mensaje.Name = "text_Mensaje";
            this.text_Mensaje.Size = new System.Drawing.Size(449, 61);
            this.text_Mensaje.TabIndex = 22;
            this.text_Mensaje.Text = resources.GetString("text_Mensaje.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(575, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mensaje a enviar";
            // 
            // btn_EnviarMsjs
            // 
            this.btn_EnviarMsjs.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_EnviarMsjs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EnviarMsjs.Location = new System.Drawing.Point(578, 161);
            this.btn_EnviarMsjs.Name = "btn_EnviarMsjs";
            this.btn_EnviarMsjs.Size = new System.Drawing.Size(111, 31);
            this.btn_EnviarMsjs.TabIndex = 24;
            this.btn_EnviarMsjs.Text = "Enviar mensajes";
            this.btn_EnviarMsjs.UseVisualStyleBackColor = false;
            this.btn_EnviarMsjs.Click += new System.EventHandler(this.btn_EnviarMsjs_Click);
            // 
            // btn_ActualizarTelefono
            // 
            this.btn_ActualizarTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(237)))), ((int)(((byte)(228)))));
            this.btn_ActualizarTelefono.Location = new System.Drawing.Point(135, 165);
            this.btn_ActualizarTelefono.Name = "btn_ActualizarTelefono";
            this.btn_ActualizarTelefono.Size = new System.Drawing.Size(136, 31);
            this.btn_ActualizarTelefono.TabIndex = 25;
            this.btn_ActualizarTelefono.Text = "actualizar telefono";
            this.btn_ActualizarTelefono.UseVisualStyleBackColor = false;
            this.btn_ActualizarTelefono.Click += new System.EventHandler(this.btn_ActualizarTelefono_Click);
            // 
            // AvisosVTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1080, 434);
            this.Controls.Add(this.btn_ActualizarTelefono);
            this.Controls.Add(this.btn_EnviarMsjs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_Mensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_BuscarVtoCuota);
            this.Controls.Add(this.dtp_Vto_Cuota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.dtp_fecha);
            this.Controls.Add(this.btn_Refactu_10dias);
            this.Controls.Add(this.btn_Refacturaciones);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_7diasvencido);
            this.Controls.Add(this.btn_VtoHoy);
            this.Controls.Add(this.btn_Vto7dias);
            this.Controls.Add(this.gb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AvisosVTO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AvisosVTO";
            this.Load += new System.EventHandler(this.AvisosVTO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.gb.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.Button btn_Vto7dias;
        private System.Windows.Forms.Button btn_VtoHoy;
        private System.Windows.Forms.Button btn_7diasvencido;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btn_Refacturaciones;
        private System.Windows.Forms.Button btn_Refactu_10dias;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BuscarVtoCuota;
        private System.Windows.Forms.DateTimePicker dtp_Vto_Cuota;
        private System.Windows.Forms.RichTextBox text_Mensaje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_EnviarMsjs;
        private System.Windows.Forms.Button btn_ActualizarTelefono;
    }
}