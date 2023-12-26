namespace TesteLogicoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIdade_Click(object sender, EventArgs e)
        {
            string dataInserida = txtData.Text;

            if (DateTime.TryParse(dataInserida, out DateTime dataNascimento))
            {
                DateTime dataLimite = new DateTime(2015, 1, 1);

                if (dataNascimento > dataLimite)
                {
                    MessageBox.Show("Data inserida é inválida");
                    return;
                }

                int idade = DateTime.Today.Year - dataNascimento.Year;

                if (DateTime.Today.Month < dataNascimento.Month || (DateTime.Today.Month == dataNascimento.Month && DateTime.Today.Day < dataNascimento.Day))
                {
                    idade--;
                }

                MessageBox.Show($"Idade: {idade} anos.");
            }
            else
            {
                MessageBox.Show("Formato de data inválido");
            }
        }
    }
}