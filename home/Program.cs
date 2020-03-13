using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;
using WindowsFormsApplication20;

namespace home
{
    public static class Program
    {
        public static string[] nome = new string[30];
        public static string[] quant = new string[30];
        public static double[] valor = new double[30];
        public static string[] vtproduto = new string[11];
        public static string[] vtestoque = new string[11];
        public static double valortotal;
        public static int salvo;
        public static int frete;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            carregarArray();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void carregarArray()
        {
            vtproduto[1] = "colares";
            vtproduto[2] = "turbantes";
            vtproduto[3] = "pulseiras";
            vtproduto[4] = "aneis";
            vtproduto[5] = "pentes";
            vtproduto[6] = "Óculos";
            vtproduto[7] = "brincos";
            vtproduto[8] = "argolas";
            vtproduto[9] = "piercings";
            vtproduto[10] = "Bandanas";

            vtestoque[1] = "50";
            vtestoque[2] = "50";
            vtestoque[3] = "50";
            vtestoque[4] = "50";
            vtestoque[5] = "50";
            vtestoque[6] = "50";
            vtestoque[7] = "50";
            vtestoque[8] = "50";
            vtestoque[9] = "50";
            vtestoque[10] = "50";
        }
}
}
        
