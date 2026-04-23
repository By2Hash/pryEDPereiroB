namespace pryEDPereiroB
{
    partial class frmDatosDesarrolador
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDesarrollador = new System.Windows.Forms.Label();
            this.llblGitHub = new System.Windows.Forms.LinkLabel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDPereiroB.Properties.Resources.Sin_título1;
            this.pictureBox1.Location = new System.Drawing.Point(294, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDesarrollador
            // 
            this.lblDesarrollador.AllowDrop = true;
            this.lblDesarrollador.AutoSize = true;
            this.lblDesarrollador.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrollador.Location = new System.Drawing.Point(12, 24);
            this.lblDesarrollador.Name = "lblDesarrollador";
            this.lblDesarrollador.Size = new System.Drawing.Size(268, 29);
            this.lblDesarrollador.TabIndex = 1;
            this.lblDesarrollador.Text = "Datos del Desarrollador";
            // 
            // llblGitHub
            // 
            this.llblGitHub.AutoSize = true;
            this.llblGitHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblGitHub.Location = new System.Drawing.Point(12, 155);
            this.llblGitHub.Name = "llblGitHub";
            this.llblGitHub.Size = new System.Drawing.Size(72, 25);
            this.llblGitHub.TabIndex = 2;
            this.llblGitHub.TabStop = true;
            this.llblGitHub.Text = "GitHub";
            this.llblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblGitHub_LinkClicked);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 91);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(186, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre: Bautista Pereiro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Carrera: Analista de Sistemas\r\n";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(13, 121);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(73, 20);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad: 19";
            // 
            // frmDatosDesarrolador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 225);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.llblGitHub);
            this.Controls.Add(this.lblDesarrollador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDatosDesarrolador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Desarrolador";
            this.Load += new System.EventHandler(this.frmDatosDesarrolador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDesarrollador;
        private System.Windows.Forms.LinkLabel llblGitHub;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEdad;
    }
}