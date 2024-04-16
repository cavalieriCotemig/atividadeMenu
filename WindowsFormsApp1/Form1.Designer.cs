namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selecioneUmExercicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex05pag38ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex06PagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ex15pag16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selecioneUmExercicioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selecioneUmExercicioToolStripMenuItem
            // 
            this.selecioneUmExercicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ex05pag38ToolStripMenuItem,
            this.ex06PagToolStripMenuItem,
            this.eToolStripMenuItem,
            this.ex15pag16ToolStripMenuItem});
            this.selecioneUmExercicioToolStripMenuItem.Name = "selecioneUmExercicioToolStripMenuItem";
            this.selecioneUmExercicioToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.selecioneUmExercicioToolStripMenuItem.Text = "Selecione um exercicio";
            // 
            // ex05pag38ToolStripMenuItem
            // 
            this.ex05pag38ToolStripMenuItem.Name = "ex05pag38ToolStripMenuItem";
            this.ex05pag38ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex05pag38ToolStripMenuItem.Text = "ex05pag38";
            this.ex05pag38ToolStripMenuItem.Click += new System.EventHandler(this.ex05pag38ToolStripMenuItem_Click);
            // 
            // ex06PagToolStripMenuItem
            // 
            this.ex06PagToolStripMenuItem.Name = "ex06PagToolStripMenuItem";
            this.ex06PagToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ex06PagToolStripMenuItem.Text = "ex06Pag38";
            this.ex06PagToolStripMenuItem.Click += new System.EventHandler(this.ex06PagToolStripMenuItem_Click);
            // 
            // eToolStripMenuItem
            // 
            this.eToolStripMenuItem.Name = "eToolStripMenuItem";
            this.eToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.eToolStripMenuItem.Text = "EquacaoDeSegundoGrau";
            this.eToolStripMenuItem.Click += new System.EventHandler(this.eToolStripMenuItem_Click);
            // 
            // ex15pag16ToolStripMenuItem
            // 
            this.ex15pag16ToolStripMenuItem.Name = "ex15pag16ToolStripMenuItem";
            this.ex15pag16ToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ex15pag16ToolStripMenuItem.Text = "ex15pag16";
            this.ex15pag16ToolStripMenuItem.Click += new System.EventHandler(this.ex15pag16ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selecioneUmExercicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex05pag38ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex06PagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ex15pag16ToolStripMenuItem;
    }
}

