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
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

        //CONEXÃO COM O BANCO DE DADOS
        //ALTERAR A INSTÂNCIA DE TODOS OS MODULOS PARA ABRIR O PROGRAMA!
        SqlConnection cn = new SqlConnection(@"Data Source=hexzys\sqlexpress;integrated security=SSPI;initial catalog=db_marehotel");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void limparCampos()
        {
            txtQuarto.Clear();

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
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
                    string ocupado = "Ocupado";
                    string nome = lblNome.Text;

             
                   // string strSql2 = "update tbl_hospedes set no_quarto=@quarto where cd_hospede=@cd1";//adicionar o quarto na tabela hospedes referente ao codigo do hospede tambe
                    string strSql2 = "update tbl_quartos set cd_hospede=@cd1,nm_status=@ocupado,nm_hospede=@nome where no_quarto=@quarto";
                    //cm.CommandText = "insert into tbl_checkin (no_quarto,hr_entrada,cd_hospede,no_hora)values(@quarto,@entrada,@cd1,@hora)";


                    cm.CommandText = strSql2;
                    //cm.CommandText = strSql2;
                    cm.Connection = cn;



                    cm.Parameters.Add("@quarto", SqlDbType.Char).Value = quarto;
                    cm.Parameters.Add("@cd1", SqlDbType.Int).Value = cd1;
                    cm.Parameters.Add("@ocupado", SqlDbType.Char).Value = ocupado;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Check in concluido com sucesso!", "Check-in.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusca.Clear();
                    lblCod.Text = "";
                    lblNome.Text = "";
                    limparCampos();
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
        private void carregarCod()
        {
            lblCod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void carregarNome()
        {
            lblNome.Text = dgvFunc.SelectedRows[0].Cells[1].Value.ToString();
        }
        private void dgvFunc_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            carregarCod();
            carregarNome();
        }

        private void Checkin_Load(object sender, EventArgs e)
        {

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

        private void dgvFunc1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarCodQuarto();
        }

        private void carregarCodQuarto()
        {
            lblQuarto.Text = dgvFunc1.SelectedRows[0].Cells[0].Value.ToString();
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
    }
    }
