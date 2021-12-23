namespace Among_Us_APP.FOrms
{
    public partial class Role : Form
    {
        public static string imposterRole = "Imposter";
        public static string crewmateRole = "Crewmate";

        public string role;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Role(Boolean imposter, Boolean crewmate, Boolean random)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            string[] list = new string[5];
            list[0] = "Imposter";
            list[1] = "Crewmate";
            list[2] = "Crewmate";
            list[3] = "Crewmate";
            list[4] = "Crewmate";
            if (imposter == true)
            {
                role = imposterRole;
            }
            else if (crewmate == true)
            {
                role = crewmateRole;
            }
            else if (random == true)
            {
                Random rnd = new Random();
                //int value = (int) new Random().NextInt64();
                //while (checkVar(value, list) == false)
                //{
                //value = (int)new Random().NextInt64();
                //}
                if (list[rnd.Next(0, 2)] == imposterRole)
                {
                    role = imposterRole;
                }
                else
                {
                    role = crewmateRole;
                }
            }
        }

        public string getRole()
        {
            return role;
        }

        private void Role_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            if (role == imposterRole)
            {
                this.label2.Visible = true;
            }
            else if (role == crewmateRole)
            {
                this.label3.Visible = true;
            }
            else
            {
                return;
            }
        }

        private void LinkedLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Medatur76/Among-Us-In-Real-Life-App/blob/master/README.md#role-choosing-and-how-to-do-it");
        }
    }
}
