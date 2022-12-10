using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIM_4_sem
{
    public partial class MenuQuartos : Form
    {
        public MenuQuartos()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            cadastrarQuarto outroform = new cadastrarQuarto();
            outroform.ShowDialog();
        }

        private void btnPesqFunc_Click(object sender, EventArgs e)
        {
            PesqQuarto outroform = new PesqQuarto();
            outroform.ShowDialog();
        }

        private void btnDelFunc_Click(object sender, EventArgs e)
        {
            deletarQuarto outroform = new deletarQuarto();
            outroform.ShowDialog();
        }
    }
}
