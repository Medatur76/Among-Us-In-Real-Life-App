namespace Among_Us_APP;

using FOrms;


public partial class Form1 : Form
{
    public static Role role = new Role(false, false, true);
    public static Tasks tasks = new Tasks(role.getRole());
    public Form1()
    {
        InitializeComponent();
    }

    private void Title_Click(object sender, EventArgs e)
    {
        return;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        role.Visible = true;
        this.Hide();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        tasks.Visible = true;
        this.Hide();
    }
}
