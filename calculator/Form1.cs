namespace calculator
{
    public partial class Form1 : Form
    {
        string operand;
        double op1, op2, result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
            private void button1_Click_1(object sender, EventArgs e)
            {
                textBox1.AppendText("1");
            }

            private void button10_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("2");
            }

            private void button9_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("3");
            }

            private void button8_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("4");
            }

            private void button7_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("5");
            }

            private void button2_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("6");
            }

            private void button6_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("7");
            }

            private void button5_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("8");
            }

            private void button4_Click(object sender, EventArgs e)
            {
                textBox1.AppendText("9");
            }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }
        private void button15_Click(object sender, EventArgs e)
        {
             operand = "+";
           
            op1 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Format("{0} {1}", op1, operand);
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operand = "-";
            op1 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Format("{0} {1}", op1, operand);
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
             operand = "*";
            
            op1 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Format("{0} {1}", op1, operand);
            textBox1.Clear();
        }

        
        private void button12_Click(object sender, EventArgs e)
        {
             operand = "/";
            
            op1 = Convert.ToDouble(textBox1.Text);
            label1.Text = String.Format("{0} {1}", op1, operand);
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
           
            
            op2 = Convert.ToInt32(textBox1.Text);
            label1.Text += String.Format("{0}", op2);
            if (operand == "+")
            {
                result = op1 + op2;
                textBox1.Text = result.ToString();
            }
            else if (operand == "-")
            {
                result = op1 - op2;
                textBox1.Text = result.ToString();
            }
            else if (operand == "*")
            {
                result = op1 * op2;
                textBox1.Text = result.ToString();
            }
            else
            {
                if (op2 == 0)
                    MessageBox.Show("DIVISION CANNOT BE DONE BY ZERO IN THE DENOMINATOR","error!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Text = result.ToString();
            }
            

        }
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            textBox1.Clear();

        }
    }
}