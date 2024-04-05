namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        int result;
        string option;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.Text= TextBox.Text + "1";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            TextBox.Text = TextBox.Text+ "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox.Text=TextBox.Text+ "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TextBox.Text=TextBox.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TextBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TextBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TextBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TextBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TextBox.Text += "0";
        }

        private void ButtonResult_Click(object sender, EventArgs e)
        {
            num2=int.Parse(TextBox.Text);

            if (option.Equals("+"))
                result=num1 + num2;
            if (option.Equals("-"))
                result=num2 - num1;
            if (option.Equals("/"))
                result=num1 / num2;
            if (option.Equals("*"))
                result=num1 * num2;

            TextBox.Text= result + "";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            TextBox.Clear();
            num1=0;
            num2=0;
            result=0;

        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(TextBox.Text);
            TextBox.Clear();

        }



        private void ButtonMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(TextBox.Text);
            TextBox.Clear();
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(TextBox.Text);
            TextBox.Clear();
        }

        private void ButtonMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(TextBox.Text);
            TextBox.Clear();
        }
    }
}