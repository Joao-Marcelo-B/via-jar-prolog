using SbsSW.SwiPlCs;
using SbsSW.SwiPlCs.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Via.Jar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("SWI_HOME_DIR", @"prolog");
            Environment.SetEnvironmentVariable("Path", @"prolog");
            Environment.SetEnvironmentVariable("Path", @"prolog\\bin");
            string[] p = { "-q", "-f", @"projetoaviacao.pl" };
            PlEngine.Initialize(p);
            PlQuery carregar = new PlQuery("carrega_banco");
            carregar.NextSolution();

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            PlQuery salvar = new PlQuery("salva_banco");
            salvar.NextSolution();
            PlEngine.PlCleanup();
        }

        private void localizacao_Click(object sender, EventArgs e)
        {
            PlQuery pos = new PlQuery("pos(X,Y)");
            foreach (PlQueryVariables var in pos.SolutionVariables)
                listActions.Items.Add(var["X"].ToString() + " esta em "
                    + var["Y"].ToString());
        }

        public bool acontecendoViagem = false;
        private void viajar_Click(object sender, EventArgs e)
        {
            if (destino.Text == "")
            {
                MessageBox.Show("Digite um destino");
                return;
            }

            if (nomePassageiro.Text == "")
            {
                MessageBox.Show("Digite o nome do passageiro");
                return;
            }

            PlQuery transporte = new PlQuery("transporte(LD)");
            transporte.Variables["LD"].Unify(destino.Text);
            transporte.NextSolution();
            listActions.Items.Add("O avião iniciou a viagem para o destino " + destino.Text);
            acontecendoViagem = true;
        }

        List<string> passageiros = new List<string>();
        private void embarcar_Click(object sender, EventArgs e)
        {
            if (acontecendoViagem)
            {
                MessageBox.Show("Não é possível embarcar, pois o avião não está em viagem");
                return;
            }

            if (destino.Text.ToLower() == "")
            {
                MessageBox.Show("Digite um destino");
                return;
            }

            if (nomePassageiro.Text.ToLower() == "")
            {
                MessageBox.Show("Digite o nome do passageiro");
                return;
            }

            PlQuery embarque = new PlQuery("embarcar(Passageiro)");
            embarque.Variables["Passageiro"].Unify(nomePassageiro.Text.ToLower());
            embarque.NextSolution();
            listActions.Items.Add("O passageiro " + nomePassageiro.Text.ToLower() + " embarcou no avião.");
        }

        private void desembarque_Click(object sender, EventArgs e)
        {
            if (!acontecendoViagem)
            {
                MessageBox.Show("O avião ainda não está em viagem.");
                return;
            }


            PlQuery desembarque = new PlQuery("desembarcar(Passageiro)");
            desembarque.Variables["Passageiro"].Unify(nomePassageiro.Text.ToLower());
            desembarque.NextSolution();
            listActions.Items.Add("O avião chegou ao destino!");
            listActions.Items.Add("O passageiro " + nomePassageiro.Text.ToLower() + " desembarcou do avião.");

            acontecendoViagem = false;
        }
    }
}
