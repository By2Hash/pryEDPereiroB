namespace pryEDPereiroB
{
    partial class frmListaSimple
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
            this.pnlEliminado = new System.Windows.Forms.Panel();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblEliminado = new System.Windows.Forms.Label();
            this.pnlElementos = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstPila = new System.Windows.Forms.ListBox();
            this.lblElementos = new System.Windows.Forms.Label();
            this.pcbPila = new System.Windows.Forms.PictureBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblSerieSimple = new System.Windows.Forms.Label();
            this.pnlEliminado.SuspendLayout();
            this.pnlElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPila)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEliminado
            // 
            this.pnlEliminado.Controls.Add(this.cmbCodigo);
            this.pnlEliminado.Controls.Add(this.lblCodigo1);
            this.pnlEliminado.Controls.Add(this.btnEliminar);
            this.pnlEliminado.ForeColor = System.Drawing.Color.Black;
            this.pnlEliminado.Location = new System.Drawing.Point(464, 30);
            this.pnlEliminado.Name = "pnlEliminado";
            this.pnlEliminado.Size = new System.Drawing.Size(231, 216);
            this.pnlEliminado.TabIndex = 26;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo1.Location = new System.Drawing.Point(23, 96);
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
            // 
            // lblEliminado
            // 
            this.lblEliminado.AutoSize = true;
            this.lblEliminado.Location = new System.Drawing.Point(467, 14);
            this.lblEliminado.Name = "lblEliminado";
            this.lblEliminado.Size = new System.Drawing.Size(99, 13);
            this.lblEliminado.TabIndex = 25;
            this.lblEliminado.Text = "Elemento Eliminado";
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
            this.pnlElementos.Location = new System.Drawing.Point(227, 30);
            this.pnlElementos.Name = "pnlElementos";
            this.pnlElementos.Size = new System.Drawing.Size(231, 216);
            this.pnlElementos.TabIndex = 24;
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
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(26, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(183, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            // dgvPila
            // 
            this.dgvPila.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmTramite});
            this.dgvPila.Location = new System.Drawing.Point(227, 269);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersVisible = false;
            this.dgvPila.Size = new System.Drawing.Size(468, 238);
            this.dgvPila.TabIndex = 23;
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
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Items.AddRange(new object[] {
            "."});
            this.lstPila.Location = new System.Drawing.Point(12, 269);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(198, 238);
            this.lstPila.TabIndex = 22;
            // 
            // lblElementos
            // 
            this.lblElementos.AutoSize = true;
            this.lblElementos.Location = new System.Drawing.Point(230, 14);
            this.lblElementos.Name = "lblElementos";
            this.lblElementos.Size = new System.Drawing.Size(86, 13);
            this.lblElementos.TabIndex = 21;
            this.lblElementos.Text = "Nuevo Elemento";
            // 
            // pcbPila
            // 
            this.pcbPila.Image = global::pryEDPereiroB.Properties.Resources.SerieSimple;
            this.pcbPila.Location = new System.Drawing.Point(12, 61);
            this.pcbPila.Name = "pcbPila";
            this.pcbPila.Size = new System.Drawing.Size(198, 83);
            this.pcbPila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPila.TabIndex = 27;
            this.pcbPila.TabStop = false;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(88, 95);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigo.TabIndex = 12;
            // 
            // lblSerieSimple
            // 
            this.lblSerieSimple.AutoSize = true;
            this.lblSerieSimple.Location = new System.Drawing.Point(12, 253);
            this.lblSerieSimple.Name = "lblSerieSimple";
            this.lblSerieSimple.Size = new System.Drawing.Size(157, 13);
            this.lblSerieSimple.TabIndex = 28;
            this.lblSerieSimple.Text = "Listado en una Lista y una Grilla";
            // 
            // frmListaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 530);
            this.Controls.Add(this.lblSerieSimple);
            this.Controls.Add(this.pcbPila);
            this.Controls.Add(this.pnlEliminado);
            this.Controls.Add(this.lblEliminado);
            this.Controls.Add(this.pnlElementos);
            this.Controls.Add(this.dgvPila);
            this.Controls.Add(this.lstPila);
            this.Controls.Add(this.lblElementos);
            this.Name = "frmListaSimple";
            this.Text = "Estructura de datos lineal: Lista Simple";
            this.Load += new System.EventHandler(this.frmListaSimple_Load);
            this.pnlEliminado.ResumeLayout(false);
            this.pnlEliminado.PerformLayout();
            this.pnlElementos.ResumeLayout(false);
            this.pnlElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPila)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPila;
        private System.Windows.Forms.Panel pnlEliminado;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEliminado;
        private System.Windows.Forms.Panel pnlElementos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTramite;
        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.Label lblElementos;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblSerieSimple;
    }
}