using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo)== DialogResult.Yes)
                Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            string resposta1, resposta2, resposta3, resposta4, resposta5, classificacao;

            resposta1 = MessageBox.Show("Telefonou para a vítima?", "Pergunta 1", MessageBoxButtons.YesNo).ToString();
            resposta2 = MessageBox.Show("Esteve no local do crime?", "Pergunta 2", MessageBoxButtons.YesNo).ToString();
            resposta3 = MessageBox.Show("Mora perto da vítima?", "Pergunta 3", MessageBoxButtons.YesNo).ToString();
            resposta4 = MessageBox.Show("Devia para a vítima?", "Pergunta 4", MessageBoxButtons.YesNo).ToString();
            resposta5 = MessageBox.Show("Já trabalhou com a vítima?", "Pergunta 5", MessageBoxButtons.YesNo).ToString();

            // Contador para respostas positivas
            int respostasPositivas = 0;

            // Verificando as respostas (contando "Yes" como resposta positiva)
            if (resposta1 == "Yes") respostasPositivas++;
            if (resposta2 == "Yes") respostasPositivas++;
            if (resposta3 == "Yes") respostasPositivas++;
            if (resposta4 == "Yes") respostasPositivas++;
            if (resposta5 == "Yes") respostasPositivas++;


            if (respostasPositivas == 5)
            {
                classificacao = "Assassino";
            }
            else if (respostasPositivas >= 3)
            {
                classificacao = "Cúmplice";
            }
            else if (respostasPositivas == 2)
            {
                classificacao = "Suspeita";
            }
            else
            {
                classificacao = "Inocente";
            }

            MessageBox.Show("Você é " + classificacao, "Resultado");

        }

    }
}
