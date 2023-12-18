
namespace Interface_ParanaSeguros.Views
{
    partial class FrmCobrar_Caja
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_barra = new System.Windows.Forms.TextBox();
            this.gb_noencontro = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_vto = new System.Windows.Forms.Label();
            this.lbl_cuota = new System.Windows.Forms.Label();
            this.lbl_importe = new System.Windows.Forms.Label();
            this.lbl_endoso_suplemento = new System.Windows.Forms.Label();
            this.lbl_poliza_asociada = new System.Windows.Forms.Label();
            this.lbl_Rama = new System.Windows.Forms.Label();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.btn_Ok_Recibo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_agregados = new System.Windows.Forms.DataGridView();
            this.gb_noencontro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Cobro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese barra";
            // 
            // tb_barra
            // 
            this.tb_barra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_barra.Location = new System.Drawing.Point(146, 50);
            this.tb_barra.Name = "tb_barra";
            this.tb_barra.Size = new System.Drawing.Size(481, 29);
            this.tb_barra.TabIndex = 2;
            this.tb_barra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_barra_KeyPress);
            // 
            // gb_noencontro
            // 
            this.gb_noencontro.Controls.Add(this.label21);
            this.gb_noencontro.Controls.Add(this.label17);
            this.gb_noencontro.Controls.Add(this.label20);
            this.gb_noencontro.Controls.Add(this.label19);
            this.gb_noencontro.Controls.Add(this.label18);
            this.gb_noencontro.Location = new System.Drawing.Point(440, 107);
            this.gb_noencontro.Name = "gb_noencontro";
            this.gb_noencontro.Size = new System.Drawing.Size(412, 181);
            this.gb_noencontro.TabIndex = 3;
            this.gb_noencontro.TabStop = false;
            this.gb_noencontro.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.YellowGreen;
            this.label21.Location = new System.Drawing.Point(6, 145);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(359, 24);
            this.label21.TabIndex = 31;
            this.label21.Text = "y la información de póliza esté disponible.";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(6, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(213, 24);
            this.label17.TabIndex = 27;
            this.label17.Text = "No se encontró la póliza";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.YellowGreen;
            this.label20.Location = new System.Drawing.Point(6, 116);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(397, 24);
            this.label20.TabIndex = 30;
            this.label20.Text = "cuando realice un nuevo proceso de interface";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.YellowGreen;
            this.label19.Location = new System.Drawing.Point(6, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(344, 24);
            this.label19.TabIndex = 29;
            this.label19.Text = "El sistema completará los datos faltantes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.YellowGreen;
            this.label18.Location = new System.Drawing.Point(6, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(362, 24);
            this.label18.TabIndex = 28;
            this.label18.Text = "Igual puede agregar este recibo a su caja,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Póliza/Asociada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endoso/Suplemento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Importe";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 264);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 24);
            this.label14.TabIndex = 14;
            this.label14.Text = "Cuota";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 24);
            this.label16.TabIndex = 16;
            this.label16.Text = "Vencimiento";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aceptar.Location = new System.Drawing.Point(849, 581);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(125, 41);
            this.btn_aceptar.TabIndex = 18;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(992, 581);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(125, 41);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_vto
            // 
            this.lbl_vto.AutoSize = true;
            this.lbl_vto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vto.Location = new System.Drawing.Point(228, 290);
            this.lbl_vto.Name = "lbl_vto";
            this.lbl_vto.Size = new System.Drawing.Size(116, 24);
            this.lbl_vto.TabIndex = 26;
            this.lbl_vto.Text = "Vencimiento";
            // 
            // lbl_cuota
            // 
            this.lbl_cuota.AutoSize = true;
            this.lbl_cuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuota.Location = new System.Drawing.Point(228, 264);
            this.lbl_cuota.Name = "lbl_cuota";
            this.lbl_cuota.Size = new System.Drawing.Size(59, 24);
            this.lbl_cuota.TabIndex = 25;
            this.lbl_cuota.Text = "Cuota";
            // 
            // lbl_importe
            // 
            this.lbl_importe.AutoSize = true;
            this.lbl_importe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importe.Location = new System.Drawing.Point(228, 237);
            this.lbl_importe.Name = "lbl_importe";
            this.lbl_importe.Size = new System.Drawing.Size(73, 24);
            this.lbl_importe.TabIndex = 24;
            this.lbl_importe.Text = "Importe";
            // 
            // lbl_endoso_suplemento
            // 
            this.lbl_endoso_suplemento.AutoSize = true;
            this.lbl_endoso_suplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_endoso_suplemento.Location = new System.Drawing.Point(228, 206);
            this.lbl_endoso_suplemento.Name = "lbl_endoso_suplemento";
            this.lbl_endoso_suplemento.Size = new System.Drawing.Size(183, 24);
            this.lbl_endoso_suplemento.TabIndex = 23;
            this.lbl_endoso_suplemento.Text = "Endoso/Suplemento";
            // 
            // lbl_poliza_asociada
            // 
            this.lbl_poliza_asociada.AutoSize = true;
            this.lbl_poliza_asociada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poliza_asociada.Location = new System.Drawing.Point(228, 175);
            this.lbl_poliza_asociada.Name = "lbl_poliza_asociada";
            this.lbl_poliza_asociada.Size = new System.Drawing.Size(143, 24);
            this.lbl_poliza_asociada.TabIndex = 22;
            this.lbl_poliza_asociada.Text = "Póliza/Asociada";
            // 
            // lbl_Rama
            // 
            this.lbl_Rama.AutoSize = true;
            this.lbl_Rama.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rama.Location = new System.Drawing.Point(228, 144);
            this.lbl_Rama.Name = "lbl_Rama";
            this.lbl_Rama.Size = new System.Drawing.Size(59, 24);
            this.lbl_Rama.TabIndex = 21;
            this.lbl_Rama.Text = "Rama";
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cliente.Location = new System.Drawing.Point(228, 113);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(68, 24);
            this.lbl_Cliente.TabIndex = 20;
            this.lbl_Cliente.Text = "Cliente";
            // 
            // btn_Ok_Recibo
            // 
            this.btn_Ok_Recibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok_Recibo.Location = new System.Drawing.Point(12, 330);
            this.btn_Ok_Recibo.Name = "btn_Ok_Recibo";
            this.btn_Ok_Recibo.Size = new System.Drawing.Size(112, 40);
            this.btn_Ok_Recibo.TabIndex = 27;
            this.btn_Ok_Recibo.Text = "Ok Recibo";
            this.btn_Ok_Recibo.UseVisualStyleBackColor = true;
            this.btn_Ok_Recibo.Click += new System.EventHandler(this.btn_Ok_Recibo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_agregados);
            this.groupBox1.Location = new System.Drawing.Point(130, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(990, 235);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // dgv_agregados
            // 
            this.dgv_agregados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_agregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_agregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_agregados.Location = new System.Drawing.Point(3, 16);
            this.dgv_agregados.Name = "dgv_agregados";
            this.dgv_agregados.Size = new System.Drawing.Size(984, 216);
            this.dgv_agregados.TabIndex = 0;
            // 
            // FrmCobrar_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(1264, 646);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Ok_Recibo);
            this.Controls.Add(this.lbl_vto);
            this.Controls.Add(this.lbl_cuota);
            this.Controls.Add(this.lbl_importe);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.lbl_endoso_suplemento);
            this.Controls.Add(this.lbl_poliza_asociada);
            this.Controls.Add(this.lbl_Rama);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gb_noencontro);
            this.Controls.Add(this.tb_barra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCobrar_Caja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCobrar_Caja";
            this.gb_noencontro.ResumeLayout(false);
            this.gb_noencontro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_agregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_barra;
        private System.Windows.Forms.GroupBox gb_noencontro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbl_vto;
        private System.Windows.Forms.Label lbl_cuota;
        private System.Windows.Forms.Label lbl_importe;
        private System.Windows.Forms.Label lbl_endoso_suplemento;
        private System.Windows.Forms.Label lbl_poliza_asociada;
        private System.Windows.Forms.Label lbl_Rama;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Button btn_Ok_Recibo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_agregados;
    }
}