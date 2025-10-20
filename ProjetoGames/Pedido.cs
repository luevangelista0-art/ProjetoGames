using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGames
{
    public partial class Pedido : Form

    {
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }

        private void lblValorPagar_Click(object sender, EventArgs e)
        {

        }

        private void txtValorOpcionais_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTiposJogos.Items.Add("Spiderman- R$ 20,00");
            cmbTiposJogos.Items.Add("Death Strading- R$ 30,00");
            cmbTiposJogos.Items.Add("GTA IV- R$ 50,00");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //DECLARANDO A VARIÁVEL
            double valorJogo = 0, valorOpcionais = 0, valorPagar = 0;
            if (cmbTiposJogos.SelectedIndex == 0)
            {
                valorJogo = 20;
            }
            else if (cmbTiposJogos.SelectedIndex == 1)
            {
                valorJogo = 30;
            }
            else if (cmbTiposJogos.SelectedIndex == 2)
            {
                valorJogo = 50;
            }
            if (chk2contas.Checked == true)
            {
                valorOpcionais= valorOpcionais + 5;
            }
            if (chk2controles.Checked == true)
            {
                valorOpcionais = valorOpcionais+ 6;
            }
            if (chkTotalPass.Checked == true)
            {
                valorOpcionais = valorOpcionais + 3;
            }
            if (chkTesteDrive.Checked == true)
            {
                valorOpcionais = valorOpcionais + 4;
            }
            else
            {

            }
            valorPagar = valorJogo + valorOpcionais;
            txtValorJogo.Text = Convert.ToString(valorJogo);
            txtValorOpcionais.Text = Convert.ToString(valorOpcionais);
            txtValorPagar.Text = Convert.ToString(valorPagar);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorJogo.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorJogo.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tipoJogos,valorJogo,valorOpcionais,valorPagar) values(@tjogo,@vjogo,@vopcionais,@vpagar)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tjogo", MySqlDbType.Text).Value = cmbTiposJogos.Text;
                    cmd.Parameters.Add("@vjogo", MySqlDbType.Text).Value = txtValorJogo.Text;
                    cmd.Parameters.Add("@vopcionais", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@vpagar", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery(); // ELE GUARDA OS DADOS DO BANCO  

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTiposJogos.Text = "";
                    txtValorJogo.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTiposJogos.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //DECLARANDO A VARIÁVEL
            double valorJogo = 0, valorOpcionais = 0, valorPagar = 0;
            if (cmbTiposJogos.SelectedIndex == 0)
            {
                valorJogo = 20;
            }
            else if (cmbTiposJogos.SelectedIndex == 1)
            {
                valorJogo = 30;
            }
            else if (cmbTiposJogos.SelectedIndex == 2)
            {
                valorJogo = 50;
            }
            if (chk2contas.Checked == true)
            {
                valorOpcionais = valorOpcionais + 5;
            }
            if (chk2controles.Checked == true)
            {
                valorOpcionais = valorOpcionais + 6;
            }
            if (chkTotalPass.Checked == true)
            {
                valorOpcionais = valorOpcionais + 3;
            }
            if (chkTesteDrive.Checked == true)
            {
                valorOpcionais = valorOpcionais + 4;
            }
            else
            {

            }
            valorPagar = valorJogo + valorOpcionais;
            txtValorJogo.Text = Convert.ToString(valorJogo);
            txtValorOpcionais.Text = Convert.ToString(valorOpcionais);
            txtValorPagar.Text = Convert.ToString(valorPagar);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            //vefifica os campos
            if (txtValorJogo.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorJogo.Focus();
            }
            else if (txtValorOpcionais.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorOpcionais.Focus();
            }
            else if (txtValorPagar.Text == "")
            {
                MessageBox.Show("Campo Obrigatório");
                txtValorPagar.Focus();
            }
            else
            {
                //tratamento de erros
                try
                {
                    //inserindo dados no banco de dados
                    string sql = "insert into tbPedido(tiposJogos,valorJogo,valorOpcionais,valorPagar) values(@tjogo,@vjogo,@vopcionais,@vpagar)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@tjogo", MySqlDbType.Text).Value = cmbTiposJogos.Text;
                    cmd.Parameters.Add("@vjogo", MySqlDbType.Text).Value = txtValorJogo.Text;
                    cmd.Parameters.Add("@vopcionais", MySqlDbType.Text).Value = txtValorOpcionais.Text;
                    cmd.Parameters.Add("@vpagar", MySqlDbType.Text).Value = txtValorPagar.Text;
                    cmd.ExecuteNonQuery(); // ELE GUARDA OS DADOS DO BANCO  

                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTiposJogos.Text = "";
                    txtValorJogo.Text = "";
                    txtValorOpcionais.Text = "";
                    txtValorPagar.Text = "";
                    cmbTiposJogos.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
    }




