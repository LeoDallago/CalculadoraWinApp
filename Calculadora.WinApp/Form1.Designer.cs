namespace Calculadora.WinApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitulo = new Label();
            btnCalcular = new Button();
            pictureBox1 = new PictureBox();
            operacoes = new GroupBox();
            rbMultiplicacao = new RadioButton();
            rbDivisao = new RadioButton();
            rbSubtracao = new RadioButton();
            rbAdicao = new RadioButton();
            txtbValor1 = new TextBox();
            txtbValor2 = new TextBox();
            btnLimpar = new Button();
            lblResultado = new Label();
            lblBoasVindas = new Label();
            Historico = new ListBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            operacoes.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.FlatStyle = FlatStyle.Popup;
            lblTitulo.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlLightLight;
            lblTitulo.ImageAlign = ContentAlignment.TopCenter;
            lblTitulo.Location = new Point(425, 68);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Calculadora";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            lblTitulo.Click += label1_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(236, 106, 250);
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ControlLightLight;
            btnCalcular.Location = new Point(320, 396);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(129, 47);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = Properties.Resources.logo_titulo;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // operacoes
            // 
            operacoes.Controls.Add(rbMultiplicacao);
            operacoes.Controls.Add(rbDivisao);
            operacoes.Controls.Add(rbSubtracao);
            operacoes.Controls.Add(rbAdicao);
            operacoes.ForeColor = SystemColors.ButtonHighlight;
            operacoes.Location = new Point(94, 305);
            operacoes.Margin = new Padding(3, 4, 3, 4);
            operacoes.Name = "operacoes";
            operacoes.Padding = new Padding(3, 4, 3, 4);
            operacoes.Size = new Size(823, 59);
            operacoes.TabIndex = 3;
            operacoes.TabStop = false;
            operacoes.Text = "Operacoes";
            operacoes.Enter += groupBox1_Enter;
            // 
            // rbMultiplicacao
            // 
            rbMultiplicacao.AutoSize = true;
            rbMultiplicacao.FlatAppearance.BorderSize = 3;
            rbMultiplicacao.Location = new Point(691, 27);
            rbMultiplicacao.Margin = new Padding(3, 4, 3, 4);
            rbMultiplicacao.Name = "rbMultiplicacao";
            rbMultiplicacao.Size = new Size(120, 24);
            rbMultiplicacao.TabIndex = 3;
            rbMultiplicacao.Text = "Multiplicação";
            rbMultiplicacao.UseVisualStyleBackColor = false;
            // 
            // rbDivisao
            // 
            rbDivisao.AutoSize = true;
            rbDivisao.FlatAppearance.BorderSize = 3;
            rbDivisao.Location = new Point(482, 27);
            rbDivisao.Margin = new Padding(3, 4, 3, 4);
            rbDivisao.Name = "rbDivisao";
            rbDivisao.Size = new Size(79, 24);
            rbDivisao.TabIndex = 2;
            rbDivisao.Text = "Divisão\r\n";
            rbDivisao.UseVisualStyleBackColor = false;
            rbDivisao.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // rbSubtracao
            // 
            rbSubtracao.AutoSize = true;
            rbSubtracao.Location = new Point(226, 27);
            rbSubtracao.Margin = new Padding(3, 4, 3, 4);
            rbSubtracao.Name = "rbSubtracao";
            rbSubtracao.Size = new Size(97, 24);
            rbSubtracao.TabIndex = 1;
            rbSubtracao.Text = "Subtração";
            rbSubtracao.UseVisualStyleBackColor = false;
            rbSubtracao.CheckedChanged += rbSubtracao_CheckedChanged;
            // 
            // rbAdicao
            // 
            rbAdicao.AutoSize = true;
            rbAdicao.Checked = true;
            rbAdicao.FlatAppearance.BorderSize = 3;
            rbAdicao.ForeColor = SystemColors.ButtonHighlight;
            rbAdicao.Location = new Point(23, 27);
            rbAdicao.Margin = new Padding(3, 4, 3, 4);
            rbAdicao.Name = "rbAdicao";
            rbAdicao.Size = new Size(77, 24);
            rbAdicao.TabIndex = 0;
            rbAdicao.TabStop = true;
            rbAdicao.Text = "Adição";
            rbAdicao.UseVisualStyleBackColor = false;
            rbAdicao.CheckedChanged += rbAdicao_CheckedChanged;
            // 
            // txtbValor1
            // 
            txtbValor1.Location = new Point(320, 161);
            txtbValor1.Margin = new Padding(3, 4, 3, 4);
            txtbValor1.Name = "txtbValor1";
            txtbValor1.Size = new Size(335, 27);
            txtbValor1.TabIndex = 4;
            txtbValor1.TextChanged += txtbValor1_TextChanged;
            // 
            // txtbValor2
            // 
            txtbValor2.Location = new Point(320, 225);
            txtbValor2.Margin = new Padding(3, 4, 3, 4);
            txtbValor2.Name = "txtbValor2";
            txtbValor2.Size = new Size(335, 27);
            txtbValor2.TabIndex = 5;
            txtbValor2.TextChanged += txtbValor2_TextChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(236, 106, 250);
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpar.ForeColor = SystemColors.ControlLightLight;
            btnLimpar.Location = new Point(527, 396);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(129, 47);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ControlLightLight;
            lblResultado.Location = new Point(482, 457);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 50);
            lblResultado.TabIndex = 8;
            lblResultado.TextAlign = ContentAlignment.MiddleLeft;
            lblResultado.Click += label1_Click_1;
            // 
            // lblBoasVindas
            // 
            lblBoasVindas.AutoSize = true;
            lblBoasVindas.FlatStyle = FlatStyle.Popup;
            lblBoasVindas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBoasVindas.ForeColor = SystemColors.ControlLightLight;
            lblBoasVindas.ImageAlign = ContentAlignment.TopCenter;
            lblBoasVindas.Location = new Point(797, 36);
            lblBoasVindas.Name = "lblBoasVindas";
            lblBoasVindas.Size = new Size(108, 25);
            lblBoasVindas.TabIndex = 9;
            lblBoasVindas.Text = "Bem-Vindo";
            lblBoasVindas.TextAlign = ContentAlignment.TopCenter;
            lblBoasVindas.Click += label1_Click_2;
            // 
            // Historico
            // 
            Historico.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Historico.FormattingEnabled = true;
            Historico.ItemHeight = 25;
            Historico.Location = new Point(94, 558);
            Historico.Name = "Historico";
            Historico.Size = new Size(823, 129);
            Historico.TabIndex = 10;
            Historico.SelectedIndexChanged += Historico_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(94, 518);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 11;
            label1.Text = "Historico";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(118, 67, 186);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1041, 736);
            Controls.Add(label1);
            Controls.Add(Historico);
            Controls.Add(lblBoasVindas);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpar);
            Controls.Add(txtbValor2);
            Controls.Add(txtbValor1);
            Controls.Add(operacoes);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalcular);
            Controls.Add(lblTitulo);
            ForeColor = SystemColors.ButtonHighlight;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            operacoes.ResumeLayout(false);
            operacoes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCalcular;
        private PictureBox pictureBox1;
        private GroupBox operacoes;
        private RadioButton rbMultiplicacao;
        private RadioButton rbSubtracao;
        private RadioButton rbAdicao;
        private TextBox txtbValor1;
        private TextBox txtbValor2;
        public RadioButton rbDivisao;
        private Button btnLimpar;
        private Label lblResultado;
        private Label lblBoasVindas;
        private ListBox Historico;
        private Label label1;
    }
}
