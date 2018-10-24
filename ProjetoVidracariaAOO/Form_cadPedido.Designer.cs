namespace ProjetoVidracariaAOO
{
    partial class Form_cadPedido
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadPedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGerarNota = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_emEstoque = new System.Windows.Forms.TextBox();
            this.txt_noPedido = new System.Windows.Forms.TextBox();
            this.btn_adicionarProduto = new System.Windows.Forms.Button();
            this.btn_removerProduto = new System.Windows.Forms.Button();
            this.lblEmEstoque = new System.Windows.Forms.Label();
            this.lblNoPedido = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lblCadPedido);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 61);
            this.panel2.TabIndex = 4;
            // 
            // lblCadPedido
            // 
            this.lblCadPedido.AutoSize = true;
            this.lblCadPedido.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadPedido.Location = new System.Drawing.Point(125, 9);
            this.lblCadPedido.Name = "lblCadPedido";
            this.lblCadPedido.Size = new System.Drawing.Size(242, 42);
            this.lblCadPedido.TabIndex = 0;
            this.lblCadPedido.Text = "Novo Pedido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnGerarNota);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 61);
            this.panel1.TabIndex = 5;
            // 
            // btnGerarNota
            // 
            this.btnGerarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarNota.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarNota.Location = new System.Drawing.Point(500, 12);
            this.btnGerarNota.Name = "btnGerarNota";
            this.btnGerarNota.Size = new System.Drawing.Size(108, 36);
            this.btnGerarNota.TabIndex = 3;
            this.btnGerarNota.Text = "Gerar Nota";
            this.btnGerarNota.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::ProjetoVidracariaAOO.Properties.Resources.back;
            this.btnVoltar.Location = new System.Drawing.Point(12, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(35, 33);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 178);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(367, 100);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 178);
            this.dataGridView2.TabIndex = 7;
            // 
            // txt_emEstoque
            // 
            this.txt_emEstoque.Location = new System.Drawing.Point(13, 284);
            this.txt_emEstoque.Name = "txt_emEstoque";
            this.txt_emEstoque.Size = new System.Drawing.Size(240, 20);
            this.txt_emEstoque.TabIndex = 8;
            // 
            // txt_noPedido
            // 
            this.txt_noPedido.Location = new System.Drawing.Point(366, 284);
            this.txt_noPedido.Name = "txt_noPedido";
            this.txt_noPedido.Size = new System.Drawing.Size(241, 20);
            this.txt_noPedido.TabIndex = 9;
            // 
            // btn_adicionarProduto
            // 
            this.btn_adicionarProduto.Location = new System.Drawing.Point(271, 140);
            this.btn_adicionarProduto.Name = "btn_adicionarProduto";
            this.btn_adicionarProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_adicionarProduto.TabIndex = 10;
            this.btn_adicionarProduto.Text = "+";
            this.btn_adicionarProduto.UseVisualStyleBackColor = true;
            // 
            // btn_removerProduto
            // 
            this.btn_removerProduto.Location = new System.Drawing.Point(271, 169);
            this.btn_removerProduto.Name = "btn_removerProduto";
            this.btn_removerProduto.Size = new System.Drawing.Size(75, 23);
            this.btn_removerProduto.TabIndex = 11;
            this.btn_removerProduto.Text = "-";
            this.btn_removerProduto.UseVisualStyleBackColor = true;
            // 
            // lblEmEstoque
            // 
            this.lblEmEstoque.AutoSize = true;
            this.lblEmEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmEstoque.Location = new System.Drawing.Point(12, 77);
            this.lblEmEstoque.Name = "lblEmEstoque";
            this.lblEmEstoque.Size = new System.Drawing.Size(107, 20);
            this.lblEmEstoque.TabIndex = 12;
            this.lblEmEstoque.Text = "Em Estoque";
            // 
            // lblNoPedido
            // 
            this.lblNoPedido.AutoSize = true;
            this.lblNoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoPedido.Location = new System.Drawing.Point(363, 77);
            this.lblNoPedido.Name = "lblNoPedido";
            this.lblNoPedido.Size = new System.Drawing.Size(91, 20);
            this.lblNoPedido.TabIndex = 13;
            this.lblNoPedido.Text = "No Pedido";
            // 
            // Form_cadPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.lblNoPedido);
            this.Controls.Add(this.lblEmEstoque);
            this.Controls.Add(this.btn_removerProduto);
            this.Controls.Add(this.btn_adicionarProduto);
            this.Controls.Add(this.txt_noPedido);
            this.Controls.Add(this.txt_emEstoque);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cadPedido";
            this.Text = "Form_cadPedido";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGerarNota;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txt_emEstoque;
        private System.Windows.Forms.TextBox txt_noPedido;
        private System.Windows.Forms.Button btn_adicionarProduto;
        private System.Windows.Forms.Button btn_removerProduto;
        private System.Windows.Forms.Label lblEmEstoque;
        private System.Windows.Forms.Label lblNoPedido;
    }
}