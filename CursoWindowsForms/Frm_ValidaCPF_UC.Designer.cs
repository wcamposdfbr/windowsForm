﻿
namespace CursoWindowsForms
{
    partial class Frm_ValidaCPF_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Valida = new System.Windows.Forms.Button();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // Btn_Valida
            // 
            this.Btn_Valida.Location = new System.Drawing.Point(390, 121);
            this.Btn_Valida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Valida.Name = "Btn_Valida";
            this.Btn_Valida.Size = new System.Drawing.Size(166, 35);
            this.Btn_Valida.TabIndex = 7;
            this.Btn_Valida.Text = "Valida";
            this.Btn_Valida.UseVisualStyleBackColor = true;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(390, 77);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(166, 35);
            this.Btn_Reset.TabIndex = 6;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(40, 150);
            this.Lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Resultado.TabIndex = 5;
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(40, 81);
            this.Msk_CPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(325, 26);
            this.Msk_CPF.TabIndex = 4;
            // 
            // Frm_Valida_CPF_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Valida);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Msk_CPF);
            this.Name = "Frm_Valida_CPF_UC";
            this.Size = new System.Drawing.Size(597, 256);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Valida;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.MaskedTextBox Msk_CPF;
    }
}