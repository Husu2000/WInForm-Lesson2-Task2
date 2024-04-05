namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                User u = new(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, maskedTextBox1.Text, DateTime.Parse(dateTimePicker1.Text), radioButton1.Text);
                Functions.WriteUserToJson(u);
            }
            else if (radioButton2.Checked == true)
            {
                User u = new(textBox1.Text, textBox2.Text, textBox4.Text, textBox3.Text, textBox5.Text, maskedTextBox1.Text, DateTime.Parse(dateTimePicker1.Text), radioButton2.Text);
                Functions.WriteUserToJson(u);
            }
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
           textBox5.Text = string.Empty;
            maskedTextBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                User u = Functions.ReadUserToJson(textBox1.Text);
                textBox1.Text = u.Name;
                textBox2.Text = u.Surname;
                textBox4.Text = u.Country;
                textBox5.Text = u.City;
                maskedTextBox1.Text = u.Phone;
                textBox3.Text = u.Profession;
                dateTimePicker1.Text = u.Date.ToString();
                if (u.male == radioButton1.Text)
                {
                    radioButton1.Checked = true;
                }
                if (u.male == radioButton2.Text)
                {
                    radioButton2.Checked = true;
                }
            }
        }
    }
}