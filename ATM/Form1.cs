namespace ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void create_bt_Click(object sender, EventArgs e)
        {

            if (OnClick != null)
            {
                new CreateAcc().ShowDialog();
                //new Form1().Close();
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
