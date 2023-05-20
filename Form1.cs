using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource lockObjectgenerate = new CancellationTokenSource();
        private CancellationTokenSource lockObjectfibonacci = new CancellationTokenSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void generate_btn_click(object sender, EventArgs e)
        {
            int start = string.IsNullOrEmpty(start_textbox.Text) ? 2 : int.Parse(start_textbox.Text);
            int end = string.IsNullOrEmpty(end_textbox.Text) ? int.MaxValue : int.Parse(end_textbox.Text);

            lock (lockObjectgenerate)
            {
                Thread thread = new Thread(() => generate_primes(start, end));
                thread.Start();
            }

        }
        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void generate_primes(int start, int end)
        {
            for (int number = start; number <= end; number++)
            {
                if (IsPrime(number))
                {
                    result.Invoke(new Action(() => result.Items.Add(number)));
                }
            }
        }

        private void Fibonacci(int start, int end)
        {
            int x = 0;
            int y = 1;
            result.Invoke(new Action(() => result.Items.Clear()));
            result.Invoke(new Action(() => result.Items.Add(x)));
            result.Invoke(new Action(() => result.Items.Add(y)));
            for (int i = 2; i <= end; i++)
            {
                int z = x + y;

                if (z > end)
                    break;

                x = y;
                y = z;

                result.Invoke(new Action(() => result.Items.Add(z)));
            }
        }

        private void fibonacci_btn_click(object sender, EventArgs e)
        {

            int start = string.IsNullOrEmpty(start_textbox.Text) ? 0 : int.Parse(start_textbox.Text);
            int end = string.IsNullOrEmpty(end_textbox.Text) ? 100 : int.Parse(end_textbox.Text);
            lock (lockObjectfibonacci)
            {
                lockObjectfibonacci = new CancellationTokenSource();
                Thread thread1 = new Thread(() => Fibonacci(start, end));
                thread1.Start();
            }
        }

        private void clear_btn_click(object sender, EventArgs e)
        {
            result.Items.Clear();

        }

        private void Stop_btn_click(object sender, EventArgs e)
        {
            lock (lockObjectfibonacci)
            {
                lockObjectfibonacci.Cancel();
            }
        }

    }
}