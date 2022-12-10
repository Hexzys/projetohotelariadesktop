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
    public partial class frmCadFunc : Form
    {
        public frmCadFunc()
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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
           // txtSexo.Clear();
            txtTurno.Clear();
            txtNascimento.Clear();
            txtCep.Clear();
            txtEstado.Clear();
            txtCidade.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtTel.Clear();
            txtCel.Clear();
            txtFuncao.Clear();
            txtEnd.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Login.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
          /*  else if(txtLogin.Text)
            {

            }*/
            else if (txtLogin.Text.Length < 5)
            {
                MessageBox.Show("O campo Login deve conter no minimo 5 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Senha.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
            }
            else if (txtSenha.Text.Length < 5)
            {
                MessageBox.Show("O campo Senha deve conter no minimo 5 digitos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Nome.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
            }
            else if (txtFuncao.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Função.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFuncao.Focus();
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
            else if (txtEnd.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Endereço.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEnd.Focus();
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Bairro.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
            }
            else if (txtComplemento.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Complemento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtComplemento.Focus();
            }
            else if (txtTel.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Telefone.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTel.Focus();
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
            else if (txtEstado.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Estado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEstado.Focus();
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
            }
           /* else if (txtSexo.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Sexo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSexo.Focus();
            }*/
            else if (txtTurno.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Turno.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTurno.Focus();
            }
            else if (txtCep.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo CEP.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCep.Focus();
            }
        
            else
            {
                try
                {
                    string login = txtLogin.Text;
                    string senha = txtSenha.Text;
                    string nome = txtNome.Text;
                    string email = txtEmail.Text;
                    string cpf = txtCpf.Text;
                    string sexo = "";
                    string turno = txtTurno.Text;
                    string nascimento = txtNascimento.Text;
                    string cep = txtCep.Text;
                    string estado = txtEstado.Text;
                    string cidade = txtCidade.Text;
                    string bairro = txtBairro.Text;
                    string complemento = txtComplemento.Text;
                    string telefone = txtTel.Text;
                    string celular = txtCel.Text;
                    string funcao = txtFuncao.Text;
                    string endereco = txtEnd.Text;


                    if (radioMasculino.Checked == true)
                    {
                        sexo = "Masculino";
                    }
                    else if (radioFeminino.Checked == true)
                    {
                        sexo = "Feminino";
                    }

                    string strSql = "insert into tbl_funcionario (ds_login,ds_senha,nm_funcionario,nm_email,no_cpf,nm_sexo,nm_turno,no_nascimento,no_cep,nm_estado,nm_cidade,nm_bairro,nm_complemento,no_telefone,no_celular,nm_funcao,nm_endereco)values(@login,@senha,@nome,@email,@cpf,@sexo,@turno,@nascimento,@cep,@estado,@cidade,@bairro,@complemento,@telefone,@celular,@funcao,@endereco)";

                    cm.CommandText = strSql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                    cm.Parameters.Add("@senha", SqlDbType.Char).Value = senha;
                    cm.Parameters.Add("@nome", SqlDbType.VarChar).Value = nome;
                    cm.Parameters.Add("@email", SqlDbType.VarChar).Value = email;
                    cm.Parameters.Add("@cpf", SqlDbType.Char).Value = cpf;
                    cm.Parameters.Add("@sexo", SqlDbType.VarChar).Value = sexo;
                    cm.Parameters.Add("@turno", SqlDbType.VarChar).Value = turno;
                    cm.Parameters.Add("@nascimento", SqlDbType.Char).Value = nascimento;
                    cm.Parameters.Add("@cep", SqlDbType.Char).Value = cep;
                    cm.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado;
                    cm.Parameters.Add("@cidade", SqlDbType.VarChar).Value = cidade;
                    cm.Parameters.Add("@bairro", SqlDbType.VarChar).Value = bairro;
                    cm.Parameters.Add("@complemento", SqlDbType.VarChar).Value = complemento;
                    cm.Parameters.Add("@telefone", SqlDbType.Char).Value = telefone;
                    cm.Parameters.Add("@celular", SqlDbType.Char).Value = celular;
                    cm.Parameters.Add("@funcao", SqlDbType.VarChar).Value = funcao;
                    cm.Parameters.Add("@endereco", SqlDbType.VarChar).Value = endereco;

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Usuário registrado com sucesso!","inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information) ;
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

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTurno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFuncao_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSenha_Click(object sender, EventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void lblCelular_Click(object sender, EventArgs e)
        {

        }

        private void lblBairro_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblComplemento_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void lblCep_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblTurno_Click(object sender, EventArgs e)
        {

        }

        private void lblEndereco_Click(object sender, EventArgs e)
        {

        }

        private void lblNascimento_Click(object sender, EventArgs e)
        {

        }

        private void lblCpf_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblFuncao_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
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

        private void txtBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
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

