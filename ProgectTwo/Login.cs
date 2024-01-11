namespace ProgectTwo
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "admin123") { 
                DashBoard DB = new DashBoard();
                DB.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Invalid username or password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
