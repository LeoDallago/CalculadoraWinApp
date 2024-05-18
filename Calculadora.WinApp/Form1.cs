namespace Calculadora.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblBoasVindas.Text = $"Bem-Vindo {System.Environment.MachineName}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = txtbValor1.Text;
            int num1Convertido = Convert.ToInt32(num1);

            string num2 = txtbValor2.Text;
            int num2Convertido = Convert.ToInt32(num2);

            if (rbAdicao.Checked)
            {
                int calculo = num1Convertido + num2Convertido;
                string resultado = Convert.ToString(calculo);
                lblResultado.Text = resultado;
                Historico.Items.Add(num1Convertido + "+" + num2Convertido + "=" + resultado);
            }

            if (rbSubtracao.Checked)
            {
                int calculo = num1Convertido - num2Convertido;
                string resultado = Convert.ToString(calculo);
                lblResultado.Text = resultado;
                Historico.Items.Add(num1Convertido + "-" + num2Convertido + "=" + resultado);
            }

            if (rbDivisao.Checked)
            {
                int calculo = num1Convertido / num2Convertido;
                string resultado = Convert.ToString(calculo);
                lblResultado.Text = resultado;
                Historico.Items.Add(num1Convertido + "/" + num2Convertido + "=" + resultado);
            }

            if (rbMultiplicacao.Checked)
            {
                int calculo = num1Convertido * num2Convertido;
                string resultado = Convert.ToString(calculo);
                lblResultado.Text = resultado;
                Historico.Items.Add(num1Convertido + "*" + num2Convertido + "=" + resultado);
            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbAdicao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rbSubtracao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbValor1.Text = null;
            txtbValor2.Text = null;
            lblResultado.Text = null;
            Historico.Items.Clear();
        }

        private void txtbValor1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbValor1.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, informe apenas numeros.","Atenção");
                txtbValor1.Text = txtbValor1.Text.Remove(txtbValor1.Text.Length - 1);
            }
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Historico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void txtbValor2_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtbValor2.Text, "[^0-9]"))
            {
                MessageBox.Show("Por favor, informe apenas numeros.","Atenção");
                txtbValor2.Text = txtbValor2.Text.Remove(txtbValor2.Text.Length - 1);
            }
        }
    }
}
