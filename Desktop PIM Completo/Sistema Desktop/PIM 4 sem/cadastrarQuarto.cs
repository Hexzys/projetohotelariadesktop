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
    public partial class cadastrarQuarto : Form
    {
        public cadastrarQuarto()
        {
            InitializeComponent();
        }

        //CONEXÃO COM O BANCO DE DADOS
        //ALTERAR A INSTÂNCIA DE TODOS OS MODULOS PARA ABRIR O PROGRAMA!
        SqlConnection cn = new SqlConnection(@"Data Source=hexzys\sqlexpress;integrated security=SSPI;initial catalog=db_marehotel");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void limparCampos()
        {
            txtQuarto.Clear();
            txtAndar.Clear();
            txtPreco.Clear();
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (txtQuarto.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Número do Quarto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuarto.Focus();
            }
            else if (txtAndar.Text == "")
            {
                MessageBox.Show("Obrigatório informar o Andar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAndar.Focus();
            }

            else if (txtPreco.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Preco.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreco.Focus();
            }
   
            else
            {
                try
                {
                    
                    string quarto = txtQuarto.Text;
                    string andar = txtAndar.Text;
                    string status = "";
                    string preco = txtPreco.Text;

                    if (radioOcupado.Checked == true)
                    {
                        status = "Ocupado";
                    }
                    else if(radioDisponivel.Checked == true)
                    {
                        status = "Disponivel";
                    }


                    string strSql = "insert into tbl_quartos (no_quarto,no_andar,nm_status,no_preço)values(@quarto,@andar,@status,@preco)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@quarto", SqlDbType.VarChar).Value = quarto;
                    cm.Parameters.Add("@andar", SqlDbType.Char).Value = andar;
                    cm.Parameters.Add("@status", SqlDbType.VarChar).Value = status;
                    cm.Parameters.Add("@preco", SqlDbType.VarChar).Value = preco;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Usuário registrado com sucesso!", "inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cn.Close();
                }

                finally
                {
                    cn.Close();
                }
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

        private void txtAndar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAndar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtQuarto_TextChanged(object sender, EventArgs e)
        {

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

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    
