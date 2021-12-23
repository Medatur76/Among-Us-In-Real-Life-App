namespace Among_Us_APP;

using FOrms;
//This started being coded in 12-22-2021 MM-DD-YYYY
public partial class Form1 : Form
{
    public static Role role = new Role(false, false, true);
    public static Tasks tasks = new Tasks(role.getRole());
    public Form1()
    {
        InitializeComponent();
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        foreach (DriveInfo d in allDrives)
        {
            if (d.DriveType == DriveType.Removable)
            {
                if (File.Exists(d.Name + @"\Among Us In Real Life") && File.Exists(d.Name + @"\Among Us In Real Life\download.datadownload"))
                {
                    tasks.triggerTask("download2");
                }
                else if (File.Exists(d.Name + @"\Among Us In Real Life\player.data.json") && !File.Exists(d.Name + @"\Among Us In Real Life\download.datadownload"))
                {
                    File.Create(d.Name + @"\Among Us In Real Life\player.data.json");
                    tasks.triggerTask("download2");
                }
                else if (!File.Exists(d.Name + @"\Among Us In Real Life\player.data.json") && File.Exists(d.Name + @"\Among Us In Real Life\download.datadownload"))
                {
                    System.Diagnostics.Process.Start("https://github.com/Medatur76/Among-Us-In-Real-Life-App/blob/master/README.md#flash-drive-setup");
                }
                else
                {
                    return;
                }
            }

        }
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
