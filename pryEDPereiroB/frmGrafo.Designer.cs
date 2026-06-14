namespace pryEDPereiroB
{
    partial class frmGrafo
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
            this.lblListar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnVerTodo = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDestinoHasta = new System.Windows.Forms.ComboBox();
            this.cmbOrigenDesde = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.clmOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCórdoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMendoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBuenosAires = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConsultarDatos = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cmbCDestino = new System.Windows.Forms.ComboBox();
            this.cmbCOrigen = new System.Windows.Forms.ComboBox();
            this.lblCPrecio = new System.Windows.Forms.Label();
            this.lblCDestino = new System.Windows.Forms.Label();
            this.lblCOrigen = new System.Windows.Forms.Label();
            this.pnlCargaDatos = new System.Windows.Forms.Panel();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.lblCargaDatos = new System.Windows.Forms.Label();
            this.pcbGrafo = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            this.pnlConsultarDatos.SuspendLayout();
            this.pnlCargaDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Location = new System.Drawing.Point(12, 412);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(107, 20);
            this.lblListar.TabIndex = 44;
            this.lblListar.Text = "Listar viajes ...";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVerTodo);
            this.panel3.Controls.Add(this.btnListarOrigenes);
            this.panel3.Controls.Add(this.btnListarDestinos);
            this.panel3.Controls.Add(this.cmbDestinoHasta);
            this.panel3.Controls.Add(this.cmbOrigenDesde);
            this.panel3.Controls.Add(this.lblHasta);
            this.panel3.Controls.Add(this.lblDesde);
            this.panel3.Controls.Add(this.dgvGrafo);
            this.panel3.Location = new System.Drawing.Point(14, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 457);
            this.panel3.TabIndex = 43;
            // 
            // btnVerTodo
            // 
            this.btnVerTodo.Location = new System.Drawing.Point(886, 26);
            this.btnVerTodo.Name = "btnVerTodo";
            this.btnVerTodo.Size = new System.Drawing.Size(176, 35);
            this.btnVerTodo.TabIndex = 44;
            this.btnVerTodo.Text = "Ver todos los viajes";
            this.btnVerTodo.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(652, 25);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(158, 38);
            this.btnListarOrigenes.TabIndex = 43;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(242, 25);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(136, 38);
            this.btnListarDestinos.TabIndex = 42;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoHasta
            // 
            this.cmbDestinoHasta.FormattingEnabled = true;
            this.cmbDestinoHasta.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDestinoHasta.Location = new System.Drawing.Point(482, 31);
            this.cmbDestinoHasta.Name = "cmbDestinoHasta";
            this.cmbDestinoHasta.Size = new System.Drawing.Size(148, 28);
            this.cmbDestinoHasta.TabIndex = 41;
            // 
            // cmbOrigenDesde
            // 
            this.cmbOrigenDesde.FormattingEnabled = true;
            this.cmbOrigenDesde.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbOrigenDesde.Location = new System.Drawing.Point(74, 31);
            this.cmbOrigenDesde.Name = "cmbOrigenDesde";
            this.cmbOrigenDesde.Size = new System.Drawing.Size(148, 28);
            this.cmbOrigenDesde.TabIndex = 40;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(418, 34);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(56, 20);
            this.lblHasta.TabIndex = 39;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(10, 34);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(60, 20);
            this.lblDesde.TabIndex = 38;
            this.lblDesde.Text = "Desde:";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrigen,
            this.clmCórdoba,
            this.clmMendoza,
            this.clmSantaFe,
            this.clmBuenosAires,
            this.clmSalta});
            this.dgvGrafo.Location = new System.Drawing.Point(15, 86);
            this.dgvGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.RowHeadersVisible = false;
            this.dgvGrafo.RowHeadersWidth = 62;
            this.dgvGrafo.Size = new System.Drawing.Size(1048, 351);
            this.dgvGrafo.TabIndex = 26;
            // 
            // clmOrigen
            // 
            this.clmOrigen.HeaderText = "Origen";
            this.clmOrigen.MinimumWidth = 8;
            this.clmOrigen.Name = "clmOrigen";
            // 
            // clmCórdoba
            // 
            this.clmCórdoba.HeaderText = "Córdoba";
            this.clmCórdoba.MinimumWidth = 8;
            this.clmCórdoba.Name = "clmCórdoba";
            // 
            // clmMendoza
            // 
            this.clmMendoza.HeaderText = "Mendoza";
            this.clmMendoza.MinimumWidth = 8;
            this.clmMendoza.Name = "clmMendoza";
            // 
            // clmSantaFe
            // 
            this.clmSantaFe.HeaderText = "Santa Fe";
            this.clmSantaFe.MinimumWidth = 8;
            this.clmSantaFe.Name = "clmSantaFe";
            // 
            // clmBuenosAires
            // 
            this.clmBuenosAires.HeaderText = "Buenos Aires";
            this.clmBuenosAires.MinimumWidth = 8;
            this.clmBuenosAires.Name = "clmBuenosAires";
            // 
            // clmSalta
            // 
            this.clmSalta.HeaderText = "Salta";
            this.clmSalta.MinimumWidth = 8;
            this.clmSalta.Name = "clmSalta";
            // 
            // pnlConsultarDatos
            // 
            this.pnlConsultarDatos.Controls.Add(this.label7);
            this.pnlConsultarDatos.Controls.Add(this.btnBorrar);
            this.pnlConsultarDatos.Controls.Add(this.btnConsultar);
            this.pnlConsultarDatos.Controls.Add(this.cmbCDestino);
            this.pnlConsultarDatos.Controls.Add(this.cmbCOrigen);
            this.pnlConsultarDatos.Controls.Add(this.lblCPrecio);
            this.pnlConsultarDatos.Controls.Add(this.lblCDestino);
            this.pnlConsultarDatos.Controls.Add(this.lblCOrigen);
            this.pnlConsultarDatos.Location = new System.Drawing.Point(714, 32);
            this.pnlConsultarDatos.Name = "pnlConsultarDatos";
            this.pnlConsultarDatos.Size = new System.Drawing.Size(342, 329);
            this.pnlConsultarDatos.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(148, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 28);
            this.label7.TabIndex = 16;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.Location = new System.Drawing.Point(198, 254);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 38);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultar.Location = new System.Drawing.Point(45, 254);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 38);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cmbCDestino
            // 
            this.cmbCDestino.FormattingEnabled = true;
            this.cmbCDestino.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbCDestino.Location = new System.Drawing.Point(148, 112);
            this.cmbCDestino.Name = "cmbCDestino";
            this.cmbCDestino.Size = new System.Drawing.Size(154, 28);
            this.cmbCDestino.TabIndex = 12;
            // 
            // cmbCOrigen
            // 
            this.cmbCOrigen.FormattingEnabled = true;
            this.cmbCOrigen.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbCOrigen.Location = new System.Drawing.Point(148, 37);
            this.cmbCOrigen.Name = "cmbCOrigen";
            this.cmbCOrigen.Size = new System.Drawing.Size(154, 28);
            this.cmbCOrigen.TabIndex = 11;
            // 
            // lblCPrecio
            // 
            this.lblCPrecio.AutoSize = true;
            this.lblCPrecio.Location = new System.Drawing.Point(40, 191);
            this.lblCPrecio.Name = "lblCPrecio";
            this.lblCPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblCPrecio.TabIndex = 10;
            this.lblCPrecio.Text = "Precio:";
            // 
            // lblCDestino
            // 
            this.lblCDestino.AutoSize = true;
            this.lblCDestino.Location = new System.Drawing.Point(40, 115);
            this.lblCDestino.Name = "lblCDestino";
            this.lblCDestino.Size = new System.Drawing.Size(68, 20);
            this.lblCDestino.TabIndex = 9;
            this.lblCDestino.Text = "Destino:";
            // 
            // lblCOrigen
            // 
            this.lblCOrigen.AutoSize = true;
            this.lblCOrigen.Location = new System.Drawing.Point(40, 40);
            this.lblCOrigen.Name = "lblCOrigen";
            this.lblCOrigen.Size = new System.Drawing.Size(60, 20);
            this.lblCOrigen.TabIndex = 8;
            this.lblCOrigen.Text = "Origen:";
            // 
            // pnlCargaDatos
            // 
            this.pnlCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.pnlCargaDatos.Controls.Add(this.btnCargar);
            this.pnlCargaDatos.Controls.Add(this.txtPrecio);
            this.pnlCargaDatos.Controls.Add(this.cmbDestino);
            this.pnlCargaDatos.Controls.Add(this.cmbOrigen);
            this.pnlCargaDatos.Controls.Add(this.lblPrecio);
            this.pnlCargaDatos.Controls.Add(this.lblDestino);
            this.pnlCargaDatos.Controls.Add(this.lblOrigen);
            this.pnlCargaDatos.Location = new System.Drawing.Point(345, 32);
            this.pnlCargaDatos.Name = "pnlCargaDatos";
            this.pnlCargaDatos.Size = new System.Drawing.Size(320, 329);
            this.pnlCargaDatos.TabIndex = 41;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrarTodo.Location = new System.Drawing.Point(177, 254);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(104, 38);
            this.btnBorrarTodo.TabIndex = 7;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCargar.Location = new System.Drawing.Point(24, 254);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(104, 38);
            this.btnCargar.TabIndex = 6;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(128, 185);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(154, 26);
            this.txtPrecio.TabIndex = 5;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDestino.Location = new System.Drawing.Point(128, 115);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(154, 28);
            this.cmbDestino.TabIndex = 4;
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Córdoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbOrigen.Location = new System.Drawing.Point(128, 34);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(154, 28);
            this.cmbOrigen.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 188);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(57, 20);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(20, 115);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(68, 20);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino:";
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(20, 37);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(60, 20);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Location = new System.Drawing.Point(710, 9);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(141, 20);
            this.lblConsulta.TabIndex = 39;
            this.lblConsulta.Text = "Consulta de Datos";
            // 
            // lblCargaDatos
            // 
            this.lblCargaDatos.AutoSize = true;
            this.lblCargaDatos.Location = new System.Drawing.Point(340, 9);
            this.lblCargaDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargaDatos.Name = "lblCargaDatos";
            this.lblCargaDatos.Size = new System.Drawing.Size(121, 20);
            this.lblCargaDatos.TabIndex = 38;
            this.lblCargaDatos.Text = "Carga de Datos";
            // 
            // pcbGrafo
            // 
            this.pcbGrafo.Image = global::pryEDPereiroB.Properties.Resources.Sin_título2;
            this.pcbGrafo.Location = new System.Drawing.Point(16, 32);
            this.pcbGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pcbGrafo.Name = "pcbGrafo";
            this.pcbGrafo.Size = new System.Drawing.Size(297, 231);
            this.pcbGrafo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbGrafo.TabIndex = 40;
            this.pcbGrafo.TabStop = false;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 905);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlConsultarDatos);
            this.Controls.Add(this.pnlCargaDatos);
            this.Controls.Add(this.pcbGrafo);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.lblCargaDatos);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGrafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            this.pnlConsultarDatos.ResumeLayout(false);
            this.pnlConsultarDatos.PerformLayout();
            this.pnlCargaDatos.ResumeLayout(false);
            this.pnlCargaDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGrafo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVerTodo;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbDestinoHasta;
        private System.Windows.Forms.ComboBox cmbOrigenDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.Panel pnlConsultarDatos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox cmbCDestino;
        private System.Windows.Forms.ComboBox cmbCOrigen;
        private System.Windows.Forms.Label lblCPrecio;
        private System.Windows.Forms.Label lblCDestino;
        private System.Windows.Forms.Label lblCOrigen;
        private System.Windows.Forms.Panel pnlCargaDatos;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.PictureBox pcbGrafo;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Label lblCargaDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCórdoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMendoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBuenosAires;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalta;
    }
}