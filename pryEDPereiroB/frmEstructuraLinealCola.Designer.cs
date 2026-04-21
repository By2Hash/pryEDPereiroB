namespace pryEDPereiroB
{
    partial class frmEstructuraLinealCola
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblElementos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlElementos = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.pnlEliminado = new System.Windows.Forms.Panel();
            this.lblCodEliminado = new System.Windows.Forms.Label();
            this.lblNomEliminado = new System.Windows.Forms.Label();
            this.lblTraEliminado = new System.Windows.Forms.Label();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.lblEliminado = new System.Windows.Forms.Label();
            this.pcbCola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.pnlElementos.SuspendLayout();
            this.pnlEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCola)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(109, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(109, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(109, 117);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 23);
            this.txtTramite.TabIndex = 2;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(230, 29);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(86, 13);
            this.lblElementos.TabIndex = 3;
            this.lblElementos.Text = "Nuevo Elemento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(23, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(23, 117);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 17);
            this.lblTramite.TabIndex = 5;
            this.lblTramite.Text = "Tramite";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(26, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstCola
            // 
            this.lstCola.FormattingEnabled = true;
            this.lstCola.Items.AddRange(new object[] {
            "."});
            this.lstCola.Location = new System.Drawing.Point(12, 284);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(198, 238);
            this.lstCola.TabIndex = 8;
            // 
            // dgvCola
            // 
            this.dgvCola.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvCola.Location = new System.Drawing.Point(227, 284);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersVisible = false;
            this.dgvCola.Size = new System.Drawing.Size(468, 238);
            this.dgvCola.TabIndex = 9;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "Codigo";
            this.clmCodigo.Name = "clmCodigo";
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "Nombre";
            this.clmNombre.Name = "clmNombre";
            // 
            // clmTramite
            // 
            this.clmTramite.HeaderText = "Tramite";
            this.clmTramite.Name = "clmTramite";
            // 
            // pnlElementos
            // 
            this.pnlElementos.Controls.Add(this.lblCodigo);
            this.pnlElementos.Controls.Add(this.txtCodigo);
            this.pnlElementos.Controls.Add(this.txtNombre);
            this.pnlElementos.Controls.Add(this.txtTramite);
            this.pnlElementos.Controls.Add(this.btnAgregar);
            this.pnlElementos.Controls.Add(this.lblNombre);
            this.pnlElementos.Controls.Add(this.lblTramite);
            this.pnlElementos.ForeColor = System.Drawing.Color.Black;
            this.pnlElementos.Location = new System.Drawing.Point(227, 45);
            this.pnlElementos.Name = "pnlElementos";
            this.pnlElementos.Size = new System.Drawing.Size(231, 216);
            this.pnlElementos.TabIndex = 10;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(23, 35);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo:";
            // 
            // pnlEliminado
            // 
            this.pnlEliminado.Controls.Add(this.lblCodEliminado);
            this.pnlEliminado.Controls.Add(this.lblNomEliminado);
            this.pnlEliminado.Controls.Add(this.lblTraEliminado);
            this.pnlEliminado.Controls.Add(this.lblCodigo1);
            this.pnlEliminado.Controls.Add(this.btnEliminar);
            this.pnlEliminado.Controls.Add(this.lblNombre1);
            this.pnlEliminado.Controls.Add(this.lblTramite1);
            this.pnlEliminado.ForeColor = System.Drawing.Color.Black;
            this.pnlEliminado.Location = new System.Drawing.Point(464, 45);
            this.pnlEliminado.Name = "pnlEliminado";
            this.pnlEliminado.Size = new System.Drawing.Size(231, 216);
            this.pnlEliminado.TabIndex = 12;
            this.pnlEliminado.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEliminado_Paint);
            // 
            // lblCodEliminado
            // 
            this.lblCodEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodEliminado.Location = new System.Drawing.Point(103, 31);
            this.lblCodEliminado.Name = "lblCodEliminado";
            this.lblCodEliminado.Size = new System.Drawing.Size(94, 25);
            this.lblCodEliminado.TabIndex = 14;
            this.lblCodEliminado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblNomEliminado
            // 
            this.lblNomEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEliminado.Location = new System.Drawing.Point(103, 73);
            this.lblNomEliminado.Name = "lblNomEliminado";
            this.lblNomEliminado.Size = new System.Drawing.Size(94, 23);
            this.lblNomEliminado.TabIndex = 12;
            this.lblNomEliminado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblTraEliminado
            // 
            this.lblTraEliminado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTraEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraEliminado.Location = new System.Drawing.Point(103, 112);
            this.lblTraEliminado.Name = "lblTraEliminado";
            this.lblTraEliminado.Size = new System.Drawing.Size(94, 23);
            this.lblTraEliminado.TabIndex = 13;
            this.lblTraEliminado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo1.Location = new System.Drawing.Point(23, 35);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(56, 17);
            this.lblCodigo1.TabIndex = 11;
            this.lblCodigo1.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.Location = new System.Drawing.Point(26, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(183, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre1.Location = new System.Drawing.Point(23, 75);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(62, 17);
            this.lblNombre1.TabIndex = 4;
            this.lblNombre1.Text = "Nombre:";
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite1.Location = new System.Drawing.Point(23, 117);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(56, 17);
            this.lblTramite1.TabIndex = 5;
            this.lblTramite1.Text = "Tramite";
            // 
            // lblEliminado
            // 
            this.lblEliminado.AutoSize = true;
            this.lblEliminado.Location = new System.Drawing.Point(467, 29);
            this.lblEliminado.Name = "lblEliminado";
            this.lblEliminado.Size = new System.Drawing.Size(99, 13);
            this.lblEliminado.TabIndex = 11;
            this.lblEliminado.Text = "Elemento Eliminado";
            // 
            // pcbCola
            // 
            this.pcbCola.Image = global::pryEDPereiroB.Properties.Resources.b10;
            this.pcbCola.Location = new System.Drawing.Point(12, 45);
            this.pcbCola.Name = "pcbCola";
            this.pcbCola.Size = new System.Drawing.Size(198, 216);
            this.pcbCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCola.TabIndex = 13;
            this.pcbCola.TabStop = false;
            // 
            // frmEstructuraLinealCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 537);
            this.Controls.Add(this.pcbCola);
            this.Controls.Add(this.pnlEliminado);
            this.Controls.Add(this.lblEliminado);
            this.Controls.Add(this.pnlElementos);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.lstCola);
            this.Controls.Add(this.lblElementos);
            this.Name = "frmEstructuraLinealCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura Dinamica Lineal - Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.pnlElementos.ResumeLayout(false);
            this.pnlElementos.PerformLayout();
            this.pnlEliminado.ResumeLayout(false);
            this.pnlEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Panel pnlElementos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel pnlEliminado;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lblEliminado;
        private System.Windows.Forms.PictureBox pcbCola;
        private System.Windows.Forms.Label lblCodEliminado;
        private System.Windows.Forms.Label lblNomEliminado;
        private System.Windows.Forms.Label lblTraEliminado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
    }
}