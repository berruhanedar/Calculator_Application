namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalculateTotal;
        double number1;
        double number2;
        string option;
        double result;

        private void button_1_Click(object sender, EventArgs e)
        {
            text_Total.Text += "1";

        }

        private void button_2_Click(object sender, EventArgs e)
        {
            text_Total.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            text_Total.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            text_Total.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            text_Total.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            text_Total.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            text_Total.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            text_Total.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            text_Total.Text += "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            text_Total.Text += "0";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            option = "+";
            number1 = double.Parse(text_Total.Text);
            text_Total.Clear();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            option = "-";
            number1 = double.Parse(text_Total.Text);
            text_Total.Clear();
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            number1 = double.Parse(text_Total.Text);
            text_Total.Clear();
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            option = "/";
            number1 = double.Parse(text_Total.Text);
            text_Total.Clear();
        }

        private void button_per_Click(object sender, EventArgs e)
        {
            option = "%";
            number1 = int.Parse(text_Total.Text);
            text_Total.Clear();
        }

        private void button_comma_Click(object sender, EventArgs e)
        {
            text_Total.Text += ",";
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            number2 = double.Parse(text_Total.Text);

            if (option.Equals("+"))
                result = number1 + number2;

            if (option.Equals("-"))
                result = number1 - number2;

            if (option.Equals("*"))
                result = number1 * number2;

            if (option.Equals("/"))
                result = number1 / number2;

            if (option.Equals("%"))
                result = number1 % number2;

            text_Total.Text = result.ToString();
        }

        private void button_ac_Click(object sender, EventArgs e)
        {
            text_Total.Clear();
            result = (0);
            number1 = (0);
            number2 = (0);
        }
    }
}
