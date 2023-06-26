
namespace Notes.Forms
{
    partial class nota
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
            this.mtbTitulo = new System.Windows.Forms.MaskedTextBox();
            this.rtbConteudo = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtbTitulo
            // 
            this.mtbTitulo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbTitulo.Location = new System.Drawing.Point(13, 6);
            this.mtbTitulo.Name = "mtbTitulo";
            this.mtbTitulo.Size = new System.Drawing.Size(318, 44);
            this.mtbTitulo.TabIndex = 1;
            // 
            // rtbConteudo
            // 
            this.rtbConteudo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConteudo.Location = new System.Drawing.Point(12, 56);
            this.rtbConteudo.Name = "rtbConteudo";
            this.rtbConteudo.Size = new System.Drawing.Size(319, 415);
            this.rtbConteudo.TabIndex = 0;
            this.rtbConteudo.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(256, 477);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 477);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 503);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtbTitulo);
            this.Controls.Add(this.rtbConteudo);
            this.Name = "nota";
            this.Text = "nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtbTitulo;
        private System.Windows.Forms.RichTextBox rtbConteudo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}