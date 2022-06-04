using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variáveis
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent ();
        }

        private void Form1_Load(object sender, EventArgs e) {
            MessageBox.Show ("Olá Mundo!");
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            string nome = txtNome.Text;

            char genero;

            if (rbFem.Checked) {
                genero = 'F';
            }
            else {
                genero = 'M';
            }

            int idade = Convert.ToInt32(txtIdade.Text);
            float altura = float.Parse(txtAltura.Text);
            bool EnsinoMedio;


            if (cbConcluido.Checked)  
            {
                EnsinoMedio = true;
            } else { 
            
                EnsinoMedio = false;
            }

            MessageBox.Show (
                "Nome:" + nome +
                "\nGênero:" + genero +
                "\nIdade:" + idade + "anos" +
                "\nAltura:" + altura + "m" +
                "\nEnsino Médio Concluído" + EnsinoMedio
                );

        }
    }
}
