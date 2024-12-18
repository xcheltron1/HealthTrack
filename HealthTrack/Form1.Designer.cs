namespace HealthTrack
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.peneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.superPeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megaPeneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peneInfnitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(208, 19);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(420, 45);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a HealtTracker";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(897, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // peneToolStripMenuItem
            // 
            this.peneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.superPeneToolStripMenuItem,
            this.megaPeneToolStripMenuItem,
            this.peneInfnitoToolStripMenuItem});
            this.peneToolStripMenuItem.Name = "peneToolStripMenuItem";
            this.peneToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.peneToolStripMenuItem.Text = "pene";
            // 
            // superPeneToolStripMenuItem
            // 
            this.superPeneToolStripMenuItem.Name = "superPeneToolStripMenuItem";
            this.superPeneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.superPeneToolStripMenuItem.Text = "super pene";
            // 
            // megaPeneToolStripMenuItem
            // 
            this.megaPeneToolStripMenuItem.Name = "megaPeneToolStripMenuItem";
            this.megaPeneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.megaPeneToolStripMenuItem.Text = "mega pene";
            // 
            // peneInfnitoToolStripMenuItem
            // 
            this.peneInfnitoToolStripMenuItem.Name = "peneInfnitoToolStripMenuItem";
            this.peneInfnitoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.peneInfnitoToolStripMenuItem.Text = "pene infnito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem superPeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megaPeneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peneInfnitoToolStripMenuItem;
    }
}

