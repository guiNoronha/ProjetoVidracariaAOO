namespace ProjetoVidracariaAOO
{
    partial class Form_CadVisita
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCadVisita = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNomeFuncionario = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btnAgendar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 61);
            this.panel1.TabIndex = 1;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgendar.Location = new System.Drawing.Point(521, 12);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(87, 36);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.Text = "Agendar";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(49)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.lblCadVisita);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 61);
            this.panel2.TabIndex = 3;
            // 
            // lblCadVisita
            // 
            this.lblCadVisita.AutoSize = true;
            this.lblCadVisita.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadVisita.Location = new System.Drawing.Point(125, 9);
            this.lblCadVisita.Name = "lblCadVisita";
            this.lblCadVisita.Size = new System.Drawing.Size(273, 42);
            this.lblCadVisita.TabIndex = 0;
            this.lblCadVisita.Text = "Agendar Visita";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(120, 100);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(396, 26);
            this.txtNomeCli.TabIndex = 4;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(38, 100);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(76, 23);
            this.lblNomeCli.TabIndex = 9;
            this.lblNomeCli.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(396, 26);
            this.textBox1.TabIndex = 10;
            // 
            // lblNomeFuncionario
            // 
            this.lblNomeFuncionario.AutoSize = true;
            this.lblNomeFuncionario.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeFuncionario.Location = new System.Drawing.Point(18, 171);
            this.lblNomeFuncionario.Name = "lblNomeFuncionario";
            this.lblNomeFuncionario.Size = new System.Drawing.Size(96, 23);
            this.lblNomeFuncionario.TabIndex = 11;
            this.lblNomeFuncionario.Text = "Consultor";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(59, 245);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 23);
            this.lblData.TabIndex = 12;
            this.lblData.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(396, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Form_CadVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(620, 380);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeFuncionario);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CadVisita";
            this.Text = "Form_CadVisita";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCadVisita;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNomeFuncionario;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}