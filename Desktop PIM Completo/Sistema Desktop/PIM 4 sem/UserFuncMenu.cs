using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PIM_4_sem
{
    public partial class UserFuncMenu : UserControl
    {
        private static UserFuncMenu _instance;
        public static UserFuncMenu Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserFuncMenu();
                return _instance;
            }
        }
    
        public UserFuncMenu()
        {
            InitializeComponent();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {

        }

        private void btnPesqFunc_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterFunc_Click(object sender, EventArgs e)
        {

        }

        private void btnDelFunc_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
