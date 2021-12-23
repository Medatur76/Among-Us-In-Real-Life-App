namespace Among_Us_APP.FOrms
{
    public partial class Tasks : Form
    {

        private string role;

        public Tasks(string role)
        {
            InitializeComponent();
            if (role == null)
            {
                this.role = new Role(false, false, true).getRole();
            }
            else
            {
                this.role = role;
            }
        }
        private void Tasks_Load(object sender, EventArgs e)
        {
            this.label1.Visible = false;
            this.label2.Visible = false;
            if (role == Role.imposterRole)
            {
                this.label1.Visible = true;
            }
            else
            {
                this.label2.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            return;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
