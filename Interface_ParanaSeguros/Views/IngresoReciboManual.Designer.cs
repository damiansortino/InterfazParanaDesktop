
namespace Interface_ParanaSeguros.Views
{
    partial class IngresoReciboManual
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
            this.tb_Poliza = new System.Windows.Forms.TextBox();
            this.cb_Endoso = new System.Windows.Forms.ComboBox();
            this.cb_Cuota = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lbl_Riesgo = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Poliza
            // 
            this.tb_Poliza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Poliza.Location = new System.Drawing.Point(15, 64);
            this.tb_Poliza.Name = "tb_Poliza";
            this.tb_Poliza.Size = new System.Drawing.Size(162, 29);
            this.tb_Poliza.TabIndex = 0;
            this.tb_Poliza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Poliza_KeyPress);
            // 
            // cb_Endoso
            // 
            this.cb_Endoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Endoso.FormattingEnabled = true;
            this.cb_Endoso.Location = new System.Drawing.Point(183, 64);
            this.cb_Endoso.Name = "cb_Endoso";
            this.cb_Endoso.Size = new System.Drawing.Size(156, 32);
            this.cb_Endoso.TabIndex = 3;
            this.cb_Endoso.DataSourceChanged += new System.EventHandler(this.cb_Endoso_DataSourceChanged);
            this.cb_Endoso.SelectedValueChanged += new System.EventHandler(this.cb_Endoso_SelectedValueChanged);
            // 
            // cb_Cuota
            // 
            this.cb_Cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cuota.FormattingEnabled = true;
            this.cb_Cuota.Location = new System.Drawing.Point(353, 64);
            this.cb_Cuota.Name = "cb_Cuota";
            this.cb_Cuota.Size = new System.Drawing.Size(131, 32);
            this.cb_Cuota.TabIndex = 4;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(12, 122);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(103, 24);
            this.lblCliente.TabIndex = 5;
            this.lblCliente.Text = "Asegurado";
            // 
            // lbl_Riesgo
            // 
            this.lbl_Riesgo.AutoSize = true;
            this.lbl_Riesgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Riesgo.Location = new System.Drawing.Point(12, 173);
            this.lbl_Riesgo.Name = "lbl_Riesgo";
            this.lbl_Riesgo.Size = new System.Drawing.Size(69, 24);
            this.lbl_Riesgo.TabIndex = 6;
            this.lbl_Riesgo.Text = "Riesgo";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImporte.Location = new System.Drawing.Point(521, 67);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(73, 24);
            this.lblImporte.TabIndex = 7;
            this.lblImporte.Text = "Importe";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(321, 221);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 43);
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.Text = "Agregar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(493, 221);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(101, 43);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Póliza";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(179, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Endoso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cuota";
            // 
            // IngresoReciboManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 283);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lbl_Riesgo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cb_Cuota);
            this.Controls.Add(this.cb_Endoso);
            this.Controls.Add(this.tb_Poliza);
            this.Name = "IngresoReciboManual";
            this.Text = "IngresoReciboManual";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Poliza;
        private System.Windows.Forms.ComboBox cb_Endoso;
        private System.Windows.Forms.ComboBox cb_Cuota;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lbl_Riesgo;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}