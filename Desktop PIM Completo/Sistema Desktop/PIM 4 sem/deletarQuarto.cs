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
    public partial class deletarQuarto : Form
    {
        public deletarQuarto()
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

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "Select * from tbl_quartos where no_quarto like ('" + txtBusca.Text + "%')";
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
                MessageBox.Show("Clique duas vezes em um Quarto!.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int cd2 = Convert.ToInt32(lblCod.Text);
                    string strSql = "delete from tbl_quartos where no_quarto=@cd2";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@cd2", SqlDbType.Int).Value = cd2;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Dados excluidos com sucesso!", "Exclusão de dados concluida.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusca.Clear();
                    lblCod.Text = "";
                }
                catch (Exception erro)
                {
                    //MessageBox.Show("Conexão fechada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Problema de conexão. Reinicie o Sistema!", "Erro.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cn.Close();
                    this.Close();
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void txtBusca_KeyPress(object sender, KeyPressEventArgs e)
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
        private void carregarCod()
        {
            lblCod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
        }


        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarCod();
        }
    }
    }

