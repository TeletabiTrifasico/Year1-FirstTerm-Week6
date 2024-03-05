using System.Globalization;

namespace assignment5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtbxNumberOne.Text);
            int second = Convert.ToInt32(txtbxNumberTwo.Text);
            txtResult.Text = Convert.ToString(Add(first, second));
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtbxNumberOne.Text);
            int second = Convert.ToInt32(txtbxNumberTwo.Text);
            txtResult.Text = Convert.ToString(Subtract(first, second));
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(txtbxNumberOne.Text);
            int second = Convert.ToInt32(txtbxNumberTwo.Text);
            txtResult.Text = Convert.ToString(Multiply(first, second));
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            double first = Convert.ToInt32(txtbxNumberOne.Text);
            double second = Convert.ToInt32(txtbxNumberTwo.Text);
            txtResult.Text = Convert.ToString(Divide(first, second));

        }
        static int Add(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }
        static int Subtract(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }
        static int Multiply(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }
        static string Divide(double numberOne, double numberTwo)
        {
            double result = numberOne / numberTwo;
            return ($"{result:0.000}");
        }
    }
}