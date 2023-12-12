
namespace Interface_ParanaSeguros.Views
{
    partial class PolizasForm
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
            this.cboxFiltroMostrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.dgvEndosos = new System.Windows.Forms.DataGridView();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.radio_DNI = new System.Windows.Forms.RadioButton();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.radio_ApellidoNombre = new System.Windows.Forms.RadioButton();
            this.radioPatente = new System.Windows.Forms.RadioButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btn_Cupones = new System.Windows.Forms.Button();
            this.btn_Certificado = new System.Windows.Forms.Button();
            this.gbox_Botones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndosos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.gb_filtro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.gbox_Botones.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboxFiltroMostrar
            // 
            this.cboxFiltroMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFiltroMostrar.FormattingEnabled = true;
            this.cboxFiltroMostrar.Items.AddRange(new object[] {
            "Todas",
            "Emitidas",
            "Vigentes",
            "Vencidas",
            "Anuladas"});
            this.cboxFiltroMostrar.Location = new System.Drawing.Point(677, 30);
            this.cboxFiltroMostrar.Name = "cboxFiltroMostrar";
            this.cboxFiltroMostrar.Size = new System.Drawing.Size(207, 28);
            this.cboxFiltroMostrar.TabIndex = 31;
            this.cboxFiltroMostrar.Text = "Todas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mostrar solo";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvPolizas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEndosos);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 238);
            this.splitContainer1.SplitterDistance = 602;
            this.splitContainer1.TabIndex = 2;
            // 
            // dgvPolizas
            // 
            this.dgvPolizas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPolizas.Location = new System.Drawing.Point(0, 0);
            this.dgvPolizas.MultiSelect = false;
            this.dgvPolizas.Name = "dgvPolizas";
            this.dgvPolizas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPolizas.Size = new System.Drawing.Size(602, 238);
            this.dgvPolizas.TabIndex = 4;
            this.dgvPolizas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPolizas_CellClick);
            // 
            // dgvEndosos
            // 
            this.dgvEndosos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEndosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEndosos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEndosos.Location = new System.Drawing.Point(0, 0);
            this.dgvEndosos.MultiSelect = false;
            this.dgvEndosos.Name = "dgvEndosos";
            this.dgvEndosos.ReadOnly = true;
            this.dgvEndosos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEndosos.Size = new System.Drawing.Size(418, 238);
            this.dgvEndosos.TabIndex = 5;
            this.dgvEndosos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEndosos_CellClick);
            // 
            // dgvPagos
            // 
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPagos.Location = new System.Drawing.Point(0, 0);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(518, 125);
            this.dgvPagos.TabIndex = 1;
            this.dgvPagos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagos_CellClick);
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.radioPatente);
            this.gb_filtro.Controls.Add(this.radio_ApellidoNombre);
            this.gb_filtro.Controls.Add(this.tb_filtro);
            this.gb_filtro.Controls.Add(this.radio_DNI);
            this.gb_filtro.Controls.Add(this.btn_filtrar);
            this.gb_filtro.Location = new System.Drawing.Point(12, 12);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(518, 80);
            this.gb_filtro.TabIndex = 30;
            this.gb_filtro.TabStop = false;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.Location = new System.Drawing.Point(407, 42);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(96, 32);
            this.btn_filtrar.TabIndex = 17;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // radio_DNI
            // 
            this.radio_DNI.AutoSize = true;
            this.radio_DNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_DNI.Location = new System.Drawing.Point(202, 12);
            this.radio_DNI.Name = "radio_DNI";
            this.radio_DNI.Size = new System.Drawing.Size(55, 24);
            this.radio_DNI.TabIndex = 15;
            this.radio_DNI.Text = "DNI";
            this.radio_DNI.UseVisualStyleBackColor = true;
            // 
            // tb_filtro
            // 
            this.tb_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filtro.Location = new System.Drawing.Point(28, 48);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(262, 26);
            this.tb_filtro.TabIndex = 13;
            this.tb_filtro.Text = "Buscar...";
            this.tb_filtro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_filtro_MouseClick);
            this.tb_filtro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_filtro_KeyPress);
            // 
            // radio_ApellidoNombre
            // 
            this.radio_ApellidoNombre.AutoSize = true;
            this.radio_ApellidoNombre.Checked = true;
            this.radio_ApellidoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_ApellidoNombre.Location = new System.Drawing.Point(28, 12);
            this.radio_ApellidoNombre.Name = "radio_ApellidoNombre";
            this.radio_ApellidoNombre.Size = new System.Drawing.Size(154, 24);
            this.radio_ApellidoNombre.TabIndex = 14;
            this.radio_ApellidoNombre.TabStop = true;
            this.radio_ApellidoNombre.Text = "Apellido y Nombre";
            this.radio_ApellidoNombre.UseVisualStyleBackColor = true;
            // 
            // radioPatente
            // 
            this.radioPatente.AutoSize = true;
            this.radioPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPatente.Location = new System.Drawing.Point(318, 12);
            this.radioPatente.Name = "radioPatente";
            this.radioPatente.Size = new System.Drawing.Size(83, 24);
            this.radioPatente.TabIndex = 18;
            this.radioPatente.Text = "Patente";
            this.radioPatente.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(12, 98);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1024, 367);
            this.splitContainer2.SplitterDistance = 238;
            this.splitContainer2.TabIndex = 33;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.dgvPagos);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.gbox_Botones);
            this.splitContainer3.Size = new System.Drawing.Size(1024, 125);
            this.splitContainer3.SplitterDistance = 518;
            this.splitContainer3.TabIndex = 34;
            // 
            // btn_Cupones
            // 
            this.btn_Cupones.Enabled = false;
            this.btn_Cupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cupones.Location = new System.Drawing.Point(6, 19);
            this.btn_Cupones.Name = "btn_Cupones";
            this.btn_Cupones.Size = new System.Drawing.Size(96, 32);
            this.btn_Cupones.TabIndex = 18;
            this.btn_Cupones.Text = "Cupones";
            this.btn_Cupones.UseVisualStyleBackColor = true;
            this.btn_Cupones.Click += new System.EventHandler(this.btn_Cupones_Click);
            // 
            // btn_Certificado
            // 
            this.btn_Certificado.Enabled = false;
            this.btn_Certificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Certificado.Location = new System.Drawing.Point(6, 57);
            this.btn_Certificado.Name = "btn_Certificado";
            this.btn_Certificado.Size = new System.Drawing.Size(96, 32);
            this.btn_Certificado.TabIndex = 19;
            this.btn_Certificado.Text = "Certificado";
            this.btn_Certificado.UseVisualStyleBackColor = true;
            this.btn_Certificado.Click += new System.EventHandler(this.btn_Certificado_Click);
            // 
            // gbox_Botones
            // 
            this.gbox_Botones.Controls.Add(this.btn_Certificado);
            this.gbox_Botones.Controls.Add(this.btn_Cupones);
            this.gbox_Botones.Location = new System.Drawing.Point(3, 3);
            this.gbox_Botones.Name = "gbox_Botones";
            this.gbox_Botones.Size = new System.Drawing.Size(492, 119);
            this.gbox_Botones.TabIndex = 34;
            this.gbox_Botones.TabStop = false;
            // 
            // PolizasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.gb_filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxFiltroMostrar);
            this.Name = "PolizasForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PolizasForm";
            this.Load += new System.EventHandler(this.PolizasForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndosos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.gbox_Botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxFiltroMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.DataGridView dgvEndosos;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.RadioButton radioPatente;
        private System.Windows.Forms.RadioButton radio_ApellidoNombre;
        private System.Windows.Forms.TextBox tb_filtro;
        private System.Windows.Forms.RadioButton radio_DNI;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.GroupBox gbox_Botones;
        private System.Windows.Forms.Button btn_Certificado;
        private System.Windows.Forms.Button btn_Cupones;
    }
}