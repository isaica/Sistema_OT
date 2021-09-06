namespace Gestao_OT.UIFormularios
{
    partial class frmUserDashboard
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
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.lbl_footer_Rigth = new System.Windows.Forms.Label();
            this.lbl_footer_left = new System.Windows.Forms.Label();
            this.lbl_Loged_User = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_User = new System.Windows.Forms.Label();
            this.pnl_Footer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Footer.Controls.Add(this.lbl_footer_Rigth);
            this.pnl_Footer.Controls.Add(this.lbl_footer_left);
            this.pnl_Footer.Location = new System.Drawing.Point(0, 230);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(554, 34);
            this.pnl_Footer.TabIndex = 8;
            // 
            // lbl_footer_Rigth
            // 
            this.lbl_footer_Rigth.AutoSize = true;
            this.lbl_footer_Rigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer_Rigth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_footer_Rigth.Location = new System.Drawing.Point(433, 7);
            this.lbl_footer_Rigth.Name = "lbl_footer_Rigth";
            this.lbl_footer_Rigth.Size = new System.Drawing.Size(109, 20);
            this.lbl_footer_Rigth.TabIndex = 3;
            this.lbl_footer_Rigth.Text = "Osland Tech";
            // 
            // lbl_footer_left
            // 
            this.lbl_footer_left.AutoSize = true;
            this.lbl_footer_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_footer_left.Location = new System.Drawing.Point(12, 10);
            this.lbl_footer_left.Name = "lbl_footer_left";
            this.lbl_footer_left.Size = new System.Drawing.Size(182, 15);
            this.lbl_footer_left.TabIndex = 1;
            this.lbl_footer_left.Text = "S⁫istema criado por Osland Tech";
            // 
            // lbl_Loged_User
            // 
            this.lbl_Loged_User.AutoSize = true;
            this.lbl_Loged_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Loged_User.ForeColor = System.Drawing.Color.Red;
            this.lbl_Loged_User.Location = new System.Drawing.Point(12, 145);
            this.lbl_Loged_User.Name = "lbl_Loged_User";
            this.lbl_Loged_User.Size = new System.Drawing.Size(249, 18);
            this.lbl_Loged_User.TabIndex = 11;
            this.lbl_Loged_User.Text = "923736371 | oslandtech@gmail.com";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.usuárioToolStripMenuItem.Text = "Comprar";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.categoriaToolStripMenuItem.Text = "Venda";
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ForeColor = System.Drawing.Color.Red;
            this.lbl_User.Location = new System.Drawing.Point(12, 117);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(133, 18);
            this.lbl_User.TabIndex = 10;
            this.lbl_User.Text = "Sistema de vendas";
            // 
            // frmUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(554, 265);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.lbl_Loged_User);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User: Dashboard";
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_footer_Rigth;
        private System.Windows.Forms.Label lbl_footer_left;
        private System.Windows.Forms.Label lbl_Loged_User;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.Label lbl_User;
    }
}