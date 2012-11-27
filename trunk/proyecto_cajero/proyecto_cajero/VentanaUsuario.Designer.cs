namespace proyecto_cajero
{
    partial class VentanaUsuario
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
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.AllowDrop = true;
            this.cmbCriterio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmbCriterio.Items.AddRange(new object[] {
            "Todos los Clientes",
            "--------------------",
            "Tipo de Cuenta",
            "-------------------",
            "Moneda"});
            this.cmbCriterio.Location = new System.Drawing.Point(32, 22);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(143, 21);
            this.cmbCriterio.TabIndex = 0;
            this.cmbCriterio.Text = "-----------------------------------------";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(421, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 67);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(623, 228);
            this.dgvClientes.TabIndex = 2;
            // 
            // txtCriterio
            // 
            this.txtCriterio.Location = new System.Drawing.Point(220, 22);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(150, 20);
            this.txtCriterio.TabIndex = 3;
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 307);
            this.Controls.Add(this.txtCriterio);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbCriterio);
            this.Name = "VentanaUsuario";
            this.Text = "Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VentanaUsuario_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtCriterio;
    }
}