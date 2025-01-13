using System.Reflection;
using PluginBase;

namespace OpenEMS;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]

    public static Assembly LoadPlugin(string absolutePath){    
        Console.WriteLine($"Loading commands from: {absolutePath}");
        PluginLoadContext loadContext = new PluginLoadContext(absolutePath);
        return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(absolutePath)));
    }

    public static IEnumerable<ICommand> CreateCommands(Assembly assembly){
        int count = 0;

        foreach (Type type in assembly.GetTypes())
        {
            if (typeof(ICommand).IsAssignableFrom(type))
            {
                ICommand? result = Activator.CreateInstance(type) as ICommand;
                if (result != null)
                {
                    count++;
                    yield return result;
                }
            }
        }

        if (count == 0)
        {
            string availableTypes = string.Join(",", assembly.GetTypes().Select(t => t.FullName));
            throw new ApplicationException(
                $"Can't find any type which implements ICommand in {assembly} from {assembly.Location}.\n" +
                $"Available types: {availableTypes}");
        }
    }

    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        // Load Plugin files
        string[] pluginPaths  = Directory.GetFiles(@"C:\OpenEMS\Cache\OpenEMS\", "*.dll", SearchOption.AllDirectories);
        
        try{
            Globals.plugins = pluginPaths.SelectMany(pluginPath => {
                Assembly pluginAssembly = LoadPlugin(pluginPath);
                return CreateCommands(pluginAssembly);
            }).ToList();
        } catch (Exception e){
            Console.WriteLine(e.ToString());
            return;
        }

        foreach(ICommand command in Globals.plugins){
            Console.WriteLine($"{command.Name}\t - {command.Description}");
        }

        ApplicationConfiguration.Initialize();

        Login login = new Login();
        DialogResult result = login.ShowDialog();
        if (result != DialogResult.OK) return;
        Globals.username = login.txtUsername.Text;
        Globals.password = login.txtPassword.Text;
        Globals.db_host = login.txtFQDN.Text;
        Globals.db_name = login.txtDBName.Text;
        Globals.port = 3306;

        // System.Console.WriteLine("Init");
        Application.Run(new AppDesigner());
    }    
}