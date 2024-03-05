using System.Globalization;

namespace assignment7
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(txtbxDegrees.Text);

            if (rbtnCtoK.Checked == true)
            {
                txtResult.Text = (Conversion(number, "CtoK"));
            }
            else if (rbtnCtoF.Checked == true)
            {
                txtResult.Text = (Conversion(number, "CtoF"));
            }
            else
            {
                txtResult.Text = (Conversion(number, "FtoC"));
            }
        }

        static string Conversion(double number, string type)
        {
            double result = 0;
            if (type == "CtoK")
            {
                result = (number + 273);
            }
            else if (type == "CtoF")
            {
                result = (number * 9 / 5 + 32);
            }
            else
            {
                result = ((number - 32) * 5 / 9);
            }
            return ($"{result:0.00}");
        }
    }
}