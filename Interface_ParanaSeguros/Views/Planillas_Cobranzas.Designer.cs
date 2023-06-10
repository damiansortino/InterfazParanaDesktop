
namespace Interface_ParanaSeguros.Views
{
    partial class Planillas_Cobranzas
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
            this.btn_Cobrados = new System.Windows.Forms.Button();
            this.btn_ProxConvenio = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Suma = new System.Windows.Forms.Label();
            this.lbl_CantidadRecibos = new System.Windows.Forms.Label();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.radio_poliza = new System.Windows.Forms.RadioButton();
            this.radio_cliente = new System.Windows.Forms.RadioButton();
            this.radio_patente = new System.Windows.Forms.RadioButton();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_fdc = new System.Windows.Forms.Button();
            this.btn_GenerarPlanilla = new System.Windows.Forms.Button();
            this.btn_UltimasCuotas = new System.Windows.Forms.Button();
            this.btn_menos3 = new System.Windows.Forms.Button();
            this.btn_menos1 = new System.Windows.Forms.Button();
            this.btn_menos10 = new System.Windows.Forms.Button();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cobrados
            // 
            this.btn_Cobrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Cobrados.Location = new System.Drawing.Point(14, 28);
            this.btn_Cobrados.Name = "btn_Cobrados";
            this.btn_Cobrados.Size = new System.Drawing.Size(148, 23);
            this.btn_Cobrados.TabIndex = 0;
            this.btn_Cobrados.Text = "Recibos Cobrados";
            this.btn_Cobrados.UseVisualStyleBackColor = false;
            this.btn_Cobrados.Click += new System.EventHandler(this.btn_Cobrados_Click);
            // 
            // btn_ProxConvenio
            // 
            this.btn_ProxConvenio.BackColor = System.Drawing.Color.Yellow;
            this.btn_ProxConvenio.Location = new System.Drawing.Point(14, 70);
            this.btn_ProxConvenio.Name = "btn_ProxConvenio";
            this.btn_ProxConvenio.Size = new System.Drawing.Size(148, 23);
            this.btn_ProxConvenio.TabIndex = 1;
            this.btn_ProxConvenio.Text = "Vto Próximo Convenio";
            this.btn_ProxConvenio.UseVisualStyleBackColor = false;
            this.btn_ProxConvenio.Click += new System.EventHandler(this.btn_ProxConvenio_Click);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 16);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1055, 399);
            this.dgv.TabIndex = 4;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 418);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Planilla";
            this.groupBox1.Visible = false;
            // 
            // lbl_Suma
            // 
            this.lbl_Suma.AutoSize = true;
            this.lbl_Suma.Location = new System.Drawing.Point(796, 57);
            this.lbl_Suma.Name = "lbl_Suma";
            this.lbl_Suma.Size = new System.Drawing.Size(61, 13);
            this.lbl_Suma.TabIndex = 11;
            this.lbl_Suma.Text = "Suma Total";
            // 
            // lbl_CantidadRecibos
            // 
            this.lbl_CantidadRecibos.AutoSize = true;
            this.lbl_CantidadRecibos.Location = new System.Drawing.Point(796, 102);
            this.lbl_CantidadRecibos.Name = "lbl_CantidadRecibos";
            this.lbl_CantidadRecibos.Size = new System.Drawing.Size(106, 13);
            this.lbl_CantidadRecibos.TabIndex = 12;
            this.lbl_CantidadRecibos.Text = "Cantidad de Recibos";
            // 
            // tb_filtro
            // 
            this.tb_filtro.Location = new System.Drawing.Point(41, 56);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(178, 20);
            this.tb_filtro.TabIndex = 13;
            this.tb_filtro.Text = "Buscar...";
            this.tb_filtro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_filtro_MouseClick);
            this.tb_filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_filtro_KeyPress);
            // 
            // radio_poliza
            // 
            this.radio_poliza.AutoSize = true;
            this.radio_poliza.Checked = true;
            this.radio_poliza.Location = new System.Drawing.Point(9, 19);
            this.radio_poliza.Name = "radio_poliza";
            this.radio_poliza.Size = new System.Drawing.Size(53, 17);
            this.radio_poliza.TabIndex = 14;
            this.radio_poliza.TabStop = true;
            this.radio_poliza.Text = "Póliza";
            this.radio_poliza.UseVisualStyleBackColor = true;
            // 
            // radio_cliente
            // 
            this.radio_cliente.AutoSize = true;
            this.radio_cliente.Location = new System.Drawing.Point(117, 19);
            this.radio_cliente.Name = "radio_cliente";
            this.radio_cliente.Size = new System.Drawing.Size(57, 17);
            this.radio_cliente.TabIndex = 15;
            this.radio_cliente.Text = "Cliente";
            this.radio_cliente.UseVisualStyleBackColor = true;
            // 
            // radio_patente
            // 
            this.radio_patente.AutoSize = true;
            this.radio_patente.Location = new System.Drawing.Point(225, 19);
            this.radio_patente.Name = "radio_patente";
            this.radio_patente.Size = new System.Drawing.Size(62, 17);
            this.radio_patente.TabIndex = 16;
            this.radio_patente.Text = "Patente";
            this.radio_patente.UseVisualStyleBackColor = true;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(238, 54);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(75, 23);
            this.btn_filtrar.TabIndex = 17;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // btn_fdc
            // 
            this.btn_fdc.BackColor = System.Drawing.Color.Red;
            this.btn_fdc.Location = new System.Drawing.Point(14, 111);
            this.btn_fdc.Name = "btn_fdc";
            this.btn_fdc.Size = new System.Drawing.Size(148, 23);
            this.btn_fdc.TabIndex = 18;
            this.btn_fdc.Text = "Fuera de Convenio";
            this.btn_fdc.UseVisualStyleBackColor = false;
            this.btn_fdc.Click += new System.EventHandler(this.btn_fdc_Click);
            // 
            // btn_GenerarPlanilla
            // 
            this.btn_GenerarPlanilla.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_GenerarPlanilla.Location = new System.Drawing.Point(459, 176);
            this.btn_GenerarPlanilla.Name = "btn_GenerarPlanilla";
            this.btn_GenerarPlanilla.Size = new System.Drawing.Size(139, 23);
            this.btn_GenerarPlanilla.TabIndex = 22;
            this.btn_GenerarPlanilla.Text = "Generar Planilla";
            this.btn_GenerarPlanilla.UseVisualStyleBackColor = false;
            this.btn_GenerarPlanilla.Click += new System.EventHandler(this.btn_GenerarPlanilla_Click);
            // 
            // btn_UltimasCuotas
            // 
            this.btn_UltimasCuotas.BackColor = System.Drawing.Color.Yellow;
            this.btn_UltimasCuotas.Location = new System.Drawing.Point(168, 70);
            this.btn_UltimasCuotas.Name = "btn_UltimasCuotas";
            this.btn_UltimasCuotas.Size = new System.Drawing.Size(148, 23);
            this.btn_UltimasCuotas.TabIndex = 24;
            this.btn_UltimasCuotas.Text = "Ultimas Cuotas";
            this.btn_UltimasCuotas.UseVisualStyleBackColor = false;
            this.btn_UltimasCuotas.Click += new System.EventHandler(this.btn_UltimasCuotas_Click);
            // 
            // btn_menos3
            // 
            this.btn_menos3.BackColor = System.Drawing.Color.Yellow;
            this.btn_menos3.Location = new System.Drawing.Point(415, 70);
            this.btn_menos3.Name = "btn_menos3";
            this.btn_menos3.Size = new System.Drawing.Size(83, 23);
            this.btn_menos3.TabIndex = 25;
            this.btn_menos3.Text = "-3K";
            this.btn_menos3.UseVisualStyleBackColor = false;
            this.btn_menos3.Click += new System.EventHandler(this.btn_menos3_Click);
            // 
            // btn_menos1
            // 
            this.btn_menos1.BackColor = System.Drawing.Color.Yellow;
            this.btn_menos1.Location = new System.Drawing.Point(322, 70);
            this.btn_menos1.Name = "btn_menos1";
            this.btn_menos1.Size = new System.Drawing.Size(87, 23);
            this.btn_menos1.TabIndex = 26;
            this.btn_menos1.Text = "-1K";
            this.btn_menos1.UseVisualStyleBackColor = false;
            this.btn_menos1.Click += new System.EventHandler(this.btn_menos1_Click);
            // 
            // btn_menos10
            // 
            this.btn_menos10.BackColor = System.Drawing.Color.Yellow;
            this.btn_menos10.Location = new System.Drawing.Point(504, 70);
            this.btn_menos10.Name = "btn_menos10";
            this.btn_menos10.Size = new System.Drawing.Size(83, 23);
            this.btn_menos10.TabIndex = 27;
            this.btn_menos10.Text = "-10K";
            this.btn_menos10.UseVisualStyleBackColor = false;
            this.btn_menos10.Click += new System.EventHandler(this.btn_menos10_Click);
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.radio_poliza);
            this.gb_filtro.Controls.Add(this.tb_filtro);
            this.gb_filtro.Controls.Add(this.radio_cliente);
            this.gb_filtro.Controls.Add(this.radio_patente);
            this.gb_filtro.Controls.Add(this.btn_filtrar);
            this.gb_filtro.Location = new System.Drawing.Point(12, 140);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(319, 80);
            this.gb_filtro.TabIndex = 28;
            this.gb_filtro.TabStop = false;
            this.gb_filtro.Visible = false;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.Location = new System.Drawing.Point(973, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(83, 23);
            this.btn_Cerrar.TabIndex = 29;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Planillas_Cobranzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1061, 644);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.gb_filtro);
            this.Controls.Add(this.btn_menos10);
            this.Controls.Add(this.btn_menos1);
            this.Controls.Add(this.btn_menos3);
            this.Controls.Add(this.btn_UltimasCuotas);
            this.Controls.Add(this.btn_GenerarPlanilla);
            this.Controls.Add(this.btn_fdc);
            this.Controls.Add(this.lbl_CantidadRecibos);
            this.Controls.Add(this.lbl_Suma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ProxConvenio);
            this.Controls.Add(this.btn_Cobrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Planillas_Cobranzas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planillas_Cobranzas";
            this.Load += new System.EventHandler(this.Planillas_Cobranzas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cobrados;
        private System.Windows.Forms.Button btn_ProxConvenio;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Suma;
        private System.Windows.Forms.Label lbl_CantidadRecibos;
        private System.Windows.Forms.TextBox tb_filtro;
        private System.Windows.Forms.RadioButton radio_poliza;
        private System.Windows.Forms.RadioButton radio_cliente;
        private System.Windows.Forms.RadioButton radio_patente;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_fdc;
        private System.Windows.Forms.Button btn_GenerarPlanilla;
        private System.Windows.Forms.Button btn_UltimasCuotas;
        private System.Windows.Forms.Button btn_menos3;
        private System.Windows.Forms.Button btn_menos1;
        private System.Windows.Forms.Button btn_menos10;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}