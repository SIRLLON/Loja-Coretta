using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace home
{
    public partial class Form1 : Form
    {
        string produto;
        string informacao;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produto = "01";
            Form2 novo = new Form2(produto);       
            
            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();
            Hide();
            
            //fecha o formulário atual  this.Visible = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            produto = "02";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            produto = "03";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            produto = "04";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            produto = "05";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            produto = "06";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            produto = "07";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            produto = "08";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            produto = "09";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            produto = "10";
            Form2 novo = new Form2(produto);

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();  //fecha o formulário atual  this.Visible = false;
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
