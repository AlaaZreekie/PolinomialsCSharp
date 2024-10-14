using PolynomialLibrary;

namespace TestDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWriteResult_Click(object sender, EventArgs e)
        {
            string p1AsString = txtP1.Text;
            string p2AsString = txtP2.Text;
            Polynomial P1 = PolynomialParser.Parse(p1AsString);
            Polynomial P2 = PolynomialParser.Parse(p2AsString);
            string option = cboOption.Text;
            Polynomial result = OptionExecuter.PolynomialExecuterByOption(P1, P2, option);

            richTextBox1.Text = result.ToString();
        }

        private void cboOption_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEval_Click(object sender, EventArgs e)
        {
            string stringPolynomial = txtPoly.Text;
            string stringX = txtX.Text;
            double x = Convert.ToDouble(stringX);
            Polynomial polynomial = PolynomialParser.Parse(stringPolynomial);
            string option = cboOption.Text;
            Polynomial result = OptionExecuter.PolynomialExecuterByOption(polynomial, x, option);

            richTextBox1.Text = result.ToString();
        }

        private void lbX_Click(object sender, EventArgs e)
        {

        }
    }
}
