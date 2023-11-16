
namespace Interface_ParanaSeguros.Views
{
    partial class Interfaces_Parana
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
            this.gb_Interfaces = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.lblpath = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Procesar_Cobranzas = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lbl_path_Cobranzas = new System.Windows.Forms.Label();
            this.btn_Examinar_2 = new System.Windows.Forms.Button();
            this.gb_Interfaces.SuspendLayout();
            this.SuspendLayout();
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
            this.gb_Interfaces.Location = new System.Drawing.Point(12, 30);
            this.gb_Interfaces.Name = "gb_Interfaces";
            this.gb_Interfaces.Size = new System.Drawing.Size(831, 306);
            this.gb_Interfaces.TabIndex = 13;
            this.gb_Interfaces.TabStop = false;
            this.gb_Interfaces.Text = "Interfaces";
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
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(25, 76);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "COBRANZAS";
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
            // 
            // Interfaces_Parana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 353);
            this.Controls.Add(this.gb_Interfaces);
            this.Name = "Interfaces_Parana";
            this.Text = "Interfaces_Parana";
            this.Load += new System.EventHandler(this.Interfaces_Parana_Load);
            this.gb_Interfaces.ResumeLayout(false);
            this.gb_Interfaces.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Interfaces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Procesar_Cobranzas;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lbl_path_Cobranzas;
        private System.Windows.Forms.Button btn_Examinar_2;
    }
}