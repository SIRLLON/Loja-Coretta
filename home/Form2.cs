using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace home
{
    public partial class Form2 : Form
    {
        double cep;
        string[] vtproduto = new string[11];
        double[] vtvalor = new double[11];
        int vetor;
        
        

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string produto)
        {

            InitializeComponent();
            vetor = int.Parse(produto);
            //coloco cada informacao de cada arquivo separado
            pictureBox1.ImageLocation = "C:/Users/sirll/Desktop/BACK/Loja Coretta/img/" + produto +".jpg";            
            StreamReader nome = new StreamReader("C:/Users/sirll/Desktop/BACK/Loja Coretta/doc/" + produto + ".txt");
            label1.Text = nome.ReadLine();
            //StreamReader valor = new StreamReader("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/v" + produto + ".txt");
            //label2.Text = valor.ReadLine();//quantidade
            StreamReader preco = new StreamReader("C:/Users/sirll/Desktop/BACK/Loja Coretta/doc/v" + produto + ".txt");
            label3.Text = "R$ "+ preco.ReadLine()+" reais";//preco


             


        }
        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 8)
            {
                cep = int.Parse(textBox1.Text);
                if (cep >= 01000000 && cep <= 19999999)
                {
                    textBox2.Text = ("Economizou uma graninha, pra você , o frete é grátis!!");
                    Program.frete = 0;
                }
                //RJ
                else if (cep >= 20000000 && cep <= 26600999)
                {
                    textBox2.Text = ("Na cidade Maravilhosa será barato, só R$ 100 reais");
                    Program.frete = 100;

                }
                //MG 
                else if (cep >= 30000000 && cep <= 39999999)
                {
                    textBox2.Text = ("Na terra do pão de queijo, será  R$ 200 reais");
                    Program.frete = 200;
                }
                else
                {
                    textBox2.Text = ("Ai é longe :/ Mas a gente entrega, será R$ 300 reais.");
                    Program.frete = 300;

                }
            }
            else
            {
                textBox2.Text = ("");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form3 novo = new Form3();

            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();
            Hide();
        }
        //criar documento carrinho
        void button1_Click(object sender, EventArgs e)
            
        {
            //int repetido = 0;
            /*Program.quant[Program.salvo]="0";
            if (repetido<=30)
            {
                if (Program.nome[repetido] == vtproduto[int.Parse(vetor)])
                {
                    Program.nome[Program.salvo] = vtproduto[int.Parse(vetor)];
                    //Program.quant[Program.salvo] = comboBox1.Text;
                    Program.valor[Program.salvo] = vtvalor[int.Parse(vetor)];
                    Program.salvo++;
                    Program.quant[Program.salvo] = Program.quant[Program.salvo] + int.Parse(comboBox1.Text);
                }
                else
                {*/
                    Program.nome[Program.salvo] = vtproduto[vetor];
                    Program.quant[Program.salvo] = comboBox1.Text;
                    Program.valor[Program.salvo] = vtvalor[vetor];
                    Program.salvo++;
                //}
                //repetido++;

            //}
            

           

            //aqui junto as informacoes vindas de cada arquivo somente para colocar na lista carrinho
            //StreamWriter carrinhonome = new StreamWriter("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/carrinhonome.txt",true,Encoding.UTF8);
            //carrinhonome.Write(vtproduto[int.Parse(vetor)]);
            //StreamWriter carrinhoquantidade = new StreamWriter("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/carrinhoquantidade.txt", true, Encoding.UTF8);
            //carrinhoquantidade.WriteLine(comboBox1.Text);//quantidade
            //carrinho.WriteLine(label3.Text);//valor

            //carrinhonome.Dispose();
            //carrinhoquantidade.Dispose();
            



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int contador;
            //  StreamReader quantidade = new StreamReader("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/q" + vetor + ".txt");

            //contador = int.Parse(quantidade.ReadLine());
            // contador = int.Parse(Program.vtestoque[vetor]);
           

           contador = int.Parse(Program.vtestoque[vetor]);

           while (contador >=0)
           {
               comboBox1.Items.Add(contador);
               contador--;
           }

           carregarArray();
        }
        /*Ao entrar no Form Load será chamado o método*/
        private void carregarArray()
        {
            vtproduto[01] = "colares";
            vtproduto[02] = "turbantes";
            vtproduto[03] = "pulseiras";
            vtproduto[04] = "aneis";
            vtproduto[05] = "pentes";
            vtproduto[06] = "Óculos";
            vtproduto[07] = "brincos";
            vtproduto[08] = "argolas";
            vtproduto[09] = "piercings";
            vtproduto[10] = "Bandanas";

            vtvalor[1] = 89;
            vtvalor[2] = 29;
            vtvalor[3] = 28;
            vtvalor[4] = 35;
            vtvalor[5] = 12;
            vtvalor[6] = 599;
            vtvalor[7] = 119;
            vtvalor[8] = 49;
            vtvalor[9] = 90;
            vtvalor[10] = 30;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

