namespace LSM.Calc2.UI
{
    public partial class Form1 : Form
    {
        public string digit1 = String.Empty;
        public string digit2 = String.Empty;
        public bool isDigit1Set = false;
        public string op;
        public string lastOp;
        
        public Form1()
        {
            InitializeComponent();
        }

        Calculator userCalc = new Calculator();
        private void digit_Click(object sender, EventArgs e) 
        {
            Button button = (Button)sender;

            if(!isDigit1Set)
            {
                digit1 += button.Text;
                txtResult.Text = digit1;
                isDigit1Set= true;
            }
            else 
            {
                digit2 += button.Text;
                txtResult.Text = digit2;
            }
          
        }

        private void op_Click (object sender, EventArgs e) 
        { 
            Button button = (Button)sender;
            if (button.Text == "(+/-)")
            {

                if (digit2 == String.Empty)
                {
                    double.TryParse(digit1, out double num1);
                    num1 = userCalc.sign(num1);
                    digit1 = num1.ToString();
                    txtResult.Text = digit1;
                }
                else
                {
                    double.TryParse(digit2, out double num2);
                    num2 = userCalc.sign(num2);
                    digit2 = num2.ToString();
                    if (num2 > 0)
                    {
                        string equation = txtResult.Text.Substring(0, txtResult.Text.Length - 2);
                        txtResult.Text = equation + digit2;
                    }
                    else
                    {
                        string equation = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                        txtResult.Text = equation + digit2;
                    }
                   
                }

            }
            else
            {
                op = button.Text;
            txtResult.Text += op;

            if (button.Text == "1/x")
            {
                txtResult.Text = "1/" + digit1;
            }
            }
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double result;
            lastOp = op;
            double.TryParse(digit1, out double num1);
            double.TryParse(digit2, out double num2);
            MessageBox.Show(num1.ToString());
            MessageBox.Show(num2.ToString());
            switch (op)
            {
                case "+":
                    result = userCalc.add(num1, num2);
                    txtResult.Text = result.ToString();                 
                    break;
                case "-":
                    result = userCalc.subtract(num1, num2);
                    txtResult.Text = result.ToString();
                    break;
                case "*":
                    result = userCalc.multiply(num1, num2);
                    txtResult.Text = result.ToString();
                    break;
                case "/":
                    result = userCalc.divide(num1, num2);
                    txtResult.Text = result.ToString();
                    break;
                case "Sqrt":
                    result = userCalc.sqrt(num1);
                    txtResult.Text = result.ToString();
                    break;
                case "1/x":
                    result = userCalc.reciprocal(num1);

                    txtResult.Text = result.ToString();
                    break;
                default: 
                    result = 0; 
                    break;
            }
            digit1 = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = String.Empty;
            digit1 = String.Empty;
            digit2= String.Empty;
            isDigit1Set = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string equation = " ";
            try
            {
                equation = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
                txtResult.Text = equation;
            }
            catch (ArgumentOutOfRangeException ex)
            {

                txtResult.Text = "Err: Use Clear Button";
            }
            digit2 = String.Empty;
            
        }
    }
}