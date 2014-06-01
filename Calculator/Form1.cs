using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private readonly Calculation _c = new Calculation();

        private void button1_Click(object sender, EventArgs e)
        {
            var tb = (Button) sender;
            inputbox.Text += tb.Text;
        }
        private void button14_Click(object sender, EventArgs e)
        {
            inputbox.Text += @",";
            button14.Enabled = false;
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            _c.Arg1 = double.Parse(inputbox.Text);
            inputbox.Text += @"+";
            _c.Action = '+';
            
        }

        private void resultbutton_Click(object sender, EventArgs e)
        {

        }

        private void minusbutton_Click(object sender, EventArgs e)
        {

        }

        private void percentbutton_Click(object sender, EventArgs e)
        {

        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {

        }

        private void sqrtbutton_Click(object sender, EventArgs e)
        {

        }

        private void derivedbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
