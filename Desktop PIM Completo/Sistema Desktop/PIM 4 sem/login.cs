using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PIM_4_sem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        //CONEXÃO COM O BANCO DE DADOS
        //ALTERAR A INSTÂNCIA DE TODOS OS MODULOS PARA ABRIR O PROGRAMA!
        SqlConnection cn = new SqlConnection(@"Data Source=hexzys\sqlexpress;integrated security=SSPI;initial catalog=db_marehotel");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos vázios!","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "Select * from tbl_funcionario where ds_login = ('" + txtLogin.Text + "') and ds_senha =('" + txtSenha.Text + "')";
                    cm.Connection = cn;
                    dt = cm.ExecuteReader();

                    if(dt.HasRows)
                    {
                        frmMenu menu = new frmMenu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou senha inválidos!", "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogin.Clear();
                        txtSenha.Clear();
                        txtLogin.Focus();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    cn.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
