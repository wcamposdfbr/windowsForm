
namespace CursoWindowsForm
{
    partial class Frm_Mascara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mascara));
            this.Msk_TextBox = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Conteudo = new System.Windows.Forms.Label();
            this.Lbl_MascaraAtiva = new System.Windows.Forms.Label();
            this.Btn_Hora = new System.Windows.Forms.Button();
            this.Btn_Cep = new System.Windows.Forms.Button();
            this.Btn_Moeda = new System.Windows.Forms.Button();
            this.Btn_Data = new System.Windows.Forms.Button();
            this.Btn_Senha = new System.Windows.Forms.Button();
            this.Btn_Telefone = new System.Windows.Forms.Button();
            this.Btn_VerConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_TextBox
            // 
            this.Msk_TextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msk_TextBox.Location = new System.Drawing.Point(22, 41);
            this.Msk_TextBox.Name = "Msk_TextBox";
            this.Msk_TextBox.Size = new System.Drawing.Size(304, 35);
            this.Msk_TextBox.TabIndex = 0;
            // 
            // Lbl_Conteudo
            // 
            this.Lbl_Conteudo.AutoSize = true;
            this.Lbl_Conteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Conteudo.Location = new System.Drawing.Point(22, 318);
            this.Lbl_Conteudo.Name = "Lbl_Conteudo";
            this.Lbl_Conteudo.Size = new System.Drawing.Size(176, 29);
            this.Lbl_Conteudo.TabIndex = 1;
            this.Lbl_Conteudo.Text = "Lbl_Conteudo";
            // 
            // Lbl_MascaraAtiva
            // 
            this.Lbl_MascaraAtiva.AutoSize = true;
            this.Lbl_MascaraAtiva.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_MascaraAtiva.Location = new System.Drawing.Point(22, 92);
            this.Lbl_MascaraAtiva.Name = "Lbl_MascaraAtiva";
            this.Lbl_MascaraAtiva.Size = new System.Drawing.Size(180, 29);
            this.Lbl_MascaraAtiva.TabIndex = 2;
            this.Lbl_MascaraAtiva.Text = "Lbl_MascaraAtiva";
            // 
            // Btn_Hora
            // 
            this.Btn_Hora.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Hora.Location = new System.Drawing.Point(22, 139);
            this.Btn_Hora.Name = "Btn_Hora";
            this.Btn_Hora.Size = new System.Drawing.Size(99, 50);
            this.Btn_Hora.TabIndex = 3;
            this.Btn_Hora.Text = "Hora";
            this.Btn_Hora.UseVisualStyleBackColor = true;
            this.Btn_Hora.Click += new System.EventHandler(this.Btn_Hora_Click);
            // 
            // Btn_Cep
            // 
            this.Btn_Cep.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Cep.Location = new System.Drawing.Point(127, 139);
            this.Btn_Cep.Name = "Btn_Cep";
            this.Btn_Cep.Size = new System.Drawing.Size(99, 50);
            this.Btn_Cep.TabIndex = 4;
            this.Btn_Cep.Text = "Cep";
            this.Btn_Cep.UseVisualStyleBackColor = true;
            this.Btn_Cep.Click += new System.EventHandler(this.Btn_Cep_Click);
            // 
            // Btn_Moeda
            // 
            this.Btn_Moeda.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Moeda.Location = new System.Drawing.Point(232, 139);
            this.Btn_Moeda.Name = "Btn_Moeda";
            this.Btn_Moeda.Size = new System.Drawing.Size(99, 50);
            this.Btn_Moeda.TabIndex = 5;
            this.Btn_Moeda.Text = "Moeda";
            this.Btn_Moeda.UseVisualStyleBackColor = true;
            this.Btn_Moeda.Click += new System.EventHandler(this.Btn_Moeda_Click);
            // 
            // Btn_Data
            // 
            this.Btn_Data.Font = new System.Drawing.Font("Arial", 10F);
            this.Btn_Data.Location = new System.Drawing.Point(22, 195);
            this.Btn_Data.Name = "Btn_Data";
            this.Btn_Data.Size = new System.Drawing.Size(99, 50);
            this.Btn_Data.TabIndex = 6;
            this.Btn_Data.Text = "Data";
            this.Btn_Data.UseVisualStyleBackColor = true;
            this.Btn_Data.Click += new System.EventHandler(this.Btn_Data_Click);
            // 
            // Btn_Senha
            // 
            this.Btn_Senha.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Senha.Location = new System.Drawing.Point(127, 195);
            this.Btn_Senha.Name = "Btn_Senha";
            this.Btn_Senha.Size = new System.Drawing.Size(99, 50);
            this.Btn_Senha.TabIndex = 7;
            this.Btn_Senha.Text = "Senha";
            this.Btn_Senha.UseVisualStyleBackColor = true;
            this.Btn_Senha.Click += new System.EventHandler(this.Btn_Senha_Click);
            // 
            // Btn_Telefone
            // 
            this.Btn_Telefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Telefone.Location = new System.Drawing.Point(232, 195);
            this.Btn_Telefone.Name = "Btn_Telefone";
            this.Btn_Telefone.Size = new System.Drawing.Size(99, 50);
            this.Btn_Telefone.TabIndex = 8;
            this.Btn_Telefone.Text = "Telefone";
            this.Btn_Telefone.UseVisualStyleBackColor = true;
            this.Btn_Telefone.Click += new System.EventHandler(this.Btn_Telefone_Click);
            // 
            // Btn_VerConteudo
            // 
            this.Btn_VerConteudo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VerConteudo.Location = new System.Drawing.Point(22, 251);
            this.Btn_VerConteudo.Name = "Btn_VerConteudo";
            this.Btn_VerConteudo.Size = new System.Drawing.Size(309, 50);
            this.Btn_VerConteudo.TabIndex = 9;
            this.Btn_VerConteudo.Text = "Ver Conteúdo";
            this.Btn_VerConteudo.UseVisualStyleBackColor = true;
            this.Btn_VerConteudo.Click += new System.EventHandler(this.Btn_VerConteudo_Click);
            // 
            // Frm_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 356);
            this.Controls.Add(this.Btn_VerConteudo);
            this.Controls.Add(this.Btn_Telefone);
            this.Controls.Add(this.Btn_Senha);
            this.Controls.Add(this.Btn_Data);
            this.Controls.Add(this.Btn_Moeda);
            this.Controls.Add(this.Btn_Cep);
            this.Controls.Add(this.Btn_Hora);
            this.Controls.Add(this.Lbl_MascaraAtiva);
            this.Controls.Add(this.Lbl_Conteudo);
            this.Controls.Add(this.Msk_TextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Mascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos e Máscaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_TextBox;
        private System.Windows.Forms.Label Lbl_Conteudo;
        private System.Windows.Forms.Label Lbl_MascaraAtiva;
        private System.Windows.Forms.Button Btn_Hora;
        private System.Windows.Forms.Button Btn_Cep;
        private System.Windows.Forms.Button Btn_Moeda;
        private System.Windows.Forms.Button Btn_Data;
        private System.Windows.Forms.Button Btn_Senha;
        private System.Windows.Forms.Button Btn_Telefone;
        private System.Windows.Forms.Button Btn_VerConteudo;
    }
}