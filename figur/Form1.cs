namespace figur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(valuea.Text);
            float b = Convert.ToSingle(valueb.Text);
            float c = Convert.ToSingle(valuec.Text);
            float d = (b*b)-(4*a*c);
            valued.Text = d.ToString();


            if (d > 0)
            {
                ujdoj.Text = "Delta jest Dodatnia";
            }
            else if (d < 0)
            {
                ujdoj.Text = "Delta jest Ujemna";
            }
            else if (d == 0)
            {
               ujdoj.Text = "Delta jest 0";
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}