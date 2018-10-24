namespace ProjetoVidracariaAOO
{
    partial class Form_listVisitas
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
            this.lblListVisita = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_VerConcluidas = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_novaVisita = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.dataGridView_Visitas = new System.Windows.Forms.DataGridView();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_GerarOrcamento = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visitas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lblListVisita);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 61);
            this.panel2.TabIndex = 2;
            // 
            // lblListVisita
            // 
            this.lblListVisita.AutoSize = true;
            this.lblListVisita.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListVisita.Location = new System.Drawing.Point(125, 9);
            this.lblListVisita.Name = "lblListVisita";
            this.lblListVisita.Size = new System.Drawing.Size(338, 42);
            this.lblListVisita.TabIndex = 0;
            this.lblListVisita.Text = "Visitas Agendadas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btn_GerarOrcamento);
            this.panel1.Controls.Add(this.btn_VerConcluidas);
            this.panel1.Controls.Add(this.btn_Alterar);
            this.panel1.Controls.Add(this.btn_novaVisita);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 61);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_VerConcluidas
            // 
            this.btn_VerConcluidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerConcluidas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_VerConcluidas.Location = new System.Drawing.Point(215, 12);
            this.btn_VerConcluidas.Name = "btn_VerConcluidas";
            this.btn_VerConcluidas.Size = new System.Drawing.Size(127, 36);
            this.btn_VerConcluidas.TabIndex = 6;
            this.btn_VerConcluidas.Text = "Ver Concluidas";
            this.btn_VerConcluidas.UseVisualStyleBackColor = true;
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Alterar.Location = new System.Drawing.Point(348, 12);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(127, 36);
            this.btn_Alterar.TabIndex = 5;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = true;
            // 
            // btn_novaVisita
            // 
            this.btn_novaVisita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_novaVisita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_novaVisita.Location = new System.Drawing.Point(481, 12);
            this.btn_novaVisita.Name = "btn_novaVisita";
            this.btn_novaVisita.Size = new System.Drawing.Size(127, 36);
            this.btn_novaVisita.TabIndex = 4;
            this.btn_novaVisita.Text = "Nova Visita";
            this.btn_novaVisita.UseVisualStyleBackColor = true;
            this.btn_novaVisita.Click += new System.EventHandler(this.btn_novaVisita_Click);
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
            // dataGridView_Visitas
            // 
            this.dataGridView_Visitas.AllowUserToAddRows = false;
            this.dataGridView_Visitas.AllowUserToDeleteRows = false;
            this.dataGridView_Visitas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dataGridView_Visitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Visitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliente,
            this.endereco,
            this.date,
            this.consultor,
            this.status});
            this.dataGridView_Visitas.Location = new System.Drawing.Point(0, 61);
            this.dataGridView_Visitas.Name = "dataGridView_Visitas";
            this.dataGridView_Visitas.RowHeadersVisible = false;
            this.dataGridView_Visitas.Size = new System.Drawing.Size(620, 258);
            this.dataGridView_Visitas.TabIndex = 4;
            // 
            // cliente
            // 
            this.cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // endereco
            // 
            this.endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endereco.FillWeight = 150F;
            this.endereco.HeaderText = "Endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.FillWeight = 75F;
            this.date.HeaderText = "Data";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // consultor
            // 
            this.consultor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.consultor.HeaderText = "Consultor";
            this.consultor.Name = "consultor";
            this.consultor.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 43;
            // 
            // btn_GerarOrcamento
            // 
            this.btn_GerarOrcamento.Enabled = false;
            this.btn_GerarOrcamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GerarOrcamento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_GerarOrcamento.Location = new System.Drawing.Point(82, 12);
            this.btn_GerarOrcamento.Name = "btn_GerarOrcamento";
            this.btn_GerarOrcamento.Size = new System.Drawing.Size(127, 36);
            this.btn_GerarOrcamento.TabIndex = 7;
            this.btn_GerarOrcamento.Text = "Orçamento";
            this.btn_GerarOrcamento.UseVisualStyleBackColor = true;
            // 
            // Form_listVisitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.dataGridView_Visitas);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_listVisitas";
            this.Text = "Form_listVisitas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblListVisita;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.DataGridView dataGridView_Visitas;
        private System.Windows.Forms.Button btn_novaVisita;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_VerConcluidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn status;
        private System.Windows.Forms.Button btn_GerarOrcamento;
    }
}