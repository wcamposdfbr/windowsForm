
namespace CursoWindowsForm
{
    partial class Frm_HelloWord
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Txt_ConteudoLabel = new System.Windows.Forms.TextBox();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Location = new System.Drawing.Point(40, 64);
            this.Lbl_Titulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(323, 29);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Visual Studio .NET Version";
            this.Lbl_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(40, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modifica Texto do Label";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_ConteudoLabel
            // 
            this.Txt_ConteudoLabel.Location = new System.Drawing.Point(40, 140);
            this.Txt_ConteudoLabel.Name = "Txt_ConteudoLabel";
            this.Txt_ConteudoLabel.Size = new System.Drawing.Size(311, 35);
            this.Txt_ConteudoLabel.TabIndex = 2;
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Fechar.Location = new System.Drawing.Point(336, 415);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(275, 45);
            this.Btn_Fechar.TabIndex = 3;
            this.Btn_Fechar.Text = "Fechar a aplicação";
            this.Btn_Fechar.UseVisualStyleBackColor = true;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // Frm_HelloWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 486);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.Txt_ConteudoLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_Titulo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Frm_HelloWord";
            this.Text = "Hello Word";
            this.Load += new System.EventHandler(this.HelloWord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Txt_ConteudoLabel;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}

