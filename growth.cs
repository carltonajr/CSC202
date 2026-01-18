namespace growth_c_sharp
{
    public partial class growth : Form
    {
        public growth()
        {
            InitializeComponent();
        }

        private void Home_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Returns to Home Page");
        }

        private void Create_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Link to the page where you can create and manage meal plans, if logged in. If not logged in, it will bring up the login action.");
        }
        private void Updates_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Link to the company updates and information page.");
        }
        private void Connect_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Link to the connection pages such as the company website and social media pages.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login action is performing.");
        }
    }
}
