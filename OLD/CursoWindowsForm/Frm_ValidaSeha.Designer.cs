
using System;
using System.Text.RegularExpressions;

namespace CursoWindowsForm
{
    partial class Frm_ValidaSeha
    {
        bool VerSenhaTxt = false;
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
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ValidaSeha));
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Btn_VerSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Senha.Location = new System.Drawing.Point(12, 46);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PasswordChar = '*';
            this.Txt_Senha.Size = new System.Drawing.Size(218, 26);
            this.Txt_Senha.TabIndex = 0;
            this.Txt_Senha.TextChanged += new System.EventHandler(this.Txt_Senha_TextChanged);
            this.Txt_Senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Senha_KeyDown);
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.AutoSize = true;
            this.Lbl_Resultado.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resultado.Location = new System.Drawing.Point(12, 90);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(0, 33);
            this.Lbl_Resultado.TabIndex = 1;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Location = new System.Drawing.Point(245, 42);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(111, 30);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Btn_VerSenha
            // 
            this.Btn_VerSenha.Location = new System.Drawing.Point(245, 80);
            this.Btn_VerSenha.Name = "Btn_VerSenha";
            this.Btn_VerSenha.Size = new System.Drawing.Size(111, 30);
            this.Btn_VerSenha.TabIndex = 3;
            this.Btn_VerSenha.Text = "Ver Senha";
            this.Btn_VerSenha.UseVisualStyleBackColor = true;
            this.Btn_VerSenha.Click += new System.EventHandler(this.Btn_VerSenha_Click);
            // 
            // Frm_ValidaSeha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 137);
            this.Controls.Add(this.Btn_VerSenha);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Lbl_Resultado);
            this.Controls.Add(this.Txt_Senha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ValidaSeha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação da Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Button Btn_VerSenha;
    }
}