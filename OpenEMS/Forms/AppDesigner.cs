using System.Runtime.InteropServices;
using MySqlConnector;
using PluginBase;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.DirectoryServices;
using OpenEMS.Forms;

namespace OpenEMS;


public partial class AppDesigner : Form
{
    public AppDesigner()
    {
        InitializeComponent();
        //saveFile("C:\\Users\\Alex Dasneves\\source\\repos\\OpenEMS\\Plugin2\\bin\\Debug\\net9.0-windows\\Plugin2.dll");
    }

    private void populateGo(object sender, EventArgs e)
    {
        MySqlConnection conn = new MySqlConnection(Globals.connString);
        MySqlCommand cmd = conn.CreateCommand();
        conn.Open();
        cmd.CommandText = "SELECT * FROM EMS_PANEL_GROUP_DEFN ORDER BY SORT_ORDER";
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = reader.GetString("PANEL_GROUP_TEXT");
            goToolStripMenuItem.DropDownItems.Add(item);
            populatePanelDefn(item, reader.GetInt32("PANEL_GROUP_ID"));
        }
        reader.Close();
        conn.Close();
    }

    private void populatePanelDefn(ToolStripMenuItem parentItem, int groupID)
    {
        MySqlConnection conn = new MySqlConnection(Globals.connString);
        MySqlCommand cmd = conn.CreateCommand();
        conn.Open();
        cmd.CommandText = "SELECT * FROM EMS_PANEL_DEFN WHERE PANEL_GROUP_ID = @PGID ORDER BY SORT_ORDER";
        cmd.Parameters.AddWithValue("@PGID", groupID);
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = reader.GetString("PANEL_TEXT");
            parentItem.DropDownItems.Add(item);
            item.Click += new EventHandler(openProgram);
        }
        reader.Close();
        conn.Close();
    }

    private void openProgram(object? sender, EventArgs e)
    {
        // Get the current element that was clicked
        ToolStripMenuItem? itm = sender as ToolStripMenuItem;
        if (itm == null || itm.Text == null) return;
        // Check if the plugin is loaded in the system.
        foreach (ICommand cmd in Globals.plugins)
        {
            Console.WriteLine(cmd.Name);
        }

        ICommand? command = Globals.plugins.FirstOrDefault(c => c.Name == $"{itm.OwnerItem?.Text}/{itm.Text}");
        if (command == null)
        {
            getFiles(itm.OwnerItem?.Text, itm.Text);
            Program.loadPlugins();
            command = Globals.plugins.FirstOrDefault(c => c.Name == $"{itm.OwnerItem?.Text}/{itm.Text}");
            if (command == null)
            {
                MessageBox.Show($"Error! Could not load program with name of {itm.OwnerItem?.Text}/{itm.Text}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        command.Execute();

    }


    public static void saveFile(string filePath)
    {
        FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        int len = (int)fs.Length;
        byte[] data = new byte[len];
        fs.ReadExactly(data);
        MySqlConnection conn = new MySqlConnection(Globals.connString);
        conn.Open();
        String dataStr = Convert.ToBase64String(data);
        string[] file_name_parts = filePath.Split(@"\");
        string fileName = file_name_parts[file_name_parts.Length - 1];
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO EMS_PROG_DEFN (PROG_NAME, VERSION, PROG_DATA, PANEL_ID) VALUES (@progName, @version, @data, 1);";
        cmd.Parameters.AddWithValue("@progName", fileName);
        cmd.Parameters.AddWithValue("@version", 1);
        cmd.Parameters.AddWithValue("@data", dataStr);
        cmd.ExecuteNonQuery();
    }

    public static void getFiles(string? PanelGroup, string PanelName)
    {
        MySqlConnection conn = new MySqlConnection(Globals.connString);
        conn.Open();
        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT A.* FROM EMS_PROG_DEFN A, EMS_PANEL_DEFN B, EMS_PANEL_GROUP_DEFN C WHERE A.PANEL_ID = B.PANEL_ID AND B.PANEL_GROUP_ID = C.PANEL_GROUP_ID AND B.PANEL_TEXT = @panText AND C.PANEL_GROUP_TEXT = @panGroupText";
        cmd.Parameters.AddWithValue("@panText", PanelName);
        cmd.Parameters.AddWithValue("@panGroupText", PanelGroup);
        MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            string targetPath = Path.Join(@"C:\OpenEMS\cache\", @$"{Globals.db_name}\", reader.GetString("PROG_NAME"));
            // TODO: Check if file exists. If so, return.
            if (Path.Exists(targetPath)) return;

            FileStream fs = File.Create(targetPath);
            string ProgB64 = reader.GetString("PROG_DATA");
            byte[] data = Convert.FromBase64String(ProgB64);
            fs.Write(data);
            fs.Close();
        }

    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        // We should find if the object to be created is one of the following:
        // - Plugin (Project)
        // - Record (Column in database)
        // - Table (Real or "Virtual" [View])
        // - Panel (Form)

        // Open a dialog form that gets the following info:
        // - Object Type
        // - Object Name

        NewItem itm = new();
        DialogResult res = itm.ShowDialog();
    }
}
