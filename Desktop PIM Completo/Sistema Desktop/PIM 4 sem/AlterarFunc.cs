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
    public partial class AlterarFunc : Form
    {
        public AlterarFunc()
        {
            InitializeComponent();
        }
        //CONEXÃO COM O BANCO DE DADOS
        //ALTERAR A INSTÂNCIA DE TODOS OS MODULOS PARA ABRIR O PROGRAMA!
        SqlConnection cn = new SqlConnection(@"Data Source=hexzys\sqlexpress;integrated security=SSPI;initial catalog=db_marehotel");
        SqlCommand cm = new SqlCommand();
        SqlDataReader dt;

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "Select * from tbl_funcionario where nm_funcionario like ('" + txtBusca.Text + "%')";
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

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AlterarFunc_Load(object sender, EventArgs e)
        {

        }

        private void carregarCampos()
        {
            lblCod.Text = dgvFunc.SelectedRows[0].Cells[0].Value.ToString();
            txtLogin.Text = dgvFunc.SelectedRows[0].Cells[1].Value.ToString();
            txtSenha.Text = dgvFunc.SelectedRows[0].Cells[2].Value.ToString();
            txtNome.Text = dgvFunc.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dgvFunc.SelectedRows[0].Cells[4].Value.ToString();
            txtCpf.Text = dgvFunc.SelectedRows[0].Cells[5].Value.ToString();
           // txtSexo.Text = dgvFunc.SelectedRows[0].Cells[6].Value.ToString();
            txtTurno.Text = dgvFunc.SelectedRows[0].Cells[7].Value.ToString();
            txtNascimento.Text = dgvFunc.SelectedRows[0].Cells[8].Value.ToString();
            txtCep.Text = dgvFunc.SelectedRows[0].Cells[9].Value.ToString();
            txtEstado.Text = dgvFunc.SelectedRows[0].Cells[10].Value.ToString();
            txtCidade.Text = dgvFunc.SelectedRows[0].Cells[11].Value.ToString();
            txtBairro.Text = dgvFunc.SelectedRows[0].Cells[12].Value.ToString();
            txtComplemento.Text = dgvFunc.SelectedRows[0].Cells[13].Value.ToString();
            txtTel.Text = dgvFunc.SelectedRows[0].Cells[14].Value.ToString();
            txtCel.Text = dgvFunc.SelectedRows[0].Cells[15].Value.ToString();
            txtFuncao.Text = dgvFunc.SelectedRows[0].Cells[16].Value.ToString();
            txtEnd.Text = dgvFunc.SelectedRows[0].Cells[17].Value.ToString();
        }
        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            carregarCampos();
        }

        private void limparCampos()
        {
            txtLogin.Clear();
            txtSenha.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtCpf.Clear();
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
                    int cd = Convert.ToInt32 (lblCod.Text);
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

                    string strSql = "update tbl_funcionario set ds_login=@login,ds_senha=@senha,nm_funcionario=@nome,nm_email=@email,no_cpf=@cpf,nm_sexo=@sexo,nm_turno=@turno,no_nascimento=@nascimento,no_cep=@cep,nm_estado=@estado,nm_cidade=@cidade,nm_bairro=@bairro,nm_complemento=@complemento,no_telefone=@telefone,no_celular=@celular,nm_funcao=@funcao,nm_endereco=@endereco where cd_funcionario=@cd";

                    cm.CommandText = strSql;
                    cm.Connection = cn;

                    cm.Parameters.Add("@cd", SqlDbType.Int).Value = cd;
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
                    MessageBox.Show("Os dados foram alterados com sucesso!", "Alteração de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBusca.Clear();
                    limparCampos();
                }

                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cm.Parameters.Clear();
                    cn.Close();
                }

                finally
                {
                    cn.Close();
                }
            }
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
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

