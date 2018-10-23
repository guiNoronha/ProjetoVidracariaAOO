namespace ProjetoVidracariaAOO
{
    partial class Form_listClientes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.lblListClie = new System.Windows.Forms.Label();
            this.dataGridView_Clientes = new System.Windows.Forms.DataGridView();
            this.cli_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cli_endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_clienteAtualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.lblListClie);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.btn_clienteAtualizar);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Location = new System.Drawing.Point(0, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::ProjetoVidracariaAOO.Properties.Resources.back;
            this.btnVoltar.Location = new System.Drawing.Point(12, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(35, 33);
            this.btnVoltar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblListClie
            // 
            this.lblListClie.AutoSize = true;
            this.lblListClie.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListClie.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblListClie.Location = new System.Drawing.Point(134, 9);
            this.lblListClie.Name = "lblListClie";
            this.lblListClie.Size = new System.Drawing.Size(389, 42);
            this.lblListClie.TabIndex = 1;
            this.lblListClie.Text = "Clientes Cadastrados";
            this.lblListClie.Click += new System.EventHandler(this.lblCadClie_Click);
            // 
            // dataGridView_Clientes
            // 
            this.dataGridView_Clientes.AllowUserToAddRows = false;
            this.dataGridView_Clientes.AllowUserToDeleteRows = false;
            this.dataGridView_Clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dataGridView_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Clientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cli_name,
            this.cli_cpf,
            this.cli_endereco});
            this.dataGridView_Clientes.Location = new System.Drawing.Point(1, 61);
            this.dataGridView_Clientes.Name = "dataGridView_Clientes";
            this.dataGridView_Clientes.RowHeadersVisible = false;
            this.dataGridView_Clientes.Size = new System.Drawing.Size(620, 258);
            this.dataGridView_Clientes.TabIndex = 2;
            // 
            // cli_name
            // 
            this.cli_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_name.HeaderText = "Nome";
            this.cli_name.Name = "cli_name";
            this.cli_name.ReadOnly = true;
            // 
            // cli_cpf
            // 
            this.cli_cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_cpf.HeaderText = "CPF";
            this.cli_cpf.Name = "cli_cpf";
            this.cli_cpf.ReadOnly = true;
            // 
            // cli_endereco
            // 
            this.cli_endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cli_endereco.HeaderText = "Endereco";
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            // 
            // btn_clienteAtualizar
            // 
            this.btn_clienteAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_clienteAtualizar.Location = new System.Drawing.Point(521, 12);
            this.btn_clienteAtualizar.Name = "btn_clienteAtualizar";
            this.btn_clienteAtualizar.Size = new System.Drawing.Size(87, 36);
            this.btn_clienteAtualizar.TabIndex = 4;
            this.btn_clienteAtualizar.Text = "Atualizar";
            this.btn_clienteAtualizar.UseVisualStyleBackColor = true;
            // 
            // Form_listClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.dataGridView_Clientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_listClientes";
            this.Text = "Form_listClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Label lblListClie;
        private System.Windows.Forms.DataGridView dataGridView_Clientes;
        private System.Windows.Forms.Button btn_clienteAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cli_endereco;
    }
}