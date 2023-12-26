namespace ConverterNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverterNumeros_Click(object sender, EventArgs e)
        {
            List<int> numeros = new List<int> { -34, 77, -89, -25, -19, 14, -20, 46, -32, 91 };
            List<string> numerosConvertidos = new List<string>();

            foreach (var numero in numeros)
            {
                string resultado = (numero >= 0) ? "Positivo" : "Negativo";
                numerosConvertidos.Add(resultado);
            }

            MessageBox.Show(string.Join(", ", numerosConvertidos));
        }
    }
}