
namespace Interface_ParanaSeguros.Views
{
    partial class Agregar_Recibos
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
            this.tb_barra = new System.Windows.Forms.TextBox();
            this.dgv_Recibos = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_IngresoManual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_barra
            // 
            this.tb_barra.Location = new System.Drawing.Point(12, 29);
            this.tb_barra.Name = "tb_barra";
            this.tb_barra.Size = new System.Drawing.Size(448, 20);
            this.tb_barra.TabIndex = 0;
            this.tb_barra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_barra_KeyPress);
            // 
            // dgv_Recibos
            // 
            this.dgv_Recibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Recibos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Recibos.Location = new System.Drawing.Point(0, 112);
            this.dgv_Recibos.Name = "dgv_Recibos";
            this.dgv_Recibos.Size = new System.Drawing.Size(975, 487);
            this.dgv_Recibos.TabIndex = 1;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(489, 12);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(96, 66);
            this.btn_Agregar.TabIndex = 2;
            this.btn_Agregar.Text = "Agregar los recibos seleccionados";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(873, 12);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(90, 37);
            this.btn_Cancelar.TabIndex = 3;
            this.btn_Cancelar.Text = "Cerrar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_IngresoManual
            // 
            this.btn_IngresoManual.Location = new System.Drawing.Point(591, 12);
            this.btn_IngresoManual.Name = "btn_IngresoManual";
            this.btn_IngresoManual.Size = new System.Drawing.Size(93, 66);
            this.btn_IngresoManual.TabIndex = 4;
            this.btn_IngresoManual.Text = "ingreso Manual";
            this.btn_IngresoManual.UseVisualStyleBackColor = true;
            this.btn_IngresoManual.Click += new System.EventHandler(this.btn_IngresoManual_Click);
            // 
            // Agregar_Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(975, 599);
            this.Controls.Add(this.btn_IngresoManual);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.dgv_Recibos);
            this.Controls.Add(this.tb_barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Agregar_Recibos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Recibos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Recibos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_barra;
        private System.Windows.Forms.DataGridView dgv_Recibos;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_IngresoManual;
    }
}