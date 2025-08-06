namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show(
                    "Por favor, preencha ambos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validação de números
            if (!double.TryParse(txtNumero1.Text, out _) || !double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show(
                    "Digite apenas números válidos (sem letras ou caracteres especiais).",
                    "Erro de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);
           
            lblResultado.Text = (numero1 + numero2).ToString();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show(
                    "Por favor, preencha ambos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validação de números
            if (!double.TryParse(txtNumero1.Text, out _) || !double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show(
                    "Digite apenas números válidos (sem letras ou caracteres especiais).",
                    "Erro de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 - numero2).ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show(
                    "Por favor, preencha ambos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validação de números
            if (!double.TryParse(txtNumero1.Text, out _) || !double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show(
                    "Digite apenas números válidos (sem letras ou caracteres especiais).",
                    "Erro de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = (numero1 * numero2).ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show(
                    "Por favor, preencha ambos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            // Validação de números
            if (!double.TryParse(txtNumero1.Text, out _) || !double.TryParse(txtNumero2.Text, out _))
            {
                MessageBox.Show(
                    "Digite apenas números válidos (sem letras ou caracteres especiais).",
                    "Erro de entrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            if (numero2 == 0)
            {
                lblResultado.Text = "Error!";
            }
            else
            {
                lblResultado.Text = (numero1 / numero2).ToString();
            }


        }

    }
}
