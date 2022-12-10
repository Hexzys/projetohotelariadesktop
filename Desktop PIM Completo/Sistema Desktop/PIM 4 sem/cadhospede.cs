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
    public partial class cadhospede : Form
    {
        public cadhospede()
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

            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
            txtNascimento.Clear();
            txtCidade.Clear();
            txtCel.Clear();
            //txtQuarto.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }

            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Email.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (txtCpf.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CPF.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCpf.Focus();
            }
            else if (txtNascimento.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nascimento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNascimento.Focus();
            }
            else if (txtCel.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Celular.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCel.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }

            else
            {
                try
                {
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    string cpf = txtCpf.Text;
                    string sexo = "";
                    string nascimento = txtNascimento.Text;
                    string cidade = txtCidade.Text;
                    string celular = txtCel.Text;
   


                    if (radioMasculino.Checked == true)
                    {
                        sexo = "Masculino";
                    }
                    else if (radioFeminino.Checked == true)
                    {
                        sexo = "Feminino";
                    }
                    string strSql = "insert into tbl_hospedes (nm_hospede,nm_email,no_cpf,nm_sexo,no_nascimento,nm_cidade,no_celular)values(@nome,@email,@cpf,@sexo,@nascimento,@cidade,@celular)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                    cm.Parameters.Add("@nascimento", SqlDbType.Char).Value = nascimento;
                    cm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
                    cm.Parameters.Add("@celular", SqlDbType.Char).Value = celular;



                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Hóspede registrado com sucesso!", "inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtQuarto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblQuarto_Click(object sender, EventArgs e)
        {

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

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
    }

