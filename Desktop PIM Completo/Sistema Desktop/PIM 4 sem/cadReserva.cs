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
    public partial class cadReserva : Form
    {
        public cadReserva()
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
            txtReserva.Clear();
            txtQuarto.Clear();
            txtHospede.Clear();
            txtData.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtReserva.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Reserva.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReserva.Focus();
            }
            else if (txtQuarto.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Quarto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtQuarto.Focus();
            }
            else if (txtHospede.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Hóspede.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHospede.Focus();
            }
            else if (txtData.Text == "")
            {
                MessageBox.Show("Obrigatório informar o campo Data.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtData.Focus();
            }

            else
            {
                try
                {
                    string reserva = txtReserva.Text;
                    string quarto = txtQuarto.Text;
                    string hospede = txtHospede.Text;
                    string data = txtData.Text;
     

                    string strSql = "insert into tlb_reservas (no_reserva,no_quarto,no_hospedes,no_data)values(@reserva,@quarto,@hospede,@data)";
                    //@quarto
                    cm.CommandText = strSql;
                    cm.Connection = cn;


                    cm.Parameters.Add("@reserva", SqlDbType.VarChar).Value = reserva;
                    cm.Parameters.Add("@quarto", SqlDbType.Char).Value = quarto;
                    cm.Parameters.Add("@hospede", SqlDbType.VarChar).Value = hospede;
                    cm.Parameters.Add("@data", SqlDbType.VarChar).Value = data;
                    // cm.Parameters.Add("@quarto", SqlDbType.Char).Value = noquarto;


                    cn.Open();
                    cm.ExecuteNonQuery();
                    cm.Parameters.Clear();
                    MessageBox.Show("Reserva registrada com sucesso!", "inserção de dados concluida", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtReserva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHospede_KeyPress(object sender, KeyPressEventArgs e)
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
