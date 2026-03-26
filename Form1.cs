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
            
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
