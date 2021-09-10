namespace Gestao_OT.UIFormularios
{
    partial class frmCategorias
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Id_Categoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Titulo_Categoria = new System.Windows.Forms.TextBox();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pesquisar = new System.Windows.Forms.TextBox();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.pnl_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Footer.Controls.Add(this.lbl_footer_Rigth);
            this.pnl_Footer.Controls.Add(this.lbl_footer_left);
            this.pnl_Footer.Location = new System.Drawing.Point(1, 232);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(728, 34);
            this.pnl_Footer.TabIndex = 7;
            // 
            // lbl_footer_Rigth
            // 
            this.lbl_footer_Rigth.AutoSize = true;
            this.lbl_footer_Rigth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_footer_Rigth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_footer_Rigth.Location = new System.Drawing.Point(611, 7);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID Categria:";
            // 
            // txt_Id_Categoria
            // 
            this.txt_Id_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id_Categoria.Location = new System.Drawing.Point(135, 12);
            this.txt_Id_Categoria.Name = "txt_Id_Categoria";
            this.txt_Id_Categoria.ReadOnly = true;
            this.txt_Id_Categoria.Size = new System.Drawing.Size(217, 21);
            this.txt_Id_Categoria.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Titulo categoria:";
            // 
            // txt_Titulo_Categoria
            // 
            this.txt_Titulo_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo_Categoria.Location = new System.Drawing.Point(135, 39);
            this.txt_Titulo_Categoria.Name = "txt_Titulo_Categoria";
            this.txt_Titulo_Categoria.Size = new System.Drawing.Size(217, 21);
            this.txt_Titulo_Categoria.TabIndex = 37;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(373, 48);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.Size = new System.Drawing.Size(348, 179);
            this.dgvCategoria.TabIndex = 38;
            this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(370, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pesquisar:";
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisar.Location = new System.Drawing.Point(458, 12);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(263, 21);
            this.txt_Pesquisar.TabIndex = 40;
            this.txt_Pesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Pesquisar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descricao.Location = new System.Drawing.Point(135, 66);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(217, 107);
            this.txt_Descricao.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Descrição:";
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.BackColor = System.Drawing.Color.Red;
            this.btn_Deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Deletar.Location = new System.Drawing.Point(287, 182);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(80, 43);
            this.btn_Deletar.TabIndex = 63;
            this.btn_Deletar.Text = "Deletar";
            this.btn_Deletar.UseVisualStyleBackColor = false;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.Yellow;
            this.btn_Atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.Location = new System.Drawing.Point(99, 183);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(96, 43);
            this.btn_Atualizar.TabIndex = 61;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.Lime;
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(1, 182);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(93, 43);
            this.btn_Add.TabIndex = 60;
            this.btn_Add.Text = "Cadastrar";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Limpar.Location = new System.Drawing.Point(201, 184);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(80, 43);
            this.btn_Limpar.TabIndex = 62;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 265);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.txt_Titulo_Categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Id_Categoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_Footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de categorias";
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label lbl_footer_Rigth;
        private System.Windows.Forms.Label lbl_footer_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Id_Categoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Titulo_Categoria;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pesquisar;
        private System.Windows.Forms.TextBox txt_Descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Limpar;
    }
}