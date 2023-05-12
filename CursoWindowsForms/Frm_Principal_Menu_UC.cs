using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMascara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;

        public Frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            Frm_DemonstracaoKey_UC u = new Frm_DemonstracaoKey_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "DemonstracaoKey " + ControleDemonstracaoKey;
            TB.Text = "DemonstracaoKey " + ControleDemonstracaoKey;
            TB.ImageIndex = 0;
            TB.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            Frm_HelloWorld_UC u = new Frm_HelloWorld_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = "Hello World " + ControleHelloWorld; 
            TB.ImageIndex = 1;
            TB.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMascara += 1;
             Frm_MascaraUC u = new Frm_MascaraUC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Mascara " + ControleMascara;
            TB.Text = "Mascara " + ControleMascara;
            TB.ImageIndex = 2;
            TB.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(TB);

        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            Frm_ValidaCPF_UC u = new Frm_ValidaCPF_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = "Valida CPF " + ControleValidaCPF;
            TB.ImageIndex = 3;
            TB.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            Frm_ValidaCPF2_UC u = new Frm_ValidaCPF2_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida CPF2 " + ControleValidaCPF;
            TB.Text = "Valida CPF2 " + ControleValidaCPF;
            TB.ImageIndex = 4;
            TB.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void vaslidaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            Frm_ValidaSenha_UC u = new Frm_ValidaSenha_UC();
            u.Dock = DockStyle.Fill;
            TabPage TB = new TabPage();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = "Valida Senha " + ControleValidaSenha;
            TB.ImageIndex = 5;
            TB.Controls.Add(u);
            Tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sAirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
            }
            
        }
    }
}