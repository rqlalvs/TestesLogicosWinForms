namespace ImparPar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImparPar_Click(object sender, EventArgs e)
        {

            string entrada = txtString.Text;

            string resultado;

            try
            {
                int numero = int.Parse(entrada);

                if (numero % 2 == 0)
                {
                    resultado = $"O n�mero {numero} � par.";
                }
                else
                {
                    resultado = $"O n�mero {numero} � �mpar.";
                }
            }
            catch (FormatException)
            {
                resultado = "O valor inserido n�o esta no formato ideal. Insira apenas numeros sem espacos ou caracteres especiais.";
            }

            MessageBox.Show(resultado, "Resultado");
        }

        private void txtString_TextChanged(object sender, EventArgs e)
        {

        }
    }
}