
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
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvPolizas = new System.Windows.Forms.DataGridView();
            this.dgvEndosos = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.radioPatente = new System.Windows.Forms.RadioButton();
            this.radio_ApellidoNombre = new System.Windows.Forms.RadioButton();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.radio_DNI = new System.Windows.Forms.RadioButton();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.cboxFiltroMostrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndosos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.gb_filtro.SuspendLayout();
            this.SuspendLayout();
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
            this.dgvPagos.Size = new System.Drawing.Size(1218, 129);
            this.dgvPagos.TabIndex = 1;
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
            this.splitContainer1.Size = new System.Drawing.Size(1218, 153);
            this.splitContainer1.SplitterDistance = 633;
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
            this.dgvPolizas.Size = new System.Drawing.Size(633, 153);
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
            this.dgvEndosos.Size = new System.Drawing.Size(581, 153);
            this.dgvEndosos.TabIndex = 5;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(0, 141);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvPagos);
            this.splitContainer2.Size = new System.Drawing.Size(1218, 286);
            this.splitContainer2.SplitterDistance = 153;
            this.splitContainer2.TabIndex = 3;
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.radioPatente);
            this.gb_filtro.Controls.Add(this.radio_ApellidoNombre);
            this.gb_filtro.Controls.Add(this.tb_filtro);
            this.gb_filtro.Controls.Add(this.radio_DNI);
            this.gb_filtro.Controls.Add(this.btn_filtrar);
            this.gb_filtro.Location = new System.Drawing.Point(0, 55);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(518, 80);
            this.gb_filtro.TabIndex = 30;
            this.gb_filtro.TabStop = false;
            // 
            // radioPatente
            // 
            this.radioPatente.AutoSize = true;
            this.radioPatente.Location = new System.Drawing.Point(318, 19);
            this.radioPatente.Name = "radioPatente";
            this.radioPatente.Size = new System.Drawing.Size(62, 17);
            this.radioPatente.TabIndex = 18;
            this.radioPatente.Text = "Patente";
            this.radioPatente.UseVisualStyleBackColor = true;
            // 
            // radio_ApellidoNombre
            // 
            this.radio_ApellidoNombre.AutoSize = true;
            this.radio_ApellidoNombre.Checked = true;
            this.radio_ApellidoNombre.Location = new System.Drawing.Point(28, 19);
            this.radio_ApellidoNombre.Name = "radio_ApellidoNombre";
            this.radio_ApellidoNombre.Size = new System.Drawing.Size(110, 17);
            this.radio_ApellidoNombre.TabIndex = 14;
            this.radio_ApellidoNombre.TabStop = true;
            this.radio_ApellidoNombre.Text = "Apellido y Nombre";
            this.radio_ApellidoNombre.UseVisualStyleBackColor = true;
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
            // radio_DNI
            // 
            this.radio_DNI.AutoSize = true;
            this.radio_DNI.Location = new System.Drawing.Point(202, 19);
            this.radio_DNI.Name = "radio_DNI";
            this.radio_DNI.Size = new System.Drawing.Size(44, 17);
            this.radio_DNI.TabIndex = 15;
            this.radio_DNI.Text = "DNI";
            this.radio_DNI.UseVisualStyleBackColor = true;
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
            // cboxFiltroMostrar
            // 
            this.cboxFiltroMostrar.FormattingEnabled = true;
            this.cboxFiltroMostrar.Items.AddRange(new object[] {
            "Todas",
            "Emitidas",
            "Vigentes",
            "Vencidas",
            "Anuladas"});
            this.cboxFiltroMostrar.Location = new System.Drawing.Point(637, 73);
            this.cboxFiltroMostrar.Name = "cboxFiltroMostrar";
            this.cboxFiltroMostrar.Size = new System.Drawing.Size(207, 21);
            this.cboxFiltroMostrar.TabIndex = 31;
            this.cboxFiltroMostrar.Text = "Todas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(554, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mostrar solo";
            // 
            // PolizasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 427);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxFiltroMostrar);
            this.Controls.Add(this.gb_filtro);
            this.Controls.Add(this.splitContainer2);
            this.Name = "PolizasForm";
            this.Text = "PolizasForm";
            this.Load += new System.EventHandler(this.PolizasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEndosos)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvPolizas;
        private System.Windows.Forms.DataGridView dgvEndosos;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.RadioButton radioPatente;
        private System.Windows.Forms.RadioButton radio_ApellidoNombre;
        private System.Windows.Forms.TextBox tb_filtro;
        private System.Windows.Forms.RadioButton radio_DNI;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.ComboBox cboxFiltroMostrar;
        private System.Windows.Forms.Label label1;
    }
}