using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIM_4_sem
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pneLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void principal1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
           
             FormFuncMenu outroform = new FormFuncMenu();
             outroform.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            login outroform = new login();
            outroform.ShowDialog();
        }

        private void btnHospedes_Click(object sender, EventArgs e)
        {
            MenuHospede outroform = new MenuHospede();
            outroform.ShowDialog();
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            Checkin outroform = new Checkin();
            outroform.ShowDialog();
        }

        private void btnQuartos_Click(object sender, EventArgs e)
        {
            MenuQuartos outroform = new MenuQuartos();
            outroform.ShowDialog();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            MenuReservas outroform = new MenuReservas();
            outroform.ShowDialog();
        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            Serviços outroform = new Serviços();
            outroform.ShowDialog();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Checkout outroform = new Checkout();
            outroform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            historico outroform = new historico();
            outroform.ShowDialog();
        }
    }
}
