namespace LSM.Calc2.UI
{
    public partial class Form1 : Form
    {
        public double num1;
        public double num2;
        public string op;
        public string lastOp;
        public bool usedOp = false;
        public bool equalHit = false;
        public bool isNum1Set = false;

        public Form1()
        {
            InitializeComponent();
        }

        Calculator userCalc = new Calculator();

        private void digit_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;



            if (usedOp)
            {
                lblResult.Text = string.Empty;
                usedOp = false;
            }

            lblResult.Text += button.Text;

        }



        private void op_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            double digitValue;

            if (usedOp)
            {
                lblResult.Text = string.Empty;
                usedOp = false;
            }

            if (double.TryParse(lblResult.Text, out digitValue))
            {
                if (!isNum1Set)
                {
                    op = button.Text;
                    num1 = digitValue;
                    lblResult.Text = num1.ToString();
                    isNum1Set = true;
                    lblResult.Text = string.Empty;
                }
            }

            else
            {
                op = button.Text;
                lblResult.Text += op;
                isNum1Set = true;

                if (button.Text == "1/x")
                {
                    lblResult.Text = "1/" + num1.ToString();
                }
            }
            usedOp = true;
            // MessageBox.Show(num1.ToString());


        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double digitValue;


            if (!equalHit)
            {
                if (double.TryParse(lblResult.Text, out digitValue))
                {

                    num2 = digitValue;
                    lblResult.Text = num2.ToString();
                    lblResult.Text = string.Empty;
                    equalHit = true;
                }
            }

            //MessageBox.Show(num2.ToString());

            double result;
            lastOp = op;
            lblResult.Text = string.Empty;
            switch (op)
            {
                case "+":
                    result = userCalc.add(num1, num2);
                    lblResult.Text = result.ToString();
                    break;
                case "-":
                    result = userCalc.subtract(num1, num2);
                    lblResult.Text = result.ToString();
                    break;
                case "*":
                    result = userCalc.multiply(num1, num2);
                    lblResult.Text = result.ToString();
                    break;
                case "/":
                    result = userCalc.divide(num1, num2);
                    lblResult.Text = result.ToString();
                    break;
                case "Sqrt":
                    result = userCalc.sqrt(num1);
                    lblResult.Text = result.ToString();
                    break;
                case "1/x":
                    result = userCalc.reciprocal(num1);

                    lblResult.Text = result.ToString();
                    break;
                default:
                    result = 0;
                    break;
            }
            num1 = result;
        }

        private void negative_Click(object sender, EventArgs e)
        {
            double negative = 0;
            if (double.TryParse(lblResult.Text, out negative))
            {
                negative = negative * -1;
                lblResult.Text = negative.ToString();
            }
        }

        private void decimal_Click (object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!lblResult.Text.Contains("."))
                {
                    lblResult.Text += button.Text;
                }
            }
            else
            {
                lblResult.Text += button.Text;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblResult.Text = String.Empty;
            num1 = 0;
            num2 = 0;
            isNum1Set = false;
            equalHit = false;
            usedOp = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string equation = " ";
            try
            {
                equation = lblResult.Text.Substring(0, lblResult.Text.Length - 1);
                lblResult.Text = equation;
            }
            catch (ArgumentOutOfRangeException ex)
            {

                lblResult.Text = "Err: Use Clear Button";
            }
            num2 = 0;

        }
    }
}
