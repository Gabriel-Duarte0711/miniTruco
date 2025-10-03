namespace jogo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carta01 = new ListBox();
            carta02 = new ListBox();
            carta03 = new ListBox();
            carta04 = new ListBox();
            carta05 = new ListBox();
            carta06 = new ListBox();
            manilha = new ListBox();
            btnExibirAdv = new Button();
            btnEsconderAdv = new Button();
            btnExibir = new Button();
            btnEsconder = new Button();
            listBoxJogadas = new ListBox();
            listBoxJogadasAdv = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnJogarC5 = new Button();
            btnJogarC6 = new Button();
            btnJogarC4 = new Button();
            btnJogarC1 = new Button();
            btnJogarC2 = new Button();
            btnJogarC3 = new Button();
            btnTrucoAdv = new Button();
            lblTruco = new Label();
            btnTruco = new Button();
            btnDesce = new Button();
            btnRecusar = new Button();
            SuspendLayout();
            // 
            // carta01
            // 
            carta01.Font = new Font("Segoe UI", 15F);
            carta01.FormattingEnabled = true;
            carta01.ItemHeight = 28;
            carta01.Location = new Point(342, 375);
            carta01.Name = "carta01";
            carta01.Size = new Size(94, 144);
            carta01.TabIndex = 0;
            carta01.SelectedIndexChanged += carta01_SelectedIndexChanged;
            // 
            // carta02
            // 
            carta02.Font = new Font("Segoe UI", 15F);
            carta02.FormattingEnabled = true;
            carta02.ItemHeight = 28;
            carta02.Location = new Point(465, 375);
            carta02.Name = "carta02";
            carta02.Size = new Size(94, 144);
            carta02.TabIndex = 1;
            carta02.SelectedIndexChanged += carta02_SelectedIndexChanged;
            // 
            // carta03
            // 
            carta03.Font = new Font("Segoe UI", 15F);
            carta03.FormattingEnabled = true;
            carta03.ItemHeight = 28;
            carta03.Location = new Point(594, 375);
            carta03.Name = "carta03";
            carta03.Size = new Size(94, 144);
            carta03.TabIndex = 2;
            carta03.SelectedIndexChanged += carta03_SelectedIndexChanged;
            // 
            // carta04
            // 
            carta04.Font = new Font("Segoe UI", 15F);
            carta04.FormattingEnabled = true;
            carta04.ItemHeight = 28;
            carta04.Location = new Point(342, 31);
            carta04.Name = "carta04";
            carta04.Size = new Size(94, 144);
            carta04.TabIndex = 3;
            carta04.SelectedIndexChanged += carta04_SelectedIndexChanged;
            // 
            // carta05
            // 
            carta05.Font = new Font("Segoe UI", 15F);
            carta05.FormattingEnabled = true;
            carta05.ItemHeight = 28;
            carta05.Location = new Point(465, 31);
            carta05.Name = "carta05";
            carta05.Size = new Size(94, 144);
            carta05.TabIndex = 4;
            carta05.SelectedIndexChanged += carta05_SelectedIndexChanged;
            // 
            // carta06
            // 
            carta06.Font = new Font("Segoe UI", 15F);
            carta06.FormattingEnabled = true;
            carta06.ItemHeight = 28;
            carta06.Location = new Point(594, 31);
            carta06.Name = "carta06";
            carta06.Size = new Size(94, 144);
            carta06.TabIndex = 5;
            carta06.SelectedIndexChanged += carta06_SelectedIndexChanged;
            // 
            // manilha
            // 
            manilha.Font = new Font("Segoe UI", 15F);
            manilha.FormattingEnabled = true;
            manilha.ItemHeight = 28;
            manilha.Location = new Point(465, 202);
            manilha.Name = "manilha";
            manilha.Size = new Size(94, 144);
            manilha.TabIndex = 6;
            // 
            // btnExibirAdv
            // 
            btnExibirAdv.Location = new Point(727, 31);
            btnExibirAdv.Name = "btnExibirAdv";
            btnExibirAdv.Size = new Size(94, 23);
            btnExibirAdv.TabIndex = 7;
            btnExibirAdv.Text = "Exibir";
            btnExibirAdv.UseVisualStyleBackColor = true;
            btnExibirAdv.Click += btnExibir_Click;
            // 
            // btnEsconderAdv
            // 
            btnEsconderAdv.Location = new Point(727, 60);
            btnEsconderAdv.Name = "btnEsconderAdv";
            btnEsconderAdv.Size = new Size(94, 23);
            btnEsconderAdv.TabIndex = 8;
            btnEsconderAdv.Text = "Esconder";
            btnEsconderAdv.UseVisualStyleBackColor = true;
            btnEsconderAdv.Click += btnEsconder_Click;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(727, 375);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(94, 23);
            btnExibir.TabIndex = 9;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            btnExibir.Click += btnExibir_Click_1;
            // 
            // btnEsconder
            // 
            btnEsconder.Location = new Point(727, 404);
            btnEsconder.Name = "btnEsconder";
            btnEsconder.Size = new Size(94, 23);
            btnEsconder.TabIndex = 10;
            btnEsconder.Text = "Esconder";
            btnEsconder.UseVisualStyleBackColor = true;
            btnEsconder.Click += btnEsconder_Click_1;
            // 
            // listBoxJogadas
            // 
            listBoxJogadas.Font = new Font("Segoe UI", 15F);
            listBoxJogadas.FormattingEnabled = true;
            listBoxJogadas.ItemHeight = 28;
            listBoxJogadas.Location = new Point(884, 324);
            listBoxJogadas.Name = "listBoxJogadas";
            listBoxJogadas.Size = new Size(94, 144);
            listBoxJogadas.TabIndex = 12;
            // 
            // listBoxJogadasAdv
            // 
            listBoxJogadasAdv.Font = new Font("Segoe UI", 15F);
            listBoxJogadasAdv.FormattingEnabled = true;
            listBoxJogadasAdv.ItemHeight = 28;
            listBoxJogadasAdv.Location = new Point(884, 122);
            listBoxJogadasAdv.Name = "listBoxJogadasAdv";
            listBoxJogadasAdv.Size = new Size(94, 144);
            listBoxJogadasAdv.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(884, 306);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 14;
            label1.Text = "Jogador01";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(884, 104);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 15;
            label2.Text = "Jogador02";
            // 
            // btnJogarC5
            // 
            btnJogarC5.Location = new Point(465, 152);
            btnJogarC5.Name = "btnJogarC5";
            btnJogarC5.Size = new Size(94, 23);
            btnJogarC5.TabIndex = 23;
            btnJogarC5.Text = "Jogar";
            btnJogarC5.UseVisualStyleBackColor = true;
            btnJogarC5.Click += btnJogarC5_Click;
            // 
            // btnJogarC6
            // 
            btnJogarC6.Location = new Point(594, 152);
            btnJogarC6.Name = "btnJogarC6";
            btnJogarC6.Size = new Size(94, 23);
            btnJogarC6.TabIndex = 24;
            btnJogarC6.Text = "Jogar";
            btnJogarC6.UseVisualStyleBackColor = true;
            btnJogarC6.Click += btnJogarC6_Click;
            // 
            // btnJogarC4
            // 
            btnJogarC4.Location = new Point(342, 152);
            btnJogarC4.Name = "btnJogarC4";
            btnJogarC4.Size = new Size(94, 23);
            btnJogarC4.TabIndex = 25;
            btnJogarC4.Text = "Jogar";
            btnJogarC4.UseVisualStyleBackColor = true;
            btnJogarC4.Click += btnJogarC4_Click;
            // 
            // btnJogarC1
            // 
            btnJogarC1.Location = new Point(342, 496);
            btnJogarC1.Name = "btnJogarC1";
            btnJogarC1.Size = new Size(94, 23);
            btnJogarC1.TabIndex = 26;
            btnJogarC1.Text = "Jogar";
            btnJogarC1.UseVisualStyleBackColor = true;
            btnJogarC1.Click += btnJogarC1_Click;
            // 
            // btnJogarC2
            // 
            btnJogarC2.Location = new Point(465, 496);
            btnJogarC2.Name = "btnJogarC2";
            btnJogarC2.Size = new Size(94, 23);
            btnJogarC2.TabIndex = 27;
            btnJogarC2.Text = "Jogar";
            btnJogarC2.UseVisualStyleBackColor = true;
            btnJogarC2.Click += btnJogarC2_Click;
            // 
            // btnJogarC3
            // 
            btnJogarC3.Location = new Point(594, 496);
            btnJogarC3.Name = "btnJogarC3";
            btnJogarC3.Size = new Size(94, 23);
            btnJogarC3.TabIndex = 28;
            btnJogarC3.Text = "Jogar";
            btnJogarC3.UseVisualStyleBackColor = true;
            btnJogarC3.Click += btnJogarC3_Click;
            // 
            // btnTrucoAdv
            // 
            btnTrucoAdv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTrucoAdv.Location = new Point(727, 152);
            btnTrucoAdv.Name = "btnTrucoAdv";
            btnTrucoAdv.Size = new Size(94, 23);
            btnTrucoAdv.TabIndex = 29;
            btnTrucoAdv.Text = "TRUCOO";
            btnTrucoAdv.UseVisualStyleBackColor = true;
            btnTrucoAdv.Click += btnTruco_Click;
            // 
            // lblTruco
            // 
            lblTruco.AutoSize = true;
            lblTruco.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTruco.Location = new Point(578, 257);
            lblTruco.Name = "lblTruco";
            lblTruco.Size = new Size(243, 28);
            lblTruco.TabIndex = 30;
            lblTruco.Text = "TRUCOOOOOOOOOOOO";
            // 
            // btnTruco
            // 
            btnTruco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTruco.Location = new Point(727, 496);
            btnTruco.Name = "btnTruco";
            btnTruco.Size = new Size(94, 23);
            btnTruco.TabIndex = 31;
            btnTruco.Text = "TRUCOO";
            btnTruco.UseVisualStyleBackColor = true;
            btnTruco.Click += button1_Click;
            // 
            // btnDesce
            // 
            btnDesce.Location = new Point(613, 231);
            btnDesce.Name = "btnDesce";
            btnDesce.Size = new Size(75, 23);
            btnDesce.TabIndex = 32;
            btnDesce.Text = "desce";
            btnDesce.UseVisualStyleBackColor = true;
            // 
            // btnRecusar
            // 
            btnRecusar.Location = new Point(613, 288);
            btnRecusar.Name = "btnRecusar";
            btnRecusar.Size = new Size(75, 23);
            btnRecusar.TabIndex = 33;
            btnRecusar.Text = "recusar";
            btnRecusar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 570);
            Controls.Add(btnRecusar);
            Controls.Add(btnDesce);
            Controls.Add(btnTruco);
            Controls.Add(lblTruco);
            Controls.Add(btnTrucoAdv);
            Controls.Add(btnJogarC3);
            Controls.Add(btnJogarC2);
            Controls.Add(btnJogarC1);
            Controls.Add(btnJogarC4);
            Controls.Add(btnJogarC6);
            Controls.Add(btnJogarC5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxJogadasAdv);
            Controls.Add(listBoxJogadas);
            Controls.Add(btnEsconder);
            Controls.Add(btnExibir);
            Controls.Add(btnEsconderAdv);
            Controls.Add(btnExibirAdv);
            Controls.Add(manilha);
            Controls.Add(carta06);
            Controls.Add(carta05);
            Controls.Add(carta04);
            Controls.Add(carta03);
            Controls.Add(carta02);
            Controls.Add(carta01);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox carta01;
        private ListBox carta02;
        private ListBox carta03;
        private ListBox carta04;
        private ListBox carta05;
        private ListBox carta06;
        private ListBox manilha;
        private Button btnExibirAdv;
        private Button btnEsconderAdv;
        private Button btnExibir;
        private Button btnEsconder;
        private ListBox listBoxJogadas;
        private ListBox listBoxJogadasAdv;
        private Label label1;
        private Label label2;
        private Button btnJogarC5;
        private Button btnJogarC6;
        private Button btnJogarC4;
        private Button btnJogarC1;
        private Button btnJogarC2;
        private Button btnJogarC3;
        private Button btnTrucoAdv;
        private Label lblTruco;
        private Button btnTruco;
        private Button btnDesce;
        private Button btnRecusar;
    }
}
