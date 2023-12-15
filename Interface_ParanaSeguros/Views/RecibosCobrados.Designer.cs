
namespace Interface_ParanaSeguros.Views
{
    partial class RecibosCobrados
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_VerTodos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_MarcarRendidos = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_ProcesarPlanilla = new System.Windows.Forms.Button();
            this.linklabel_Path = new System.Windows.Forms.LinkLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_contador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv.Location = new System.Drawing.Point(3, 31);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1159, 498);
            this.dgv.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1165, 532);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recibos Ingresados";
            // 
            // btn_VerTodos
            // 
            this.btn_VerTodos.Location = new System.Drawing.Point(12, 12);
            this.btn_VerTodos.Name = "btn_VerTodos";
            this.btn_VerTodos.Size = new System.Drawing.Size(130, 23);
            this.btn_VerTodos.TabIndex = 3;
            this.btn_VerTodos.Text = "Ver Todos";
            this.btn_VerTodos.UseVisualStyleBackColor = true;
            this.btn_VerTodos.Click += new System.EventHandler(this.btn_VerTodos_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fuera de Convenio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_MarcarRendidos
            // 
            this.btn_MarcarRendidos.Enabled = false;
            this.btn_MarcarRendidos.Location = new System.Drawing.Point(674, 106);
            this.btn_MarcarRendidos.Name = "btn_MarcarRendidos";
            this.btn_MarcarRendidos.Size = new System.Drawing.Size(130, 23);
            this.btn_MarcarRendidos.TabIndex = 5;
            this.btn_MarcarRendidos.Text = "Marcar como rendidos";
            this.btn_MarcarRendidos.UseVisualStyleBackColor = true;
            this.btn_MarcarRendidos.Click += new System.EventHandler(this.btn_MarcarRendidos_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.Location = new System.Drawing.Point(1066, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(87, 23);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_ProcesarPlanilla
            // 
            this.btn_ProcesarPlanilla.Location = new System.Drawing.Point(179, 76);
            this.btn_ProcesarPlanilla.Name = "btn_ProcesarPlanilla";
            this.btn_ProcesarPlanilla.Size = new System.Drawing.Size(130, 23);
            this.btn_ProcesarPlanilla.TabIndex = 9;
            this.btn_ProcesarPlanilla.Text = "Procesar Planilla";
            this.btn_ProcesarPlanilla.UseVisualStyleBackColor = true;
            this.btn_ProcesarPlanilla.Click += new System.EventHandler(this.btn_ProcesarPlanilla_Click);
            // 
            // linklabel_Path
            // 
            this.linklabel_Path.AutoSize = true;
            this.linklabel_Path.Location = new System.Drawing.Point(196, 111);
            this.linklabel_Path.Name = "linklabel_Path";
            this.linklabel_Path.Size = new System.Drawing.Size(16, 13);
            this.linklabel_Path.TabIndex = 10;
            this.linklabel_Path.TabStop = true;
            this.linklabel_Path.Text = "...";
            this.linklabel_Path.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklabel_Path_LinkClicked);
            // 
            // lbl_contador
            // 
            this.lbl_contador.AutoSize = true;
            this.lbl_contador.Location = new System.Drawing.Point(844, 119);
            this.lbl_contador.Name = "lbl_contador";
            this.lbl_contador.Size = new System.Drawing.Size(49, 13);
            this.lbl_contador.TabIndex = 11;
            this.lbl_contador.Text = "contador";
            // 
            // RecibosCobrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1165, 667);
            this.Controls.Add(this.lbl_contador);
            this.Controls.Add(this.linklabel_Path);
            this.Controls.Add(this.btn_ProcesarPlanilla);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_MarcarRendidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_VerTodos);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecibosCobrados";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecibosCobrados";
            this.Load += new System.EventHandler(this.RecibosCobrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_VerTodos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_MarcarRendidos;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_ProcesarPlanilla;
        private System.Windows.Forms.LinkLabel linklabel_Path;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_contador;
    }
}