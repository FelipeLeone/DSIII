using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Restaurante;
using BLL_Restaurante;

namespace UI_Restaurante
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            button3.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string retorno;
            Cadastro_DTO obj = new Cadastro_DTO();
            obj.Nome = textBox1.Text;
            obj.RG = textBox2.Text;
            obj.CPF = maskedTextBox1.Text;
            obj.Endereco = textBox3.Text;
            obj.Numero = textBox4.Text;
            obj.Bairro = textBox5.Text;
            obj.Cidade = textBox6.Text;
            obj.Banco = textBox7.Text;
            obj.Agencia = textBox8.Text;
            obj.Conta = textBox9.Text;
            obj.Telefone = maskedTextBox2.Text;
            retorno = Cadastro_BLL.ValidarCadastro(obj);
            MessageBox.Show(retorno, "ERRO", MessageBoxButtons.OK,MessageBoxIcon.Error);



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
