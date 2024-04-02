using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loja_produtos_F
{
    public partial class Form1 : Form

    {
        string idREGISTRO;
        string fk_venda;
        string unidade;
        string id_venda;
        string valor_total;


        public Form1()
        {
            InitializeComponent();
            LISTA();
            NOVA_VENDA();   
        }
        private void Valores_Unidade()
        {
            try
            {
                Vart.conexao.Open();
                Vart.comando.CommandText = "SELECT preco FROM tbl_produtos WHERE id = '" + idREGISTRO + "'";
                MySqlDataReader resultado = Vart.comando.ExecuteReader();
                

                if (resultado.Read())
                {
                    unidade = resultado.GetDouble(0).ToString();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Vart.conexao.Close();
            }


        }
        private void LISTA ()
        {
            try
            {
                Vart.conexao.Open();
                Vart.comando.CommandText = "SELECT * FROM tbl_produtos;";
                MySqlDataAdapter ADP = new MySqlDataAdapter(Vart.comando);
                DataTable tbl = new DataTable();
                ADP.Fill(tbl);

                dataGridView1.DataSource = tbl;
                dataGridView1.Columns["id"].HeaderText = "código";
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
            finally
            {
                Vart.conexao.Close();
            }

        }

        private void VENDAS ()
        {
            try
            {
                Vart.conexao.Open();
                Vart.comando.CommandText = "SELECT MAX(id) FROM tbl_vendas";
                MySqlDataReader resultado = Vart.comando.ExecuteReader();

                if (resultado.Read())
                { fk_venda = resultado.GetInt32(0).ToString(); }
            }
            catch (Exception erro) { MessageBox.Show(erro.Message); }

            finally { Vart.conexao.Close(); }
        }

        private void NOVA_VENDA ()
        {
            try
            {
                Vart.conexao.Open();
                Vart.comando.CommandText = "INSERT INTO tbl_vendas(data_compra,fk_clientes, fk_funcionarios) VALUES (CURDATE(), " + Vart.id_cliente + "," + Vart.id_func + ");";
                Vart.comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Vart.conexao.Close();
            }

            try
            {
                Vart.conexao.Open();
                Vart.comando.CommandText = "SELECT MAX(id) FROM tbl_vendas;";
                MySqlDataReader resultado = Vart.comando.ExecuteReader();

                if (resultado.Read())
                {
                    id_venda = resultado.GetInt32(0).ToString();
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Vart.conexao.Close();
            }
        }

        private void buttonADICIONAR_Click(object sender, EventArgs e)
        {
            VENDAS();
            string produto = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            if (textBoxUNIDADE.Text != "" && numericUpDown1.Text != "")
            {
                try
                {
                    Vart.conexao.Open();
                    Vart.comando.CommandText = "INSERT INTO tbl_itens_vendas (fk_produtos, fk_vendas, quantidade, valor_venda ) VALUES ('" + produto + "', '" + fk_venda + "', '" + numericUpDown1.Text + "', '" + textBoxUNIDADE.Text.Replace(",", ".") + "');";
                    Vart.comando.ExecuteNonQuery();

                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    Vart.conexao.Close();

                }
                Vart.carrinho = Vart.carrinho + (double.Parse(numericUpDown1.Value.ToString()) * double.Parse(textBoxUNIDADE.Text));
                textBoxTOTAL.Text = Vart.carrinho.ToString();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (idREGISTRO.ToString().Length > 0 && numericUpDown1.Text != "")
            {
                Valores_Unidade();

                double unitario = double.Parse(unidade);
                int quantidade = int.Parse(numericUpDown1.Value.ToString());
            }
        }

        private void Clear()
        {
            textBoxTOTAL.Clear();
            numericUpDown1.Text = "0";
            textBoxUNIDADE.Clear();
        }

        private void buttonFINALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                Vart.conexao.Open();
                Vart.comando.CommandText = "UPDATE tbl_vendas SET valor_total = " + textBoxTOTAL.Text.Replace(",", ".") + " WHERE id = " + id_venda + ";";
                Vart.comando.ExecuteReader();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                Vart.conexao.Close();
            }
            MessageBox.Show("Compra efetuada com sucesso");
            Clear();
            id_venda = null;

            if (DialogResult.Yes == MessageBox.Show("Deseja iniciar uma nova venda? Caso não o aplicativo irá encerrar", "Atenção", MessageBoxButtons.YesNo))
            {
                NOVA_VENDA();
                LISTA();
                Clear();
            }
            else
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            idREGISTRO = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textBoxUNIDADE.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonCANCELAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja cancelar a compra? Isso apagara todos itens não salvos!", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
    }
    
}
