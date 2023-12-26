using System.Reflection.Metadata.Ecma335;

namespace task1
{
    public partial class PrimeNums : Form
    {
        public PrimeNums()
        {
            InitializeComponent();
        }

        private void FindAndDisplayPrimes(object textBox, object listBox)
        {
            if (textBox is TextBox inputTextBox && listBox is ListBox resultListBox)
            {
                // Get the input number from the textbox
                if (int.TryParse(inputTextBox.Text, out int number))
                {
                    List<int> primes = FindPrimesUpToNumber(number);

                    // Update the UI 
                    this.Invoke(new Action(() =>
                    {
                        resultListBox.Items.Clear();
                        resultListBox.Items.AddRange(primes.ConvertAll(x => x.ToString()).ToArray());
                    }));
                }
                else
                {
                    MessageBox.Show("Please enter a valid number.");
                }
            }
        }

        private static List<int> FindPrimesUpToNumber(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private static bool IsPrime(int num)
        {
            if (num < 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) { return false; }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Start a new thread to find primes for the first textbox
            Thread thread1 = new Thread(() => FindAndDisplayPrimes(textBox1,
                listBox1));
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // New thread to find primes for the second textbox
            Thread thread2 = new Thread(() => FindAndDisplayPrimes(textBox2,
                listBox2));
            thread2.Start();
        }

    }
}
