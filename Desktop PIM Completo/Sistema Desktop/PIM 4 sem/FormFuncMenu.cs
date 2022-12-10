using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIM_4_sem
{
    public partial class FormFuncMenu : Form
    {
        public FormFuncMenu()
        {
            InitializeComponent();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            frmCadFunc outroform = new frmCadFunc();
            outroform.ShowDialog();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesqFunc_Click(object sender, EventArgs e)
        {
            PesquisarFunc outroform = new PesquisarFunc();
            outroform.ShowDialog();
        }

        private void btnAlterFunc_Click(object sender, EventArgs e)
        {
            AlterarFunc outroform = new AlterarFunc();
            outroform.ShowDialog();
        }

        private void btnDelFunc_Click(object sender, EventArgs e)
        {
            deletarFunc outroform = new deletarFunc();
            outroform.ShowDialog();
        }
    }
}
