using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.IO;


namespace WindowsFormsApplication20
{
    public partial class Form4 : Form
    {
        string nome;
        string senha;
        public Form4()
        {
            InitializeComponent();
        }
        
            private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome;
            nome = textBox1.Text;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string genero;
            genero = textBox2.Text;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string endereco;
            endereco = textBox4.Text;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string nascimento;
            nascimento = textBox5.Text;


               

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string email;
            email = textBox3.Text;



        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            string telefone;
            telefone = textBox6.Text;


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            string celular;
            celular = textBox7.Text;

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            string endentrega;
            endentrega = textBox8.Text;


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            string senha;
            if (textBox9.Text.Length == 5)
            {

                senha = textBox9.Text;

            }
            else
            {
                MessageBox.Show("Digite a senha de 5 digítos");

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nome = textBox1.Text;
            senha = textBox9.Text;

            StreamWriter cadastro = new StreamWriter("C:/Users/sirll/Desktop/BACK/Loja Coretta/doc/cadastro" + nome + senha + ".txt", true, Encoding.UTF8);
            cadastro.WriteLine(textBox1.Text);
            cadastro.WriteLine(textBox2.Text);
            cadastro.WriteLine(textBox3.Text);
            cadastro.WriteLine(textBox4.Text);
            cadastro.WriteLine(textBox5.Text);
            cadastro.WriteLine(textBox6.Text);
            cadastro.WriteLine(textBox7.Text);
            cadastro.WriteLine(textBox8.Text);
            cadastro.WriteLine(textBox9.Text);
            

            Form8 novo = new Form8();
            novo.Show();
            Hide();

        }
    }
}
 