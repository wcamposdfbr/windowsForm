﻿namespace CursoWindowsForms
{
    partial class Frm_DemonstracaoKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_DemonstracaoKey));
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Btn_Reset = new System.Windows.Forms.Button();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.Lbl_Maius = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(12, 12);
            this.Txt_Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(148, 26);
            this.Txt_Input.TabIndex = 0;
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Msg.Location = new System.Drawing.Point(13, 59);
            this.Txt_Msg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txt_Msg.Multiline = true;
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msg.Size = new System.Drawing.Size(716, 268);
            this.Txt_Msg.TabIndex = 1;
            this.Txt_Msg.TabStop = false;
            // 
            // Btn_Reset
            // 
            this.Btn_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Reset.Location = new System.Drawing.Point(777, 12);
            this.Btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Reset.Name = "Btn_Reset";
            this.Btn_Reset.Size = new System.Drawing.Size(112, 43);
            this.Btn_Reset.TabIndex = 2;
            this.Btn_Reset.Text = "Limpa";
            this.Btn_Reset.UseVisualStyleBackColor = true;
            this.Btn_Reset.Click += new System.EventHandler(this.Btn_Reset_Click);
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Minus.AutoSize = true;
            this.Lbl_Minus.Location = new System.Drawing.Point(765, 160);
            this.Lbl_Minus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(55, 20);
            this.Lbl_Minus.TabIndex = 3;
            this.Lbl_Minus.Text = "Minus.";
            // 
            // Lbl_Maius
            // 
            this.Lbl_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Maius.AutoSize = true;
            this.Lbl_Maius.Location = new System.Drawing.Point(765, 86);
            this.Lbl_Maius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Maius.Name = "Lbl_Maius";
            this.Lbl_Maius.Size = new System.Drawing.Size(55, 20);
            this.Lbl_Maius.TabIndex = 4;
            this.Lbl_Maius.Text = "Maius.";
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(837, 86);
            this.Lbl_Upper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(48, 35);
            this.Lbl_Upper.TabIndex = 5;
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(837, 160);
            this.Lbl_Lower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(48, 35);
            this.Lbl_Lower.TabIndex = 6;
            // 
            // Frm_DemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 369);
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.Lbl_Maius);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Btn_Reset);
            this.Controls.Add(this.Txt_Msg);
            this.Controls.Add(this.Txt_Input);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_DemonstracaoKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstração Evento Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.Button Btn_Reset;
        private System.Windows.Forms.Label Lbl_Minus;
        private System.Windows.Forms.Label Lbl_Maius;
        private System.Windows.Forms.Label Lbl_Upper;
        private System.Windows.Forms.Label Lbl_Lower;
    }
}