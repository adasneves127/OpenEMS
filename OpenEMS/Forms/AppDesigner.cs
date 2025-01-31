using System.Runtime.InteropServices;
using MySqlConnector;
using PluginBase;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.DirectoryServices;
using OpenEMS.Forms;
using System.Text.RegularExpressions;
using OpenEMS.Controls;
using OpenEMS.Enums;

namespace OpenEMS;


public partial class AppDesigner : Form, IForm
{
    // DO NOT CHANGE!
    public string formID { get => "73ce6ba2-1f2d-4126-b67a-7b259f529d4b"; }

    public AppDesigner()
    {
        InitializeComponent();
        //saveFile("C:\\Users\\Alex Dasneves\\source\\repos\\OpenEMS\\Plugin2\\bin\\Debug\\net9.0-windows\\Plugin2.dll");
    }

    private void populateGo(object sender, EventArgs e)
    {
        /*MySqlConnection conn = new MySqlConnection(Globals.connString);
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
        conn.Close();*/
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
            item.Click += new EventHandler(Globals.pluginManager.openProgram);
        }
        reader.Close();
        conn.Close();
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
        if (res == DialogResult.Abort) return;
        SyntaxHighlightingTextBox shtb = new SyntaxHighlightingTextBox();
        // Get the name for the item we want
        string fileName = itm.fileName;
        switch (itm.FileType)
        {

            case FileType.CsFile:
                #region C# Token Definition for Highlighting
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("abstract", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("as", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("base", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("bool", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("break", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("byte", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("case", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("catch", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("char", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("checked", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("class", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("const", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("continue", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("decimal", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("default", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("delegate", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("do", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("double", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("else", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("enum", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("event", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("explicit", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("extern", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("false", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("finally", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("fixed", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("float", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("for", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("foreach", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("goto", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("if", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("implicit", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("in", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("int", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("interface", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("internal", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("is", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("lock", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("long", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("namespace", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("new", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("null", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("object", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("operator", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("out", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("override", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("params", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("private", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("protected", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("public", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("readonly", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("ref", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("return", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("sbyte", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("sealed", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("short", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("sizeof", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("stackalloc", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("static", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("string", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("struct", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("switch", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("this", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("throw", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("true", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("try", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("typeof", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("unit", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("ulong", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("unchecked", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("unsafe", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("ushort", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("using", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("using static", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("virtual", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("void", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("volatile", Color.Blue, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("while", Color.Purple, null, DescriptorType.Word, DescriptorRecognition.WholeWord, true));

                shtb.HighlightDescriptors.Add(new HighlightDescriptor("//", Color.Green, null, DescriptorType.ToEOL, DescriptorRecognition.StartsWith, false));
                shtb.HighlightDescriptors.Add(new HighlightDescriptor("/*", "*/", Color.Green, null, DescriptorType.ToCloseToken, DescriptorRecognition.StartsWith, false));
                shtb.Seperators.Add(' ');
                shtb.Seperators.Add('\r');
                shtb.Seperators.Add('\n');
                shtb.Seperators.Add(',');
                shtb.Seperators.Add('.');
                shtb.Seperators.Add('-');
                shtb.Seperators.Add('+');
                shtb.Seperators.Add('(');
                shtb.Seperators.Add(')');
                #endregion

                fileName += ".cs";
                break;
            case FileType.CsProj:
                // Create a new CS Project in the Install Directory.

                break;
        }
        // TODO: Create a custom TabPage class to allow for storing information about the object, such as:
        // TODO: File Name
        // TODO: Save State
        TabPage p = new TabPage();
        p.Text = fileName;
        p.Controls.Add(shtb);
        shtb.Dock = DockStyle.Fill;
        p.Show();

        // TODO: Create a custom TabControl to handle drawing the TabPage controls with custom graphics (Allowing for italics in the title, etc.)
        openFilesTC.TabPages.Add(p);

    }



    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void unloadPluginsToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
        FormCollection openForms = Application.OpenForms;
        if (openForms.Count > 1) // If we have more than 1 form open, we should alert the user that all forms will need to be closed before unloading plugins.
        {
            DialogResult res = MessageBox.Show("Warning: Multiple forms are open.\nTo prevent potential issues, we will close all open forms, other than the Application Designer.",
                "Warning: Multiple Forms Open", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
            if (res == DialogResult.Cancel) return;
            if (res == DialogResult.TryAgain)
            {
                unloadPluginsToolStripMenuItem_Click_1(sender, e);
                return;
            }
        }
        for (int i = 0; i < openForms.Count; i++)
        {
            IForm? currentForm = openForms[i] as IForm;
            if (currentForm == null || currentForm.formID != "73ce6ba2-1f2d-4126-b67a-7b259f529d4b")
            {
                openForms[i].Close();

            }
        }
        Globals.pluginManager.UnloadPlugins();
    }

    private void loadPluginsToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Globals.pluginManager.loadPlugins();
    }

    private void purgeCacheDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        
    }
}
