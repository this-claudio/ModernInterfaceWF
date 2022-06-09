using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernInterface
{
    public partial class Form1 : Form
    {
        Form FormAtivo = null;
        public Form1()
        {
            InitializeComponent();
            EsconderSubMenus();
        }

        public void EsconderSubMenus()
        {
            this.panelSubMenuBotton1.Visible = false;
        }

        public void MostrarSubMenus(Panel SubMenuToShow)
        {
            SubMenuToShow.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EsconderSubMenus();
            MostrarSubMenus(this.panelSubMenuBotton1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EsconderSubMenus();
            MostrarForm(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EsconderSubMenus();
            MostrarForm(new Form3());
        }

        private void MostrarForm(Form Tela)
        {
            if (FormAtivo != null)
                FormAtivo.Close();
            FormAtivo = Tela;
            Tela.Dock = DockStyle.Fill;
            Tela.TopLevel = false;
            Tela.FormBorderStyle = FormBorderStyle.None;
            panelCentral.Controls.Add(Tela);
            Tela.BringToFront();
            Tela.Show();
        }
    }
}
