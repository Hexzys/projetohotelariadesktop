using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PIM_4_sem
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }
        //CONEXÃO COM O BANCO DE DADOS
        //ALTERAR A INSTÂNCIA DE TODOS OS MODULOS PARA ABRIR O PROGRAMA!
        SqlConnection cn = new SqlConnection(@"Data Source=hexzys\sqlexpress;integrated security=SSPI;initial catalog=db_marehotel");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void limparCampos()
        {
            txtQuarto.Clear();
            txtBusca.Clear();
        }
        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "Select * from tbl_hospedes where nm_hospede like ('" + txtBusca.Text + "%')";
                    cm.Connection = cn;
                    //receber os dados de uma tabela apos execução de um select
                    SqlDataAdapter da = new SqlDataAdapter();
                    // objeto data talbe pode representar uma ou mais tabelas de dados 
                    DataTable dt = new DataTable();
                    //recebendo dados da instrução select pra dentro do data adapter
                    da.SelectCommand = cm;
                    da.Fill(dt); // preenchendo o data table
                    dgvFunc.DataSource = dt;
                    cn.Close();


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dgvFunc.DataSource = null;
            }
        }

        private void carregarCod()
        {
            lblCod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void carregarCodQuarto()
        {
            lblQuarto.Text = dgvFunc1.SelectedRows[0].Cells[0].Value.ToString();
        }



        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarCod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblCod.Text == "")
            {
                MessageBox.Show("Clique duas vezes em um Hóspede!.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string quarto = txtQuarto.Text;
                    int cd1 = Convert.ToInt32(lblCod.Text);
                    string Disponivel = "Disponivel";
                    string ninguem = "Vázio";


                    //string strSql = "insert into tbl_checkout (no_cpf,no_quarto,hr_saida,pç_quarto,pç_serviço,cd_hospede)values(@cpf,@quarto,@saida,@preco,@pservico,@cd1)"; //inserir na tabela checkout
                    string strSql = "update tbl_quartos set nm_status=@Disponivel, nm_hospede=@ninguem where no_quarto=@quarto"; //deixar quarto disponivel na tabela quartos
                    //@quarto

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@quarto", SqlDbType.Char).Value = quarto;
                    cm.Parameters.Add("@cd1", SqlDbType.Int).Value = cd1;
                    cm.Parameters.Add("@Disponivel", SqlDbType.VarChar).Value = Disponivel;
                    cm.Parameters.Add("@ninguem", SqlDbType.VarChar).Value = ninguem;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Check out concluido com sucesso!", "Check-in.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusca.Clear();
                    lblCod.Text = "";
                    limparCampos();
                    Checkout2 outroform = new Checkout2();
                    outroform.ShowDialog();
                    //cd1 = Convert.ToInt32(lblCod.Text);

                }
                catch (Exception erro)
                {
                    //MessageBox.Show("Conexão fechada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Erro de conexão. Reinicie o Sistema!", "Check-in.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    this.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFunc1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarCodQuarto();
        }

        private void txtQuarto_TextChanged(object sender, EventArgs e)
        {
            if (txtQuarto.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "Select * from tbl_quartos where no_quarto like ('" + txtQuarto.Text + "%')";
                    cm.Connection = cn;
                    //receber os dados de uma tabela apos execução de um select
                    SqlDataAdapter da = new SqlDataAdapter();
                    // objeto data talbe pode representar uma ou mais tabelas de dados 
                    DataTable dt = new DataTable();
                    //recebendo dados da instrução select pra dentro do data adapter
                    da.SelectCommand = cm;
                    da.Fill(dt); // preenchendo o data table
                    dgvFunc1.DataSource = dt;
                    cn.Close();


                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                dgvFunc1.DataSource = null;
            }
        }

        private void dgvFunc1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
 

