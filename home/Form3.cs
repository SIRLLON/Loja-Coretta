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
using WindowsFormsApplication20;


namespace home
{
    public partial class Form3 : Form
    {
        //double valortotal;
        string[] vtproduto = new string[11];
        int vetor;


        public Form3()
        {
            InitializeComponent();
            //aqui vai ler somente o arquivo do carrinho        
            //StreamReader lista = new StreamReader("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/carrinho.txt");
            //string[] linhas = lista.ReadToEnd().Split('\n');
            //listBox3.Items.Add(Program.nome[0]);

            Program.valortotal = 0;
            for (int i = 0; i < Program.nome.GetLength(0); i++)
            {
                if (Program.quant[i] == null)
                {
                    Program.quant[i] = ""; Program.nome[i] = "";
                }

                if (Program.quant[i] != "")
                {
                    listBox2.Items.Add(Program.nome[i]);
                    listBox3.Items.Add(Program.quant[i]);
                    Program.valortotal = Program.valortotal + Program.valor[i] * int.Parse(Program.quant[i]);

                }
                textBox2.Text = "R$ " + Program.valortotal + " reais";

            }

            /*
            foreach (var linhan in Program.nome[Program.salvo])
            {
                listBox2.Items.Add(linhan[]);
            }
            foreach (var linhaq in Program.quant[Program.salvo])
            {
                listBox3.Items.Add(linhaq[]);
            }
            */

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //carregarArray();
        }
        /*Ao entrar no Form Load será chamado o método*/

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            Program.salvo++;
            //Declara o objeto novo tipo form e chama em seguida através do método Show.
            novo.Show();
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (object prod in listBox2.Items)
            {
                //atualizar txt
                vetor = 1;
                while (Program.vtproduto[vetor] != prod.ToString())
                {
                    vetor++;
                }
                //StreamWriter quantidadef = new StreamWriter("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/q0" + vetor + ".txt", true,Encoding.UTF8);
                //quantidadef.Write(comboBox1.Text);
                Program.vtestoque[vetor] = comboBox1.Text;

            }
            Form4 novo = new Form4();
            novo.Show();
            Hide();

            //Declara o objeto novo tipo form e chama em seguida através do método Show.

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {





        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Program.salvo = 0;
            while (Program.nome[Program.salvo] != textBox1.Text)
            {
                Program.salvo++;
            }



            Program.quant[Program.salvo] = comboBox1.Text;
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            Program.valortotal = 0;
            for (int i = 0; i < Program.nome.GetLength(0); i++)
            {
                if (Program.quant[i] == null) { Program.quant[i] = ""; Program.nome[i] = ""; }

                if (Program.quant[i] != "")
                {
                    listBox2.Items.Add(Program.nome[i]);
                    listBox3.Items.Add(Program.quant[i]);
                    Program.valortotal = Program.valortotal + Program.valor[i] * int.Parse(Program.quant[i]);

                }
                textBox2.Text = "R$ " + Program.valortotal + " reais";
            }*/
            /*foreach (object prod in listBox2.SelectedItems)
            {
                textBox1.Text = prod.ToString();
                if  (Program.nome[Program.salvo] == prod.ToString() )
                {
                    int contador = int.Parse(Program.quant[Program.salvo]);
                    while (contador >= 0)
                    {
                        comboBox1.Items.Add(contador);
                        contador--;
                    }

                }

            }*/

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(Program.vtproduto[1]);
            //label8.Text = vtproduto[03];
            foreach (object prod in listBox2.SelectedItems)
            {
                textBox1.Text = prod.ToString();
                //vetor = 1;
                //MessageBox.Show(vtproduto[vetor]);
                vetor = 1;
                //alteracao para pegar txt
                while (Program.vtproduto[vetor] != prod.ToString())
                {
                    vetor++;
                }
            }
            /*int contador = int.Parse(Program.vtestoque[vetor]);
            while (contador >= 0)
            {
                comboBox1.Items.Add(contador);


                contador--;
            }*/

            //como tava antes

            int contador;
            //StreamReader quantidade = new StreamReader("C:/Users/EDUCAFRO/Desktop/Do Sirllon/doc/q0" + vetor + ".txt");
            //contador = int.Parse(quantidade.ReadLine());
            contador = int.Parse(Program.vtestoque[vetor]);
            while (contador >= 0)
            {
                comboBox1.Items.Add(contador);


                contador--;
            }


            //como tava antes


            /* Program.salvo = 0;
             while (Program.nome[Program.salvo] != prod.ToString())
             {
                 Program.salvo++;
             }
         }

         int contador = int.Parse(Program.quant[Program.salvo]);
                 while (contador >= 0)
                 {
                     comboBox1.Items.Add(contador);
                     contador--;*/
            //}                              


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.salvo = 0;
            while (Program.nome[Program.salvo] != textBox1.Text)
            {
                Program.salvo++;
            }

            Program.nome[Program.salvo] = "";
            Program.quant[Program.salvo] = "";
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            Program.valortotal = 0;
            for (int i = 0; i < Program.nome.GetLength(0); i++)
            {
                if (Program.quant[i] == null) { Program.quant[i] = ""; Program.nome[i] = ""; }

                if (Program.quant[i] != "")
                {
                    listBox2.Items.Add(Program.nome[i]);
                    listBox3.Items.Add(Program.quant[i]);
                    Program.valortotal = Program.valortotal + Program.valor[i] * int.Parse(Program.quant[i]);

                }
                textBox2.Text = "R$ " + Program.valortotal + " reais";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //valor total antes de alterar carrinho
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.salvo = 0;
            while (Program.nome[Program.salvo] != textBox1.Text)
            {
                Program.salvo++;
            }



            Program.quant[Program.salvo] = comboBox1.Text;
            listBox3.Items.Clear();
            listBox2.Items.Clear();
            Program.valortotal = 0;
            for (int i = 0; i < Program.nome.GetLength(0); i++)
            {
                if (Program.quant[i] == null) { Program.quant[i] = ""; Program.nome[i] = ""; }

                if (Program.quant[i] != "")
                {
                    listBox2.Items.Add(Program.nome[i]);
                    listBox3.Items.Add(Program.quant[i]);
                    Program.valortotal = Program.valortotal + Program.valor[i] * int.Parse(Program.quant[i]);

                }
                textBox2.Text = "R$ " + Program.valortotal + " reais";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
