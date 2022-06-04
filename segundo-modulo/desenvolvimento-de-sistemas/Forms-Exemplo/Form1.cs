using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Exemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg;

            msg = "Seu nome é " + txtNome.Text;


            if (radioFeminino.Checked)
            {
                msg += "\nSeu gênero é feminino";
            }
            if(radioMasculino.Checked)
            {
                msg += "\nSeu gênero é masculino";
            }


            if (checkDesenvolvimentoSistemas.Checked && checkEnsinoMedio.Checked)
            {
                msg += "\nSeus cursos são Desenvolvimento de Sistemas e o Ensino Médio";
            }
            else if(checkDesenvolvimentoSistemas.Checked)
            {
                msg += "\nSeu curso é Desenvolvimento de Sistemas";
            }
            else if (checkEnsinoMedio.Checked)
            {
                msg += "\nSeu curso é o Ensino Médio";
            }


            if (radioCasado.Checked)
            {
                msg += "\nVocê é casado";
            }
            if (radioDivorciado.Checked)
            {
                msg += "\nVocê é divorciado";
            }
            if (radioSolteiro.Checked)
            {
                msg += "\nVocê é solteiro";
            }


            if (cbEstados.Text == "SP")
            {
                msg += "\nVocê mora em São Paulo";
            }
            if (cbEstados.Text == "BA")
            {
                msg += "\nVocê mora na Bahia";
            }
            if (cbEstados.Text == "PA")
            {
                msg += "\nVocê mora no Paraná";
            }
            if (cbEstados.Text == "AM")
            {
                msg += "\nVocê mora no Amazona";
            }
            if (cbEstados.Text == "PI")
            {
                msg += "\nVocê mora no Piauí";
            }
            if (cbEstados.Text == "PE")
            {
                msg += "\nVocê mora em Pernambuco";
            }
            if (cbEstados.Text == "SC")
            {
                msg += "\nVocê mora em Santa Catarina";
            }
            if (cbEstados.Text == "ES")
            {
                msg += "\nVocê mora em Espírito Santo";
            }
            if (cbEstados.Text == "MG")
            {
                msg += "\nVocê mora em Minas Gerais";
            }
            if (cbEstados.Text == "RS")
            {
                msg += "\nVocê mora no Rio Grande do Sul";
            }
            if (cbEstados.Text == "RN")
            {
                msg += "\nVocê mora no Rio Grande do Norte";
            }
            if (cbEstados.Text == "MS")
            {
                msg += "\nVocê mora em Mato Grosso";
            }

            MessageBox.Show(msg);
        }
    }
}
