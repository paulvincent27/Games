namespace GameFrm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel_HomeBar.Visible == true)
            {
                panel_HomeBar.Visible = false;
            }
            else
            {
                panel_HomeBar.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_HomeBar.Visible = false;
            panel_Login.Visible = false;
            panel_SignUp.Visible = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (panel_Login.Visible == true)
            {
                panel_Login.Visible = false;
            }
            else
            {
                panel_Login.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel_SignUp.Visible == true)
            {
                panel_SignUp.Visible = false;
            }
            else
            {
                panel_SignUp.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
