using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Painel : Form
    {
        public Painel()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Painel_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            Cadastro clientes = new Cadastro();
            clientes.ShowDialog();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConsultaClientes consulta = new ConsultaClientes();
            consulta.ShowDialog();
        }
    }
}
