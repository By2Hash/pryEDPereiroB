namespace pryEDPereiroB
{
    partial class frmConsultaTabla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaTabla));
            this.dgvConsultarTabla = new System.Windows.Forms.DataGridView();
            this.btnLlamar = new System.Windows.Forms.Button();
            this.cmbConsultar = new System.Windows.Forms.ComboBox();
            this.lblTabla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarTabla
            // 
            this.dgvConsultarTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultarTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarTabla.Location = new System.Drawing.Point(18, 18);
            this.dgvConsultarTabla.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvConsultarTabla.Name = "dgvConsultarTabla";
            this.dgvConsultarTabla.RowHeadersVisible = false;
            this.dgvConsultarTabla.RowHeadersWidth = 62;
            this.dgvConsultarTabla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultarTabla.Size = new System.Drawing.Size(1164, 580);
            this.dgvConsultarTabla.TabIndex = 0;
            // 
            // btnLlamar
            // 
            this.btnLlamar.Location = new System.Drawing.Point(1016, 629);
            this.btnLlamar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLlamar.Name = "btnLlamar";
            this.btnLlamar.Size = new System.Drawing.Size(166, 35);
            this.btnLlamar.TabIndex = 1;
            this.btnLlamar.Text = "Listar";
            this.btnLlamar.UseVisualStyleBackColor = true;
            this.btnLlamar.Click += new System.EventHandler(this.btnLlamar_Click_1);
            // 
            // cmbConsultar
            // 
            this.cmbConsultar.FormattingEnabled = true;
            this.cmbConsultar.Location = new System.Drawing.Point(810, 629);
            this.cmbConsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbConsultar.Name = "cmbConsultar";
            this.cmbConsultar.Size = new System.Drawing.Size(194, 28);
            this.cmbConsultar.TabIndex = 2;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(597, 634);
            this.lblTabla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(199, 20);
            this.lblTabla.TabIndex = 3;
            this.lblTabla.Text = "Tabla de la base de datos: ";
            // 
            // frmConsultaTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.cmbConsultar);
            this.Controls.Add(this.btnLlamar);
            this.Controls.Add(this.dgvConsultarTabla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultaTabla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de una tabla";
            this.Load += new System.EventHandler(this.frmConsultaTabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarTabla;
        private System.Windows.Forms.Button btnLlamar;
        private System.Windows.Forms.ComboBox cmbConsultar;
        private System.Windows.Forms.Label lblTabla;
    }
}