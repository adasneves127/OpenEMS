using System.Reflection;

namespace OpenEMS;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Login login = new Login();
        DialogResult result = login.ShowDialog();
        if (result != DialogResult.OK) return;
        Globals.username = login.txtUsername.Text;
        Globals.password = login.txtPassword.Text;
        Globals.db_host = login.txtFQDN.Text;
        Globals.db_name = login.txtDBName.Text;
        Globals.port = 3306;

        // Create the Plugin Cache Folder, if it doesn't exist.
        Directory.CreateDirectory(Globals.pluginCacheFolder);
        Directory.CreateDirectory(Path.Join(Globals.installPath, "localProjects"));
        Globals.pluginManager = new PluginManager();
        

        // System.Console.WriteLine("Init");
        Application.Run(new AppDesigner());
    }    


    
}