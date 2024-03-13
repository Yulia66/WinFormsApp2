using System.Text;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (true)
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);


                if (b < 0 && c < 0)
                {
                    label5.Text += a.ToString() + "x^2 " + b.ToString() + "x " + c.ToString() + " = 0";
                    break;
                }
                if (b < 0 && c > 0)
                {
                    label5.Text += a.ToString() + "x^2 " + b.ToString() + "x " + " + " + c.ToString() + " = 0";
                    break;
                }
                if (c < 0 && b > 0)
                {
                    label5.Text += a.ToString() + "x^2 " + " + " + b.ToString() + "x " + c.ToString() + " = 0";
                    break;
                }
                if (b > 0 && c > 0)
                {
                    label5.Text += a.ToString() + "x^2 " + " + " + b.ToString() + "x " + " + " + c.ToString() + " = 0";
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);


            double x1, x2;
            //дискриминант
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                MessageBox.Show("Квадратное уравнение не имеет корней");
            }
            else
            {
                if (discriminant == 0) //квадратное уравнение имеет два одинаковых корня
                {
                    x1 = -b / (2 * a);
                    x2 = x1;

                    MessageBox.Show("x1 и x2 = " + x2.ToString());
                }
                else //уравнение имеет два разных корня
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    MessageBox.Show("x1 = " + x1.ToString() + " x2= " + x1.ToString());
                }
                //вывод корней уравнения

            }



        }
    }
}