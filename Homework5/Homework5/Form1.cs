namespace Homework5
{

    public partial class Form1 : Form
    {
        int generatedInt;
        int tries = 0;

        public Form1()
        {
            InitializeComponent();

            Number number = new Number();
            generatedInt = number.getGlobalInt();
            Console.WriteLine(generatedInt);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            tries++;
            int input = int.Parse(textBox1.Text);

            if (input == generatedInt)
            {
                MessageBox.Show("You've guessed the right number. Congratulations!" + " Tries you have spend is " + tries);
            }
            else if (input > generatedInt)
            {
                MessageBox.Show("Your number is too high. Try again!");
            }
            else
            {
                MessageBox.Show("Your number is too low. Try again!");
            }
        }
    }

    public class Number
    {
        public static int globalInt;

        public Number()
        {
            Random random = new Random();
            globalInt = random.Next(0, 100);
        }

        public int getGlobalInt()
        {
            return globalInt;
        }

    }

}