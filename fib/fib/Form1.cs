namespace fib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int fib(int num) //10
        {
            if (num == 0)
            {
                return 0;
            }
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return fib(num - 1) + fib(num - 2);  // fib(9) + fib(8);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = fib(Convert.ToInt32(textBox1.Text)).ToString();

        }
    }
}