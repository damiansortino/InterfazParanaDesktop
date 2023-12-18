
namespace Interface_ParanaSeguros.Views
{
    partial class FrmCaja
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.btn_IniciarCaja = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1264, 444);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.Location = new System.Drawing.Point(12, 34);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(154, 38);
            this.btn_Cobrar.TabIndex = 1;
            this.btn_Cobrar.Text = "1 - Cobrar";
            this.btn_Cobrar.UseVisualStyleBackColor = true;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // btn_IniciarCaja
            // 
            this.btn_IniciarCaja.Location = new System.Drawing.Point(12, 78);
            this.btn_IniciarCaja.Name = "btn_IniciarCaja";
            this.btn_IniciarCaja.Size = new System.Drawing.Size(154, 38);
            this.btn_IniciarCaja.TabIndex = 2;
            this.btn_IniciarCaja.Text = "2 - Iniciar Caja";
            this.btn_IniciarCaja.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "4 - Retiro";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 38);
            this.button4.TabIndex = 3;
            this.button4.Text = "3 - Cerrar Caja";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "5 - Otros Movimientos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 749);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_IniciarCaja);
            this.Controls.Add(this.btn_Cobrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cobrar;
        private System.Windows.Forms.Button btn_IniciarCaja;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}