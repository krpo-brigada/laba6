namespace krpoLaba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int midSquare(int k, int n)
        {
            long kSquare = (long)Math.Pow(k, 2);
            if (kSquare < n) return (int)kSquare;
            int squareSize = (int)Math.Log10(kSquare);
            int adresSize = (int)Math.Log10(n);
            int deleteSize = (squareSize - adresSize) / 2;
            return (int)(kSquare / (long)Math.Pow(10, deleteSize)) % n;
        }

        int division(int k, int d)
        {
            return k % d;
        }
        int folding(int k, int n)
        {
            int sum = 0;
            while (k > 0)
            {
                sum += k % n;
                k /= n;
            }
            return sum % n;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            const int n = 1000;
            const int d = 997;
            const int k = 45678;

            textBox3.Text = folding(k, n).ToString();
            textBox2.Text = midSquare(k, n).ToString();
            textBox1.Text = division(k, d).ToString();
        }
    }
}
