using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form1 : Form
    {
        string[] cartas = { "4", "5", "6", "7", "Q", "J", "K", "A", "2", "3" };
        string[] naipes = { "◇", "♤", "♡", "♧" };
        List<string> baralho = new List<string>();
        public void CriarBaralho()
        {
            baralho.Clear();

            foreach (var naipe in naipes)
            {
                foreach (var carta in cartas)
                {
                    baralho.Add($"{naipe} {carta} {naipe}");
                }
            }
        }

        public void Embaralhar()
        {
            Random rnd = new Random();
            for (int i = baralho.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = baralho[i];
                baralho[i] = baralho[j];
                baralho[j] = temp;
            }
        }
        public void startVisible()
        {
            carta04.Visible = false;
            carta05.Visible = false;
            carta06.Visible = false;
            carta01.Visible = false;
            carta02.Visible = false;
            carta03.Visible = false;
            btnEsconderAdv.Visible = false;
            btnEsconder.Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CriarBaralho();
            Embaralhar();

            carta01.Items.Add(baralho[0]);
            carta02.Items.Add(baralho[1]);
            carta03.Items.Add(baralho[2]);
            manilha.Items.Add(baralho[3]);
            carta04.Items.Add(baralho[4]);
            carta05.Items.Add(baralho[5]);
            carta06.Items.Add(baralho[6]);

            startVisible();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            carta04.Visible = true;
            carta05.Visible = true;
            carta06.Visible = true;
            btnExibirAdv.Visible = false;
            btnEsconderAdv.Visible = true;
        }

        private void btnEsconder_Click(object sender, EventArgs e)
        {
            carta04.Visible = false;
            carta05.Visible = false;
            carta06.Visible = false;
            btnExibirAdv.Visible = true;
            btnEsconderAdv.Visible = false;
        }

        private void btnExibir_Click_1(object sender, EventArgs e)
        {
            carta01.Visible = true;
            carta02.Visible = true;
            carta03.Visible = true;
            btnExibir.Visible = false;
            btnEsconder.Visible = true;
        }

        private void btnEsconder_Click_1(object sender, EventArgs e)
        {
            carta01.Visible = false;
            carta02.Visible = false;
            carta03.Visible = false;
            btnExibir.Visible = true;
            btnEsconder.Visible = false;
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int cartaSelecionada01 = carta01.SelectedIndex;
            int cartaSelecionada02 = carta02.SelectedIndex;
            int cartaSelecionada03 = carta03.SelectedIndex;


            if (cartaSelecionada01 != -1)
            {
                listBoxJogadas.Items.Add(baralho[0]);
                carta01.SelectedIndex = -1;
                carta01.Items.Clear();
            }
            else if (cartaSelecionada02 != -1)
            {
                listBoxJogadas.Items.Add(baralho[1]);
                carta02.SelectedIndex = -1;
                carta02.Items.Clear();
            }
            else if (cartaSelecionada03 != -1)
            {
                listBoxJogadas.Items.Add(baralho[2]);
                carta03.SelectedIndex = -1;
                carta03.Items.Clear();
            }
            else
            {
                MessageBox.Show("Selecione uma carta");

            }

        }

        private void carta01_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carta01.SelectedIndex == 0)
            {
                carta02.SelectedIndex = -1;
                carta03.SelectedIndex = -1;
            }
        }

        private void carta02_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carta02.SelectedIndex == 0)
            {
                carta01.SelectedIndex = -1;
                carta03.SelectedIndex = -1;
            }
        }

        private void carta03_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carta03.SelectedIndex == 0)
            {
                carta01.SelectedIndex = -1;
                carta02.SelectedIndex = -1;
            }
        }

        private void btnJogarAdv_Click(object sender, EventArgs e)
        {
            int cartaSelecionada04 = carta04.SelectedIndex;
            int cartaSelecionada05 = carta05.SelectedIndex;
            int cartaSelecionada06 = carta06.SelectedIndex;


            if (cartaSelecionada04 != -1)
            {
                listBoxJogadasAdv.Items.Add(baralho[4]);
                carta04.SelectedIndex = -1;
                carta04.Items.Clear();
            }
            else if (cartaSelecionada05 != -1)
            {
                listBoxJogadasAdv.Items.Add(baralho[5]);
                carta05.SelectedIndex = -1;
                carta05.Items.Clear();
            }
            else if (cartaSelecionada06 != -1)
            {
                listBoxJogadasAdv.Items.Add(baralho[6]);
                carta06.SelectedIndex = -1;
                carta06.Items.Clear();
            }
            else
            {
                MessageBox.Show("Selecione uma carta");

            }
        }

        private void carta04_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carta04.SelectedIndex == 0)
            {
                carta05.SelectedIndex = -1;
                carta06.SelectedIndex = -1;
            }
        }

        private void carta05_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carta05.SelectedIndex == 0)
            {
                carta04.SelectedIndex = -1;
                carta06.SelectedIndex = -1;
            }
        }

        private void carta06_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carta06.SelectedIndex == 0)
            {
                carta04.SelectedIndex = -1;
                carta05.SelectedIndex = -1;
            }
        }

        private void btnExibirC1_Click(object sender, EventArgs e)
        {
            carta01.Visible = true;
        }

        private void btnJogarC3_Click(object sender, EventArgs e)
        {
            listBoxJogadas.Items.Add(baralho[2]);
            carta03.Items.Clear();
            btnJogarC3.Visible = false;
            carta03.Visible = false;
        }

        private void btnJogarC2_Click(object sender, EventArgs e)
        {
            listBoxJogadas.Items.Add(baralho[1]);
            carta02.Items.Clear();
            btnJogarC2.Visible = false;
            carta02.Visible = false;
        }

        private void btnJogarC1_Click(object sender, EventArgs e)
        {
            listBoxJogadas.Items.Add(baralho[0]);
            carta01.Items.Clear();
            btnJogarC1.Visible = false;
            carta01.Visible = false;
        }

        private void btnJogarC4_Click(object sender, EventArgs e)
        {
            listBoxJogadasAdv.Items.Add(baralho[4]);
            carta04.Items.Clear();
            btnJogarC4.Visible = false;
            carta04.Visible = false;
        }

        private void btnJogarC5_Click(object sender, EventArgs e)
        {
            listBoxJogadasAdv.Items.Add(baralho[5]);
            carta05.Items.Clear();
            btnJogarC5.Visible = false;
            carta05.Visible = false;
        }

        private void btnJogarC6_Click(object sender, EventArgs e)
        {
            listBoxJogadasAdv.Items.Add(baralho[6]);
            carta06.Items.Clear();
            btnJogarC6.Visible = false;
            carta06.Visible = false;
        }
      
    }
}
