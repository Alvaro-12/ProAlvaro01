
namespace Alvaro01.VISTA
{
    partial class FrmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickAquiParaMasInformaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arreglosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.arreglosToolStripMenuItem,
            this.matematicasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickAquiParaMasInformaciónToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // clickAquiParaMasInformaciónToolStripMenuItem
            // 
            this.clickAquiParaMasInformaciónToolStripMenuItem.Name = "clickAquiParaMasInformaciónToolStripMenuItem";
            this.clickAquiParaMasInformaciónToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.clickAquiParaMasInformaciónToolStripMenuItem.Text = "Click aqui para mas información";
            this.clickAquiParaMasInformaciónToolStripMenuItem.Click += new System.EventHandler(this.clickAquiParaMasInformaciónToolStripMenuItem_Click);
            // 
            // arreglosToolStripMenuItem
            // 
            this.arreglosToolStripMenuItem.Name = "arreglosToolStripMenuItem";
            this.arreglosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.arreglosToolStripMenuItem.Text = "Arreglos";
            this.arreglosToolStripMenuItem.Click += new System.EventHandler(this.arreglosToolStripMenuItem_Click);
            // 
            // matematicasToolStripMenuItem
            // 
            this.matematicasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumasToolStripMenuItem,
            this.restasToolStripMenuItem});
            this.matematicasToolStripMenuItem.Name = "matematicasToolStripMenuItem";
            this.matematicasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.matematicasToolStripMenuItem.Text = "Matematicas";
            // 
            // sumasToolStripMenuItem
            // 
            this.sumasToolStripMenuItem.Name = "sumasToolStripMenuItem";
            this.sumasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sumasToolStripMenuItem.Text = "Sumas";
            this.sumasToolStripMenuItem.Click += new System.EventHandler(this.sumasToolStripMenuItem_Click);
            // 
            // restasToolStripMenuItem
            // 
            this.restasToolStripMenuItem.Name = "restasToolStripMenuItem";
            this.restasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restasToolStripMenuItem.Text = "Restas";
            this.restasToolStripMenuItem.Click += new System.EventHandler(this.restasToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(793, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickAquiParaMasInformaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arreglosToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem matematicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restasToolStripMenuItem;
    }
}