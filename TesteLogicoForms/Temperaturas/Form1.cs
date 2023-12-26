namespace Temperaturas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTemp_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCelsius.Text, out double temperaturaCelsius))
            {
                //Formula do fahrenheit fornecida errada. Pede o valor Tf ao inves de Tc para calcular. Ela calcula de fahrenheit pra celsius e nao o contrario como pedido no enunciado.

                double temperaturaFahrenheit = (temperaturaCelsius - 32) * 5 / 9;
                double temperaturaKelvin = temperaturaCelsius + 273.15;

                MessageBox.Show($"Temperatura Inserida: {temperaturaCelsius} °C\nTemperatura em Fahrenheit: {temperaturaFahrenheit} °F\nTemperatura em Kelvin: {temperaturaKelvin} K");
            }
            else
            {
                MessageBox.Show("Valor inserido invalido");
            }
        }
    }
}