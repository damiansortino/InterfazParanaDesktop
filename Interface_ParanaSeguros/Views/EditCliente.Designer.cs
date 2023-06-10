
namespace Interface_ParanaSeguros.Views
{
    partial class EditCliente
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
            this.tb_apellido = new System.Windows.Forms.TextBox();
            this.tb_DNI = new System.Windows.Forms.TextBox();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Provincia = new System.Windows.Forms.TextBox();
            this.tb_Ciudad = new System.Windows.Forms.TextBox();
            this.tb_Tel = new System.Windows.Forms.TextBox();
            this.tb_Cuil = new System.Windows.Forms.TextBox();
            this.rt_Observaciones = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dtp_FechaNac = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_apellido
            // 
            this.tb_apellido.Location = new System.Drawing.Point(44, 39);
            this.tb_apellido.Name = "tb_apellido";
            this.tb_apellido.Size = new System.Drawing.Size(340, 20);
            this.tb_apellido.TabIndex = 0;
            // 
            // tb_DNI
            // 
            this.tb_DNI.Location = new System.Drawing.Point(44, 89);
            this.tb_DNI.Name = "tb_DNI";
            this.tb_DNI.Size = new System.Drawing.Size(153, 20);
            this.tb_DNI.TabIndex = 1;
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Location = new System.Drawing.Point(44, 190);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(340, 20);
            this.tb_Direccion.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(44, 392);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(340, 20);
            this.tb_Email.TabIndex = 7;
            // 
            // tb_Provincia
            // 
            this.tb_Provincia.Location = new System.Drawing.Point(44, 342);
            this.tb_Provincia.Name = "tb_Provincia";
            this.tb_Provincia.Size = new System.Drawing.Size(208, 20);
            this.tb_Provincia.TabIndex = 6;
            // 
            // tb_Ciudad
            // 
            this.tb_Ciudad.Location = new System.Drawing.Point(44, 291);
            this.tb_Ciudad.Name = "tb_Ciudad";
            this.tb_Ciudad.Size = new System.Drawing.Size(208, 20);
            this.tb_Ciudad.TabIndex = 5;
            // 
            // tb_Tel
            // 
            this.tb_Tel.Location = new System.Drawing.Point(44, 241);
            this.tb_Tel.Name = "tb_Tel";
            this.tb_Tel.Size = new System.Drawing.Size(208, 20);
            this.tb_Tel.TabIndex = 4;
            // 
            // tb_Cuil
            // 
            this.tb_Cuil.Location = new System.Drawing.Point(44, 441);
            this.tb_Cuil.Name = "tb_Cuil";
            this.tb_Cuil.Size = new System.Drawing.Size(208, 20);
            this.tb_Cuil.TabIndex = 8;
            // 
            // rt_Observaciones
            // 
            this.rt_Observaciones.Location = new System.Drawing.Point(427, 70);
            this.rt_Observaciones.Name = "rt_Observaciones";
            this.rt_Observaciones.Size = new System.Drawing.Size(304, 191);
            this.rt_Observaciones.TabIndex = 9;
            this.rt_Observaciones.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Observaciones";
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(480, 289);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 11;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.Location = new System.Drawing.Point(594, 289);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // dtp_FechaNac
            // 
            this.dtp_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNac.Location = new System.Drawing.Point(44, 144);
            this.dtp_FechaNac.Name = "dtp_FechaNac";
            this.dtp_FechaNac.Size = new System.Drawing.Size(153, 20);
            this.dtp_FechaNac.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Apellido y Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Ciudad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Provincia";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CUIL/CUIT";
            // 
            // EditCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(743, 464);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_FechaNac);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rt_Observaciones);
            this.Controls.Add(this.tb_Cuil);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Provincia);
            this.Controls.Add(this.tb_Ciudad);
            this.Controls.Add(this.tb_Tel);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.tb_DNI);
            this.Controls.Add(this.tb_apellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "EditCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_apellido;
        private System.Windows.Forms.TextBox tb_DNI;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Provincia;
        private System.Windows.Forms.TextBox tb_Ciudad;
        private System.Windows.Forms.TextBox tb_Tel;
        private System.Windows.Forms.TextBox tb_Cuil;
        private System.Windows.Forms.RichTextBox rt_Observaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DateTimePicker dtp_FechaNac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}