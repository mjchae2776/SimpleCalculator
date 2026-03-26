namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        int firstNum = 0;
        string operation = "";
        bool isOpClicked = false;
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


            if (isOpClicked)
            {
                txtDisplay.Text = "";
                isOpClicked = false;
            }


            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
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
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                case "－":
                    result = firstNum - secondNum;
                    break;
                case "*":
                case "×":
                    result = firstNum * secondNum;
                    break;
                case "/":
                case "÷":
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                    }
                    else
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다!");
                        return;
                    }
                    break;
            }


            txtDisplay.Text = result.ToString();
            isOpClicked = false;
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
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            firstNum = 0;
            operation = "";
            isOpClicked = false;
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
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
        }
    }
}
