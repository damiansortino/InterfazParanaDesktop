
namespace Interface_ParanaSeguros.Views
{
    partial class Clientes_Form
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
            this.gb_filtro = new System.Windows.Forms.GroupBox();
            this.radio_poliza = new System.Windows.Forms.RadioButton();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.radio_cliente = new System.Windows.Forms.RadioButton();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.btn_MostrarTodos = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_InterfaceTelefonos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_filtro.SuspendLayout();
            this.SuspendLayout();
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
            this.dgv.Size = new System.Drawing.Size(1100, 295);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1106, 314);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de Clientes";
            // 
            // gb_filtro
            // 
            this.gb_filtro.Controls.Add(this.radio_poliza);
            this.gb_filtro.Controls.Add(this.tb_filtro);
            this.gb_filtro.Controls.Add(this.radio_cliente);
            this.gb_filtro.Controls.Add(this.btn_filtrar);
            this.gb_filtro.Location = new System.Drawing.Point(12, 86);
            this.gb_filtro.Name = "gb_filtro";
            this.gb_filtro.Size = new System.Drawing.Size(342, 80);
            this.gb_filtro.TabIndex = 29;
            this.gb_filtro.TabStop = false;
            // 
            // radio_poliza
            // 
            this.radio_poliza.AutoSize = true;
            this.radio_poliza.Checked = true;
            this.radio_poliza.Location = new System.Drawing.Point(28, 19);
            this.radio_poliza.Name = "radio_poliza";
            this.radio_poliza.Size = new System.Drawing.Size(110, 17);
            this.radio_poliza.TabIndex = 14;
            this.radio_poliza.TabStop = true;
            this.radio_poliza.Text = "Apellido y Nombre";
            this.radio_poliza.UseVisualStyleBackColor = true;
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
            // radio_cliente
            // 
            this.radio_cliente.AutoSize = true;
            this.radio_cliente.Location = new System.Drawing.Point(222, 19);
            this.radio_cliente.Name = "radio_cliente";
            this.radio_cliente.Size = new System.Drawing.Size(44, 17);
            this.radio_cliente.TabIndex = 15;
            this.radio_cliente.Text = "DNI";
            this.radio_cliente.UseVisualStyleBackColor = true;
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
            // btn_Editar
            // 
            this.btn_Editar.Location = new System.Drawing.Point(376, 42);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(158, 39);
            this.btn_Editar.TabIndex = 30;
            this.btn_Editar.Text = "Editar el cliente seleccionado";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // btn_MostrarTodos
            // 
            this.btn_MostrarTodos.Location = new System.Drawing.Point(12, 27);
            this.btn_MostrarTodos.Name = "btn_MostrarTodos";
            this.btn_MostrarTodos.Size = new System.Drawing.Size(158, 39);
            this.btn_MostrarTodos.TabIndex = 31;
            this.btn_MostrarTodos.Text = "Mostrar todos";
            this.btn_MostrarTodos.UseVisualStyleBackColor = true;
            this.btn_MostrarTodos.Click += new System.EventHandler(this.btn_MostrarTodos_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cerrar.Location = new System.Drawing.Point(1019, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cerrar.TabIndex = 32;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_InterfaceTelefonos
            // 
            this.btn_InterfaceTelefonos.Location = new System.Drawing.Point(376, 132);
            this.btn_InterfaceTelefonos.Name = "btn_InterfaceTelefonos";
            this.btn_InterfaceTelefonos.Size = new System.Drawing.Size(158, 39);
            this.btn_InterfaceTelefonos.TabIndex = 36;
            this.btn_InterfaceTelefonos.Text = "Actualizar Teléfonos TEC";
            this.btn_InterfaceTelefonos.UseVisualStyleBackColor = true;
            this.btn_InterfaceTelefonos.Click += new System.EventHandler(this.btn_InterfaceTelefonos_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(376, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 39);
            this.button3.TabIndex = 35;
            this.button3.Text = "Eliminar Seleccionado";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Clientes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cerrar;
            this.ClientSize = new System.Drawing.Size(1106, 486);
            this.Controls.Add(this.btn_InterfaceTelefonos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_MostrarTodos);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.gb_filtro);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Clientes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.gb_filtro.ResumeLayout(false);
            this.gb_filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gb_filtro;
        private System.Windows.Forms.RadioButton radio_poliza;
        private System.Windows.Forms.TextBox tb_filtro;
        private System.Windows.Forms.RadioButton radio_cliente;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Button btn_MostrarTodos;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_InterfaceTelefonos;
        private System.Windows.Forms.Button button3;
    }
}