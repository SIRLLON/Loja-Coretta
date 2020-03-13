using home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form8 : Form
    {
        double valorfinal;
        public Form8()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            Program.salvo++;
            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();
            Hide();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string pagamento;
            //pagamento = comboBox1.Text;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string numcartao;
            numcartao = textBox1.Text;

            Form novo = new Form8();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            double parcelas;
            parcelas = int.Parse(comboBox3.Text);
            textBox6.Text = (valorfinal / parcelas).ToString("N2");


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string subtotal;
            subtotal = textBox2.Text;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string total;
            total = textBox3.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Você fez uma ótima escolha! Volte sempre!!");
            Close();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            int contador = 12;
            while (contador >= 1)
            {
                comboBox3.Items.Add(contador);
                contador--;
            }

            for (int i = 0; i < Program.nome.GetLength(0); i++)
            {
                if (Program.quant[i] == null)
                {
                    Program.quant[i] = ""; Program.nome[i] = "";
                }

                if (Program.quant[i] != "")
                {
                    listBox1.Items.Add(Program.nome[i]);
                }
            }

            textBox2.Text = "R$ " + Program.valortotal + " reais";
            textBox4.Text = "R$ " + Program.valortotal * 0.09 + " reais";
            textBox5.Text = "R$ " + Program.frete + " reais";
            valorfinal = Program.valortotal + Program.valortotal * 0.09 + Program.frete;


            textBox3.Text = "R$ " + valorfinal + " reais";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
