using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Projeto
{
   
    public partial class Form1 : Form
    {
        public int valor=10;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = int.Parse(textBox1.Text);


            if (valor <= 100)
            {
                LblResult.Text = "Faltando";
            }
            else if (valor <= 300)
            {
                LblResult.Text = "em estoque";

            }
            else if (valor >= 300)
            {
                LblResult.Text = "sobrando";

            }

            //switch (valor) { 

            //    case 100:
            //        LblResult.Text = "Faltando";
            //        break;

            //    case 300:
            //        LblResult.Text = "em estoque";
            //        break;

            //    case 400:
            //        LblResult.Text = "em estoque";
            //        break;
            //    default:
            //        break;
            // }

            //Operador ternario

            //    LblResult.Text = valor == 10 ? "SIM" : "NAO";
            }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
