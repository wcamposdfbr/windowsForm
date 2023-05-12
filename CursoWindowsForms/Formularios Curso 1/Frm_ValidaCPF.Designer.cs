﻿namespace CursoWindowsForms
{
    partial class Frm_ValidaCPF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaCPF));
            this.Msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_Valida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Msk_CPF
            // 
            this.Msk_CPF.Location = new System.Drawing.Point(18, 69);
            this.Msk_CPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Msk_CPF.Mask = "000,000,000-00";
            this.Msk_CPF.Name = "Msk_CPF";
            this.Msk_CPF.Size = new System.Drawing.Size(325, 26);
            this.Msk_CPF.TabIndex = 0;
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(18, 138);
            this.Lbl_Resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 29);
            this.Lbl_Resultado.TabIndex = 1;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(368, 65);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(166, 35);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_Valida
            // 
            this.Btn_Valida.Location = new System.Drawing.Point(368, 109);
            this.Btn_Valida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Valida.Name = "Btn_Valida";
            this.Btn_Valida.Size = new System.Drawing.Size(166, 35);
            this.Btn_Valida.TabIndex = 3;
            this.Btn_Valida.Text = "Valida";
            this.Btn_Valida.UseVisualStyleBackColor = true;
            this.Btn_Valida.Click += new System.EventHandler(this.Btn_Valida_Click);
            // 
            // Frm_ValidaCPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 200);
            this.Controls.Add(this.Btn_Valida);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Msk_CPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_ValidaCPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valida CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Msk_CPF;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_Valida;
    }
}