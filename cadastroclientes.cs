using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Cadastro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_cliente;Uid=root;Pwd=*****;");

                strSQL = "INSERT INTO CAD_CLIENTE (NOME, TELEFONE, EMAIL, ENDEREÇO) VALUES (@NOME, @TELEFONE, @EMAIL, @ENDEREÇO)";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@ENDEREÇO", txtEndereco.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("SALVO COM SUCESSO!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_cliente;Uid=root;Pwd=caiosilva13;");

                strSQL = "UPDATE CAD_CLIENTE SET NOME = @NOME, TELEFONE = @TELEFONE, EMAIL = @EMAIL WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);
                comando.Parameters.AddWithValue("@NOME", txtNome.Text);
                comando.Parameters.AddWithValue("@TELEFONE", txtTelefone.Text);
                comando.Parameters.AddWithValue("@EMAIL", txtEmail.Text);
                comando.Parameters.AddWithValue("@ENDEREÇO", txtEndereco.Text);

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("EDITADO COM SUCESSO!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_cliente;Uid=root;Pwd=caiosilva13;");

                strSQL = "DELETE FROM CAD_CLIENTE WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);
                

                conexao.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("DELETADO COM SUCESSO!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_cliente;Uid=root;Pwd=caiosilva13;");

                strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID = @ID";

                comando = new MySqlCommand(strSQL, conexao);
                comando.Parameters.AddWithValue("@ID", txtId.Text);
                
                conexao.Open();

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = Convert.ToString(dr["nome"]);
                    txtTelefone.Text = Convert.ToString(dr["telefone"]);
                    txtEmail.Text = Convert.ToString(dr["email"]);
                    txtEndereco.Text = Convert.ToString(dr["endereço"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        private void BtnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=cad_cliente;Uid=root;Pwd=caiosilva13;");

                strSQL = "SELECT * FROM CAD_CLIENTE";

                da = new MySqlDataAdapter(strSQL, conexao);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvDados.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
