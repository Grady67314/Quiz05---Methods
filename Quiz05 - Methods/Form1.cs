namespace Quiz05___Methods
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int c;
        int total = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int num = randNum.Next(1, 11);
            outputLabel.Text = num.ToString();
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            productNumber();
        }
        private void productNumber()
        {
            for (int i = 1; i < 101; i += i)
                total = total * i;
            outputLabel.Text = total.ToString();
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            try
            {


                a = Convert.ToInt32(aTextBox.Text);
                b = Convert.ToInt32(bTextBox.Text);
                pythTheorem();



                outputLabel.Text = c.ToString();
            }
            catch
            {
                outputLabel.Text = "Invalid input. Please try again. ";
            }
        }
        public double pythTheorem()
        {


            return c = a * a + b * b;
        }
    }
}
