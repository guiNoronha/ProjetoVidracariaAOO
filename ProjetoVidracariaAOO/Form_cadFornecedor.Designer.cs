namespace ProjetoVidracariaAOO
{
    partial class Form_cadFornecedor
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
            this.lblCadClie = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.lblNomeForn = new System.Windows.Forms.Label();
            this.txtNomeForn = new System.Windows.Forms.TextBox();
            this.txtCepForn = new System.Windows.Forms.TextBox();
            this.lblCepForn = new System.Windows.Forms.Label();
            this.txtBairroForn = new System.Windows.Forms.TextBox();
            this.lblBairroForn = new System.Windows.Forms.Label();
            this.txtNroForn = new System.Windows.Forms.TextBox();
            this.lblNroForn = new System.Windows.Forms.Label();
            this.txtRuaForn = new System.Windows.Forms.TextBox();
            this.lblRuaForn = new System.Windows.Forms.Label();
            this.txtTelForn = new System.Windows.Forms.TextBox();
            this.lblTelForn = new System.Windows.Forms.Label();
            this.txtEmailForn = new System.Windows.Forms.TextBox();
            this.lblEmailForn = new System.Windows.Forms.Label();
            this.txtCnpjForn = new System.Windows.Forms.TextBox();
            this.lblCnpj = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.btnListarForn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lblCadClie);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 61);
            this.panel2.TabIndex = 2;
            // 
            // lblCadClie
            // 
            this.lblCadClie.AutoSize = true;
            this.lblCadClie.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadClie.Location = new System.Drawing.Point(93, 9);
            this.lblCadClie.Name = "lblCadClie";
            this.lblCadClie.Size = new System.Drawing.Size(445, 42);
            this.lblCadClie.TabIndex = 0;
            this.lblCadClie.Text = "Cadastro de Fornecedor";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnListarForn);
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(-3, 321);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 61);
            this.panel1.TabIndex = 3;
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCriar.Location = new System.Drawing.Point(524, 11);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(87, 36);
            this.btnCriar.TabIndex = 4;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblNomeForn
            // 
            this.lblNomeForn.AutoSize = true;
            this.lblNomeForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeForn.Location = new System.Drawing.Point(56, 85);
            this.lblNomeForn.Name = "lblNomeForn";
            this.lblNomeForn.Size = new System.Drawing.Size(66, 23);
            this.lblNomeForn.TabIndex = 10;
            this.lblNomeForn.Text = "Nome";
            this.lblNomeForn.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeForn
            // 
            this.txtNomeForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeForn.Location = new System.Drawing.Point(128, 85);
            this.txtNomeForn.Name = "txtNomeForn";
            this.txtNomeForn.Size = new System.Drawing.Size(396, 26);
            this.txtNomeForn.TabIndex = 9;
            this.txtNomeForn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtCepForn
            // 
            this.txtCepForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepForn.Location = new System.Drawing.Point(128, 173);
            this.txtCepForn.Name = "txtCepForn";
            this.txtCepForn.Size = new System.Drawing.Size(160, 26);
            this.txtCepForn.TabIndex = 18;
            this.txtCepForn.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblCepForn
            // 
            this.lblCepForn.AutoSize = true;
            this.lblCepForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepForn.Location = new System.Drawing.Point(76, 176);
            this.lblCepForn.Name = "lblCepForn";
            this.lblCepForn.Size = new System.Drawing.Size(46, 23);
            this.lblCepForn.TabIndex = 17;
            this.lblCepForn.Text = "CEP";
            this.lblCepForn.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtBairroForn
            // 
            this.txtBairroForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroForn.Location = new System.Drawing.Point(397, 173);
            this.txtBairroForn.Name = "txtBairroForn";
            this.txtBairroForn.Size = new System.Drawing.Size(127, 26);
            this.txtBairroForn.TabIndex = 20;
            // 
            // lblBairroForn
            // 
            this.lblBairroForn.AutoSize = true;
            this.lblBairroForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroForn.Location = new System.Drawing.Point(329, 176);
            this.lblBairroForn.Name = "lblBairroForn";
            this.lblBairroForn.Size = new System.Drawing.Size(63, 23);
            this.lblBairroForn.TabIndex = 19;
            this.lblBairroForn.Text = "Bairro";
            // 
            // txtNroForn
            // 
            this.txtNroForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroForn.Location = new System.Drawing.Point(449, 219);
            this.txtNroForn.Name = "txtNroForn";
            this.txtNroForn.Size = new System.Drawing.Size(75, 26);
            this.txtNroForn.TabIndex = 24;
            // 
            // lblNroForn
            // 
            this.lblNroForn.AutoSize = true;
            this.lblNroForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroForn.Location = new System.Drawing.Point(416, 219);
            this.lblNroForn.Name = "lblNroForn";
            this.lblNroForn.Size = new System.Drawing.Size(31, 23);
            this.lblNroForn.TabIndex = 23;
            this.lblNroForn.Text = "Nº";
            // 
            // txtRuaForn
            // 
            this.txtRuaForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaForn.Location = new System.Drawing.Point(128, 222);
            this.txtRuaForn.Name = "txtRuaForn";
            this.txtRuaForn.Size = new System.Drawing.Size(263, 26);
            this.txtRuaForn.TabIndex = 22;
            // 
            // lblRuaForn
            // 
            this.lblRuaForn.AutoSize = true;
            this.lblRuaForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaForn.Location = new System.Drawing.Point(74, 222);
            this.lblRuaForn.Name = "lblRuaForn";
            this.lblRuaForn.Size = new System.Drawing.Size(45, 23);
            this.lblRuaForn.TabIndex = 21;
            this.lblRuaForn.Text = "Rua";
            // 
            // txtTelForn
            // 
            this.txtTelForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelForn.Location = new System.Drawing.Point(397, 129);
            this.txtTelForn.Name = "txtTelForn";
            this.txtTelForn.Size = new System.Drawing.Size(127, 26);
            this.txtTelForn.TabIndex = 26;
            // 
            // lblTelForn
            // 
            this.lblTelForn.AutoSize = true;
            this.lblTelForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelForn.Location = new System.Drawing.Point(305, 129);
            this.lblTelForn.Name = "lblTelForn";
            this.lblTelForn.Size = new System.Drawing.Size(87, 23);
            this.lblTelForn.TabIndex = 25;
            this.lblTelForn.Text = "Telefone";
            // 
            // txtEmailForn
            // 
            this.txtEmailForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailForn.Location = new System.Drawing.Point(127, 266);
            this.txtEmailForn.Name = "txtEmailForn";
            this.txtEmailForn.Size = new System.Drawing.Size(396, 26);
            this.txtEmailForn.TabIndex = 28;
            // 
            // lblEmailForn
            // 
            this.lblEmailForn.AutoSize = true;
            this.lblEmailForn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailForn.Location = new System.Drawing.Point(56, 266);
            this.lblEmailForn.Name = "lblEmailForn";
            this.lblEmailForn.Size = new System.Drawing.Size(61, 23);
            this.lblEmailForn.TabIndex = 27;
            this.lblEmailForn.Text = "Email";
            // 
            // txtCnpjForn
            // 
            this.txtCnpjForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCnpjForn.Location = new System.Drawing.Point(127, 129);
            this.txtCnpjForn.Name = "txtCnpjForn";
            this.txtCnpjForn.Size = new System.Drawing.Size(160, 26);
            this.txtCnpjForn.TabIndex = 30;
            // 
            // lblCnpj
            // 
            this.lblCnpj.AutoSize = true;
            this.lblCnpj.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCnpj.Location = new System.Drawing.Point(60, 132);
            this.lblCnpj.Name = "lblCnpj";
            this.lblCnpj.Size = new System.Drawing.Size(59, 23);
            this.lblCnpj.TabIndex = 29;
            this.lblCnpj.Text = "CNPJ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::ProjetoVidracariaAOO.Properties.Resources.back;
            this.btnVoltar.Location = new System.Drawing.Point(15, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(35, 33);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnListarForn
            // 
            this.btnListarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarForn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarForn.Location = new System.Drawing.Point(269, 12);
            this.btnListarForn.Name = "btnListarForn";
            this.btnListarForn.Size = new System.Drawing.Size(87, 36);
            this.btnListarForn.TabIndex = 5;
            this.btnListarForn.Text = "Listar";
            this.btnListarForn.UseVisualStyleBackColor = true;
            // 
            // Form_cadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.txtCnpjForn);
            this.Controls.Add(this.lblCnpj);
            this.Controls.Add(this.txtEmailForn);
            this.Controls.Add(this.lblEmailForn);
            this.Controls.Add(this.txtTelForn);
            this.Controls.Add(this.lblTelForn);
            this.Controls.Add(this.txtNroForn);
            this.Controls.Add(this.lblNroForn);
            this.Controls.Add(this.txtRuaForn);
            this.Controls.Add(this.lblRuaForn);
            this.Controls.Add(this.txtBairroForn);
            this.Controls.Add(this.lblBairroForn);
            this.Controls.Add(this.txtCepForn);
            this.Controls.Add(this.lblCepForn);
            this.Controls.Add(this.lblNomeForn);
            this.Controls.Add(this.txtNomeForn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cadFornecedor";
            this.Text = "Form_cadFornecedor";
            this.Load += new System.EventHandler(this.Form_cadFornecedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadClie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label lblNomeForn;
        private System.Windows.Forms.TextBox txtNomeForn;
        private System.Windows.Forms.TextBox txtCepForn;
        private System.Windows.Forms.Label lblCepForn;
        private System.Windows.Forms.TextBox txtBairroForn;
        private System.Windows.Forms.Label lblBairroForn;
        private System.Windows.Forms.TextBox txtNroForn;
        private System.Windows.Forms.Label lblNroForn;
        private System.Windows.Forms.TextBox txtRuaForn;
        private System.Windows.Forms.Label lblRuaForn;
        private System.Windows.Forms.TextBox txtTelForn;
        private System.Windows.Forms.Label lblTelForn;
        private System.Windows.Forms.TextBox txtEmailForn;
        private System.Windows.Forms.Label lblEmailForn;
        private System.Windows.Forms.TextBox txtCnpjForn;
        private System.Windows.Forms.Label lblCnpj;
        private System.Windows.Forms.Button btnListarForn;
    }
}