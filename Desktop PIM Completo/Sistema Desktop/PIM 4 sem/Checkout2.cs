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
    public partial class Checkout2 : Form
    {
        public Checkout2()
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
            txtCpf.Clear();
            txtPreco.Clear();
            txtServico.Clear();
            txtNome.Clear();
            txtQuarto.Clear();
            txtEntrada.Clear();
            txtSaida.Clear();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCpf.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Cpf.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Focus();
            }

            else if (txtPreco.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Preço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPreco.Focus();
            }
            else if (txtServico.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Serviço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServico.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtQuarto.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Quarto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuarto.Focus();
            }
            else if (txtEntrada.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Entrada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEntrada.Focus();
            }
            else if (txtSaida.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Saida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaida.Focus();
            }

            /*        else if(txtQuarto.Text == "")
                    {
                        MessageBox.Show("Obrigatório informar o campo Quarto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }*/

            else
            {
                try
                {
                    int preco1;
                    int preco2;
                    int total;
                    int dias;

                    preco1 = Convert.ToInt32(txtPreco.Text);
                    preco2 = Convert.ToInt32(txtServico.Text);
                    dias = Convert.ToInt32(txtDias.Text);
                    total = (preco1 * dias) + preco2;

                    string cpf = txtCpf.Text;
                    string preco = txtPreco.Text;
                    string servico = txtServico.Text;
                    string nome = txtNome.Text;
                    string quarto = txtQuarto.Text;
                    string entrada = txtEntrada.Text;
                    string saida = txtSaida.Text;
                    int pagamento = total;
                    //  string noquarto = txtQuarto.Text;


                    string strSql = "insert into tbl_checkout (no_cpf,pc_quarto,pc_serviço,nm_hospede,no_quarto,hr_entrada,hr_saida,pagamento,dias)values(@cpf,@preco,@servico,@nome,@quarto,@entrada,@saida,@pagamento,@dias)";
                    //@quarto
                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@preco", SqlDbType.Char).Value = preco;
                    cm.Parameters.Add("@servico", SqlDbType.Char).Value = servico;
                    cm.Parameters.Add("@nome", SqlDbType.Char).Value = nome;
                    cm.Parameters.Add("@quarto", SqlDbType.Char).Value = quarto;
                    cm.Parameters.Add("@entrada", SqlDbType.Char).Value = entrada;
                    cm.Parameters.Add("@saida", SqlDbType.Char).Value = saida;
                    cm.Parameters.Add("@pagamento", SqlDbType.Char).Value = pagamento;
                    cm.Parameters.Add("@dias", SqlDbType.Char).Value = dias;
                    // cm.Parameters.Add("@quarto", SqlDbType.Char).Value = noquarto;
                    //

                    MessageBox.Show("O valor total a pagar é:" + total);
                    // calculo
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Checkout concluido!", "inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limparCampos();
                    this.Close();
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

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
    }

