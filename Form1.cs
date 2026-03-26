namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNum = 0;
        string operation = "";
        bool isOpClicked = false;
        string fullHistory = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            if (txtDisplay.Text == "0" || isOpClicked)
            {
                txtDisplay.Text = btn.Text;
                isOpClicked = false;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }


            fullHistory += btn.Text;
            txtMessage.Text = fullHistory;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNum = int.Parse(txtDisplay.Text);

            operation = "+";


            isOpClicked = true;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            int secondNum = int.Parse(txtDisplay.Text);
            int result = 0;

            switch (operation)
            {
                case "+": result = firstNum + secondNum; break;
                case "-": result = firstNum - secondNum; break;
                case "*": result = firstNum * secondNum; break;
                case "/":
                    if (secondNum != 0) result = firstNum / secondNum;
                    else { MessageBox.Show("0으로 나눌 수 없음"); return; }
                    break;
            }


            txtDisplay.Text = result.ToString();


            fullHistory += " = " + result.ToString();
            txtMessage.Text = fullHistory;


            isOpClicked = true;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            firstNum = int.Parse(txtDisplay.Text);
            operation = btn.Text;
            isOpClicked = true;


            fullHistory += " " + operation + " ";
            txtMessage.Text = fullHistory;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            operation = "";
            isOpClicked = false;
            fullHistory = "";

            txtDisplay.Text = "0";
            txtMessage.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int currentLength = txtDisplay.Text.Length;


            if (fullHistory.Length >= currentLength)
            {
                fullHistory = fullHistory.Substring(0, fullHistory.Length - currentLength);
            }


            txtDisplay.Text = "0";
            txtMessage.Text = fullHistory;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }


            if (fullHistory.Length > 0)
            {

                fullHistory = fullHistory.Substring(0, fullHistory.Length - 1);
                txtMessage.Text = fullHistory;
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);
            double result = value * value;

            
            txtDisplay.Text = result.ToString();

           
            fullHistory = value.ToString() + " * " + value.ToString() + " = " + result.ToString();
            txtMessage.Text = fullHistory;

            isOpClicked = true; 
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double value = double.Parse(txtDisplay.Text);

            if (value >= 0)
            {
                double result = Math.Sqrt(value);
                txtDisplay.Text = result.ToString();

                
                fullHistory = "√" + value.ToString() + " = " + result.ToString();
                txtMessage.Text = fullHistory;
            }
            else
            {
                MessageBox.Show("음수의 제곱근은 계산할 수 없습니다.");
            }

            isOpClicked = true;
        }
    }
}
