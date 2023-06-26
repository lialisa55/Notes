namespace Notes.Forms
    {
    partial class Registrar
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
            this.label3 = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.Button();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.mtbSenha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(29, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Já tem uma conte logue aqui";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Registro
            // 
            this.Registro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registro.Location = new System.Drawing.Point(62, 200);
            this.Registro.Name = "Registro";
            this.Registro.Size = new System.Drawing.Size(84, 28);
            this.Registro.TabIndex = 9;
            this.Registro.Text = "Registrar";
            this.Registro.UseVisualStyleBackColor = true;
            this.Registro.Click += new System.EventHandler(this.Registro_Click);
            // 
            // TbUsername
            // 
            this.TbUsername.Location = new System.Drawing.Point(17, 106);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(172, 20);
            this.TbUsername.TabIndex = 8;
            // 
            // mtbSenha
            // 
            this.mtbSenha.Location = new System.Drawing.Point(17, 168);
            this.mtbSenha.Name = "mtbSenha";
            this.mtbSenha.PasswordChar = '*';
            this.mtbSenha.Size = new System.Drawing.Size(172, 20);
            this.mtbSenha.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.mtbSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Registrar";
            this.Text = "Registrar";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Registro;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.MaskedTextBox mtbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        }
    }