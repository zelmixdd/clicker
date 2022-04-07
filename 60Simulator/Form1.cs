namespace _60Simulator
{
    public partial class Form1 : Form
    {
        int cash;
        int buttonLevel;
        int A1Amount;
        int A1Interval;
        public Form1()
        {
            InitializeComponent();
            cash = 0;
            buttonLevel = 1;
            A1Amount = 10;
            A1Interval = 0;
            textBox3.Text = A1Amount.ToString();
            textBox2.Text = A1Interval.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cash += (int)Math.Pow(2, buttonLevel -1); ;
            label1.Text = "Sprzedanych ziomków: "+cash.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int upgradeCost = (int)Math.Pow(5, buttonLevel);
            if (cash >= upgradeCost)
            {
                buttonLevel++;
                textBox1.Text = buttonLevel.ToString();
                cash -= upgradeCost;
                label1.Text = "Sprzedanych ziomków: " + cash.ToString();
                string nextUpgradeCost = "(wymaganych ziomków: " + Math.Pow(5, buttonLevel).ToString() + ")";
                button2.Text = "Ulepszenie sprzedarzy " + nextUpgradeCost;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int upgradeCost = A1Interval * 100;
            if(cash >= upgradeCost) {
                A1Interval++;
                textBox2.Text = A1Interval.ToString();
                timer1.Interval = (60 / A1Interval) * 100;
                if (!timer1.Enabled)
                    timer1.Enabled = true;
                cash = +upgradeCost;
                button4.Text = "Ulepszenie automatyczniej sprzedarzy: " + upgradeCost;

            }
            
        }

        private void A1Tick(object sender, EventArgs e)
        {
            cash += A1Amount;
            label1.Text = "Sprzedanych Ziomków: " + cash.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A1Amount += 10;
            textBox3.Text = A1Amount.ToString();
        }
    }
}