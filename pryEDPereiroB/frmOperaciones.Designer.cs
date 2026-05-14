namespace pryEDPereiroB
{
    partial class frmOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperaciones));
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOpreaciones = new System.Windows.Forms.Label();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyecciónMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.lblSeleccionMultiatributo = new System.Windows.Forms.Button();
            this.btnSellecionSimple = new System.Windows.Forms.Button();
            this.lblOperacionSeleccion = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnIntersección = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.lblOperacionesAlgebraicas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDB
            // 
            this.dgvDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDB.Location = new System.Drawing.Point(12, 12);
            this.dgvDB.Name = "dgvDB";
            this.dgvDB.Size = new System.Drawing.Size(762, 350);
            this.dgvDB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyecciónMulti);
            this.groupBox1.Controls.Add(this.btnProyeccionSimple);
            this.groupBox1.Controls.Add(this.lblOpreaciones);
            this.groupBox1.Location = new System.Drawing.Point(12, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 128);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lblOpreaciones
            // 
            this.lblOpreaciones.AutoSize = true;
            this.lblOpreaciones.Location = new System.Drawing.Point(27, 0);
            this.lblOpreaciones.Name = "lblOpreaciones";
            this.lblOpreaciones.Size = new System.Drawing.Size(188, 13);
            this.lblOpreaciones.TabIndex = 0;
            this.lblOpreaciones.Text = "Operaciones de Proyeccion - SELECT";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Location = new System.Drawing.Point(19, 28);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(196, 23);
            this.btnProyeccionSimple.TabIndex = 1;
            this.btnProyeccionSimple.Text = "Proyección simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnProyecciónMulti
            // 
            this.btnProyecciónMulti.Location = new System.Drawing.Point(22, 57);
            this.btnProyecciónMulti.Name = "btnProyecciónMulti";
            this.btnProyecciónMulti.Size = new System.Drawing.Size(193, 23);
            this.btnProyecciónMulti.TabIndex = 2;
            this.btnProyecciónMulti.Text = "Proyección multiatributo";
            this.btnProyecciónMulti.UseVisualStyleBackColor = true;
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(22, 86);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(193, 23);
            this.btnJuntar.TabIndex = 3;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSeleccionConvolucion);
            this.groupBox2.Controls.Add(this.lblSeleccionMultiatributo);
            this.groupBox2.Controls.Add(this.btnSellecionSimple);
            this.groupBox2.Controls.Add(this.lblOperacionSeleccion);
            this.groupBox2.Location = new System.Drawing.Point(279, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(22, 86);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(193, 23);
            this.btnSeleccionConvolucion.TabIndex = 3;
            this.btnSeleccionConvolucion.Text = "Selección por convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionMultiatributo
            // 
            this.lblSeleccionMultiatributo.Location = new System.Drawing.Point(22, 57);
            this.lblSeleccionMultiatributo.Name = "lblSeleccionMultiatributo";
            this.lblSeleccionMultiatributo.Size = new System.Drawing.Size(193, 23);
            this.lblSeleccionMultiatributo.TabIndex = 2;
            this.lblSeleccionMultiatributo.Text = "Selección multiatributo";
            this.lblSeleccionMultiatributo.UseVisualStyleBackColor = true;
            // 
            // btnSellecionSimple
            // 
            this.btnSellecionSimple.Location = new System.Drawing.Point(19, 28);
            this.btnSellecionSimple.Name = "btnSellecionSimple";
            this.btnSellecionSimple.Size = new System.Drawing.Size(196, 23);
            this.btnSellecionSimple.TabIndex = 1;
            this.btnSellecionSimple.Text = "Selección simple";
            this.btnSellecionSimple.UseVisualStyleBackColor = true;
            // 
            // lblOperacionSeleccion
            // 
            this.lblOperacionSeleccion.AutoSize = true;
            this.lblOperacionSeleccion.Location = new System.Drawing.Point(27, 0);
            this.lblOperacionSeleccion.Name = "lblOperacionSeleccion";
            this.lblOperacionSeleccion.Size = new System.Drawing.Size(182, 13);
            this.lblOperacionSeleccion.TabIndex = 0;
            this.lblOperacionSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnIntersección);
            this.groupBox3.Controls.Add(this.btnUnion);
            this.groupBox3.Controls.Add(this.lblOperacionesAlgebraicas);
            this.groupBox3.Location = new System.Drawing.Point(538, 390);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 128);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(22, 86);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(193, 23);
            this.btnDiferencia.TabIndex = 3;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnIntersección
            // 
            this.btnIntersección.Location = new System.Drawing.Point(22, 57);
            this.btnIntersección.Name = "btnIntersección";
            this.btnIntersección.Size = new System.Drawing.Size(193, 23);
            this.btnIntersección.TabIndex = 2;
            this.btnIntersección.Text = "Intersección";
            this.btnIntersección.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(19, 28);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(196, 23);
            this.btnUnion.TabIndex = 1;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // lblOperacionesAlgebraicas
            // 
            this.lblOperacionesAlgebraicas.AutoSize = true;
            this.lblOperacionesAlgebraicas.Location = new System.Drawing.Point(27, 0);
            this.lblOperacionesAlgebraicas.Name = "lblOperacionesAlgebraicas";
            this.lblOperacionesAlgebraicas.Size = new System.Drawing.Size(128, 13);
            this.lblOperacionesAlgebraicas.TabIndex = 0;
            this.lblOperacionesAlgebraicas.Text = "Operaciones Algebraicas ";
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOpreaciones;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyecciónMulti;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.Button lblSeleccionMultiatributo;
        private System.Windows.Forms.Button btnSellecionSimple;
        private System.Windows.Forms.Label lblOperacionSeleccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnIntersección;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Label lblOperacionesAlgebraicas;
    }
}