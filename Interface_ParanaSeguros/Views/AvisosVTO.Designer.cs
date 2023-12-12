
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
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
            this.btn_Tildar = new System.Windows.Forms.Button();
            this.btn_Destildar = new System.Windows.Forms.Button();
            this.lbl_Avisos = new System.Windows.Forms.Label();
            this.btn_EnviarDirectamente = new System.Windows.Forms.Button();
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
            this.gb.Location = new System.Drawing.Point(0, 297);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(1080, 232);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Listado";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.Location = new System.Drawing.Point(998, 9);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(70, 31);
            this.btn_Cerrar.TabIndex = 10;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(28, 59);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(145, 29);
            this.dtp_fecha.TabIndex = 16;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.Location = new System.Drawing.Point(222, 55);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(89, 40);
            this.btn_Buscar.TabIndex = 17;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Buscar Refacturaciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Buscar Vto. Cuota";
            // 
            // btn_BuscarVtoCuota
            // 
            this.btn_BuscarVtoCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarVtoCuota.Location = new System.Drawing.Point(222, 155);
            this.btn_BuscarVtoCuota.Name = "btn_BuscarVtoCuota";
            this.btn_BuscarVtoCuota.Size = new System.Drawing.Size(89, 41);
            this.btn_BuscarVtoCuota.TabIndex = 20;
            this.btn_BuscarVtoCuota.Text = "Buscar";
            this.btn_BuscarVtoCuota.UseVisualStyleBackColor = true;
            this.btn_BuscarVtoCuota.Click += new System.EventHandler(this.btn_BuscarVtoCuota_Click);
            // 
            // dtp_Vto_Cuota
            // 
            this.dtp_Vto_Cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Vto_Cuota.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Vto_Cuota.Location = new System.Drawing.Point(26, 159);
            this.dtp_Vto_Cuota.Name = "dtp_Vto_Cuota";
            this.dtp_Vto_Cuota.Size = new System.Drawing.Size(147, 29);
            this.dtp_Vto_Cuota.TabIndex = 19;
            // 
            // text_Mensaje
            // 
            this.text_Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Mensaje.Location = new System.Drawing.Point(578, 94);
            this.text_Mensaje.Name = "text_Mensaje";
            this.text_Mensaje.Size = new System.Drawing.Size(449, 108);
            this.text_Mensaje.TabIndex = 22;
            this.text_Mensaje.Text = resources.GetString("text_Mensaje.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mensaje a enviar";
            // 
            // btn_EnviarMsjs
            // 
            this.btn_EnviarMsjs.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_EnviarMsjs.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EnviarMsjs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarMsjs.Location = new System.Drawing.Point(578, 223);
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
            this.btn_ActualizarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarTelefono.Location = new System.Drawing.Point(5, 260);
            this.btn_ActualizarTelefono.Name = "btn_ActualizarTelefono";
            this.btn_ActualizarTelefono.Size = new System.Drawing.Size(241, 31);
            this.btn_ActualizarTelefono.TabIndex = 25;
            this.btn_ActualizarTelefono.Text = "actualizar telefono del cliente";
            this.btn_ActualizarTelefono.UseVisualStyleBackColor = false;
            this.btn_ActualizarTelefono.Click += new System.EventHandler(this.btn_ActualizarTelefono_Click);
            // 
            // btn_Tildar
            // 
            this.btn_Tildar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tildar.Location = new System.Drawing.Point(804, 260);
            this.btn_Tildar.Name = "btn_Tildar";
            this.btn_Tildar.Size = new System.Drawing.Size(129, 31);
            this.btn_Tildar.TabIndex = 28;
            this.btn_Tildar.Text = "Tildar todos";
            this.btn_Tildar.UseVisualStyleBackColor = true;
            this.btn_Tildar.Click += new System.EventHandler(this.btn_Tildar_Click_1);
            // 
            // btn_Destildar
            // 
            this.btn_Destildar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Destildar.Location = new System.Drawing.Point(939, 260);
            this.btn_Destildar.Name = "btn_Destildar";
            this.btn_Destildar.Size = new System.Drawing.Size(129, 31);
            this.btn_Destildar.TabIndex = 29;
            this.btn_Destildar.Text = "Destildar todos";
            this.btn_Destildar.UseVisualStyleBackColor = true;
            this.btn_Destildar.Click += new System.EventHandler(this.btn_Destildar_Click_1);
            // 
            // lbl_Avisos
            // 
            this.lbl_Avisos.AutoSize = true;
            this.lbl_Avisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Avisos.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_Avisos.Location = new System.Drawing.Point(278, 266);
            this.lbl_Avisos.Name = "lbl_Avisos";
            this.lbl_Avisos.Size = new System.Drawing.Size(71, 24);
            this.lbl_Avisos.TabIndex = 30;
            this.lbl_Avisos.Text = "Avisos";
            // 
            // btn_EnviarDirectamente
            // 
            this.btn_EnviarDirectamente.BackColor = System.Drawing.Color.Gold;
            this.btn_EnviarDirectamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EnviarDirectamente.Location = new System.Drawing.Point(317, 155);
            this.btn_EnviarDirectamente.Name = "btn_EnviarDirectamente";
            this.btn_EnviarDirectamente.Size = new System.Drawing.Size(200, 41);
            this.btn_EnviarDirectamente.TabIndex = 31;
            this.btn_EnviarDirectamente.Text = "Enviar Directamente";
            this.btn_EnviarDirectamente.UseVisualStyleBackColor = false;
            this.btn_EnviarDirectamente.Click += new System.EventHandler(this.btn_EnviarDirectamente_Click);
            // 
            // AvisosVTO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1080, 529);
            this.Controls.Add(this.btn_EnviarDirectamente);
            this.Controls.Add(this.lbl_Avisos);
            this.Controls.Add(this.btn_Destildar);
            this.Controls.Add(this.btn_Tildar);
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
            this.Controls.Add(this.btn_Cerrar);
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
        private System.Windows.Forms.Button btn_Cerrar;
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
        private System.Windows.Forms.Button btn_Tildar;
        private System.Windows.Forms.Button btn_Destildar;
        private System.Windows.Forms.Label lbl_Avisos;
        private System.Windows.Forms.Button btn_EnviarDirectamente;
    }
}