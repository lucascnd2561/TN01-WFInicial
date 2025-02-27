using System.Windows.Forms;

namespace WFinicial
{
    public partial class FormEx1 : Form
    {
        public FormEx1()
        {
            InitializeComponent();
        }
        private void btncalcular_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtnota1.Text);
            double nota2 = double.Parse(txtnota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                MessageBox.Show(
                    "aprovado",
                    "Ok",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            }
            else if (media < 5)
            {
                MessageBox.Show(
                    "reprovado",
                    "Deu ruim",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("recuperação",
                    "Atenção",

            MessageBoxButtons.OK,
            MessageBoxIcon.Warning);

            }
        }
        }
        
    }

