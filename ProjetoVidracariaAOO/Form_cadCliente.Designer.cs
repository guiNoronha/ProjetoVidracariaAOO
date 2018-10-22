namespace ProjetoVidracariaAOO
{
    partial class Form_cadCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCriar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadClie = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblCpfCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.lblRuaCli = new System.Windows.Forms.Label();
            this.lblCepCli = new System.Windows.Forms.Label();
            this.lblBairroCli = new System.Windows.Forms.Label();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.txtCpfCli = new System.Windows.Forms.TextBox();
            this.txtTelCli = new System.Windows.Forms.TextBox();
            this.txtCepCli = new System.Windows.Forms.TextBox();
            this.txtBairroCli = new System.Windows.Forms.TextBox();
            this.txtRuaCli = new System.Windows.Forms.TextBox();
            this.lblNroCli = new System.Windows.Forms.Label();
            this.txtNroCli = new System.Windows.Forms.TextBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.btnListarCli = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnListarCli);
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 61);
            this.panel1.TabIndex = 0;
            // 
            // btnCriar
            // 
            this.btnCriar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCriar.Location = new System.Drawing.Point(521, 12);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(87, 36);
            this.btnCriar.TabIndex = 3;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lblCadClie);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 61);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblCadClie
            // 
            this.lblCadClie.AutoSize = true;
            this.lblCadClie.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadClie.Location = new System.Drawing.Point(125, 9);
            this.lblCadClie.Name = "lblCadClie";
            this.lblCadClie.Size = new System.Drawing.Size(370, 42);
            this.lblCadClie.TabIndex = 0;
            this.lblCadClie.Text = "Cadastro de Cliente";
            this.lblCadClie.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(120, 84);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(396, 26);
            this.txtNomeCli.TabIndex = 0;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(48, 84);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(66, 23);
            this.lblNomeCli.TabIndex = 8;
            this.lblNomeCli.Text = "Nome";
            // 
            // lblCpfCli
            // 
            this.lblCpfCli.AutoSize = true;
            this.lblCpfCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfCli.Location = new System.Drawing.Point(65, 135);
            this.lblCpfCli.Name = "lblCpfCli";
            this.lblCpfCli.Size = new System.Drawing.Size(45, 23);
            this.lblCpfCli.TabIndex = 9;
            this.lblCpfCli.Text = "CPF";
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelCli.Location = new System.Drawing.Point(296, 135);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(87, 23);
            this.lblTelCli.TabIndex = 10;
            this.lblTelCli.Text = "Telefone";
            // 
            // lblRuaCli
            // 
            this.lblRuaCli.AutoSize = true;
            this.lblRuaCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuaCli.Location = new System.Drawing.Point(66, 234);
            this.lblRuaCli.Name = "lblRuaCli";
            this.lblRuaCli.Size = new System.Drawing.Size(45, 23);
            this.lblRuaCli.TabIndex = 11;
            this.lblRuaCli.Text = "Rua";
            // 
            // lblCepCli
            // 
            this.lblCepCli.AutoSize = true;
            this.lblCepCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCepCli.Location = new System.Drawing.Point(65, 183);
            this.lblCepCli.Name = "lblCepCli";
            this.lblCepCli.Size = new System.Drawing.Size(46, 23);
            this.lblCepCli.TabIndex = 12;
            this.lblCepCli.Text = "CEP";
            // 
            // lblBairroCli
            // 
            this.lblBairroCli.AutoSize = true;
            this.lblBairroCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairroCli.Location = new System.Drawing.Point(320, 183);
            this.lblBairroCli.Name = "lblBairroCli";
            this.lblBairroCli.Size = new System.Drawing.Size(63, 23);
            this.lblBairroCli.TabIndex = 13;
            this.lblBairroCli.Text = "Bairro";
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCli.Location = new System.Drawing.Point(49, 277);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(61, 23);
            this.lblEmailCli.TabIndex = 14;
            this.lblEmailCli.Text = "Email";
            // 
            // txtCpfCli
            // 
            this.txtCpfCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCli.Location = new System.Drawing.Point(120, 132);
            this.txtCpfCli.Name = "txtCpfCli";
            this.txtCpfCli.Size = new System.Drawing.Size(160, 26);
            this.txtCpfCli.TabIndex = 14;
            // 
            // txtTelCli
            // 
            this.txtTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCli.Location = new System.Drawing.Point(389, 132);
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(127, 26);
            this.txtTelCli.TabIndex = 15;
            // 
            // txtCepCli
            // 
            this.txtCepCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepCli.Location = new System.Drawing.Point(120, 183);
            this.txtCepCli.Name = "txtCepCli";
            this.txtCepCli.Size = new System.Drawing.Size(160, 26);
            this.txtCepCli.TabIndex = 16;
            // 
            // txtBairroCli
            // 
            this.txtBairroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroCli.Location = new System.Drawing.Point(389, 180);
            this.txtBairroCli.Name = "txtBairroCli";
            this.txtBairroCli.Size = new System.Drawing.Size(127, 26);
            this.txtBairroCli.TabIndex = 17;
            // 
            // txtRuaCli
            // 
            this.txtRuaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuaCli.Location = new System.Drawing.Point(120, 234);
            this.txtRuaCli.Name = "txtRuaCli";
            this.txtRuaCli.Size = new System.Drawing.Size(263, 26);
            this.txtRuaCli.TabIndex = 18;
            // 
            // lblNroCli
            // 
            this.lblNroCli.AutoSize = true;
            this.lblNroCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroCli.Location = new System.Drawing.Point(408, 231);
            this.lblNroCli.Name = "lblNroCli";
            this.lblNroCli.Size = new System.Drawing.Size(31, 23);
            this.lblNroCli.TabIndex = 19;
            this.lblNroCli.Text = "Nº";
            // 
            // txtNroCli
            // 
            this.txtNroCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroCli.Location = new System.Drawing.Point(441, 231);
            this.txtNroCli.Name = "txtNroCli";
            this.txtNroCli.Size = new System.Drawing.Size(75, 26);
            this.txtNroCli.TabIndex = 20;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailCli.Location = new System.Drawing.Point(120, 277);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(396, 26);
            this.txtEmailCli.TabIndex = 22;
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
            // btnListarCli
            // 
            this.btnListarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarCli.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarCli.Location = new System.Drawing.Point(268, 12);
            this.btnListarCli.Name = "btnListarCli";
            this.btnListarCli.Size = new System.Drawing.Size(87, 36);
            this.btnListarCli.TabIndex = 4;
            this.btnListarCli.Text = "Listar";
            this.btnListarCli.UseVisualStyleBackColor = true;
            // 
            // Form_cadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.txtEmailCli);
            this.Controls.Add(this.lblEmailCli);
            this.Controls.Add(this.txtNroCli);
            this.Controls.Add(this.lblNroCli);
            this.Controls.Add(this.txtRuaCli);
            this.Controls.Add(this.txtBairroCli);
            this.Controls.Add(this.txtCepCli);
            this.Controls.Add(this.txtTelCli);
            this.Controls.Add(this.txtCpfCli);
            this.Controls.Add(this.lblBairroCli);
            this.Controls.Add(this.lblCepCli);
            this.Controls.Add(this.lblRuaCli);
            this.Controls.Add(this.lblTelCli);
            this.Controls.Add(this.lblCpfCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_cadCliente";
            this.Text = "Form_cadCliente";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadClie;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblCpfCli;
        private System.Windows.Forms.Label lblTelCli;
        private System.Windows.Forms.Label lblRuaCli;
        private System.Windows.Forms.Label lblCepCli;
        private System.Windows.Forms.Label lblBairroCli;
        private System.Windows.Forms.Label lblEmailCli;
        private System.Windows.Forms.TextBox txtCpfCli;
        private System.Windows.Forms.TextBox txtTelCli;
        private System.Windows.Forms.TextBox txtCepCli;
        private System.Windows.Forms.TextBox txtBairroCli;
        private System.Windows.Forms.TextBox txtRuaCli;
        private System.Windows.Forms.Label lblNroCli;
        private System.Windows.Forms.TextBox txtNroCli;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnListarCli;
    }
}