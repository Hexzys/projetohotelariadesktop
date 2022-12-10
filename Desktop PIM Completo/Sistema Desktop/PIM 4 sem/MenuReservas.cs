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
    public partial class MenuReservas : Form
    {
        public MenuReservas()
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

        private void dgvFunc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (txtBusca.Text != "")
            {
                try
                {
                    cn.Open();
                    cm.CommandText = "Select * from tlb_reservas where no_reserva like ('" + txtBusca.Text + "%')";
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

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            cadReserva outroform = new cadReserva();
            outroform.ShowDialog();
        }

        private void btnDelFunc_Click(object sender, EventArgs e)
        {
            DeletarReserva outroform = new DeletarReserva();
            outroform.ShowDialog();
        }
    }
    }
