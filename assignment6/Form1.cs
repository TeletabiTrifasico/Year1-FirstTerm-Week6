namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRefrence_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt32(txtbxNumber.Text);
            SquareByReference(ref inputNumber);
            txtResult.Text = inputNumber.ToString();
        }
        private void btnRefrenceOut_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt32(txtbxNumber.Text);
            int inputSquare;
            SquareByReferenceOut(inputNumber, out inputSquare);
            txtResult.Text = inputSquare.ToString();
        }
        private void btnValue_Click(object sender, EventArgs e)
        {
            int inputNumber = Convert.ToInt32(txtbxNumber.Text);
            int inputSquare = SquareByValue(inputNumber);
            txtResult.Text = inputSquare.ToString();
        }

        //Calculation Methods
        static void SquareByReference(ref int number)
        {
            number *= number;
        }
        static void SquareByReferenceOut(int number, out int square)
        {
            square = number * number; 
        }
        static int SquareByValue(int number)
        {
            return number * number;
        }
    }
}