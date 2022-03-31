namespace Clicker
{
    public partial class Form1 : Form
    {
        int buttonlvl;
        int cash;
        int speed;
        int quantity;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonlvl = 1;
            speed = 10;
            quantity = 1;
            textBox1.Text = speed.ToString();
            textBox2.Text = quantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(10, buttonlvl-1);
            label1.Text = "SUBY:" + cash.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int upgradeCost = (int)Math.Pow(10, buttonlvl);
            if (cash >= upgradeCost)
            {

                buttonlvl++;
                label2.Text = "lvl:" + buttonlvl.ToString();
                cash -= upgradeCost;
                //label1.Text = "Mamona:$" + cash.ToString();
                string nextUpgradeCost = "($" + Math.Pow(10, buttonlvl).ToString() + ")";
                button2.Text = "Upgrade\n" + nextUpgradeCost;

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            quantity++;
            textBox1.Text = quantity.ToString();
            timer1.Interval = (60 / quantity) * 1000;
            if (!timer1.Enabled)
                timer1.Enabled = true;
        }

        private void Tick(object sender, EventArgs e)
        {
            cash += speed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            speed += 10;
            textBox2.Text = speed.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            speed += 10;
            textBox2.Text = speed.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int upgradeCost = quantity * 100;
            if(cash >= upgradeCost) {
                quantity++;
                textBox1.Text = quantity.ToString();
                timer1.Interval = (60 / quantity) * 1000;
                if (!timer1.Enabled)
                    timer1.Enabled = true;
                cash -= upgradeCost;
                label1.text = "SUBY:" + cash.ToString();
            }

        }
    }
}