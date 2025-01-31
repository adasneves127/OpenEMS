using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using PluginBase;
using System.Windows.Forms;


namespace OpenEMS
{
    public class PluginManager
    {

        private IEnumerable<ICommand> plugins;
        private List<WeakReference> ctxPluginList;
        private bool isLoaded;

        public bool Loaded
        {
            get => isLoaded;
        }

        public PluginManager()
        {
            isLoaded = false;
            ctxPluginList = new List<WeakReference>();
        }

        public void UnloadPlugins()
        {
            // When we want to unload our plugins, we need to recall our LoadContexts.
            // First, we clear our plugins list
            this.plugins = new List<ICommand>();

            // While we still have plugins to be unloaded
            while (this.ctxPluginList.Count > 0)
            {
                // Look into the context list and get the weak reference.
                WeakReference hostAlcWeakRef = this.ctxPluginList[0];
                { // Enter a new scope.
                    // Remove from the list and unload the PluginContext.
                    this.ctxPluginList.RemoveAt(0);
                    PluginLoadContext ctx = hostAlcWeakRef.Target as PluginLoadContext;
                    if (ctx == null) continue;
                    ctx.Unload();
                }
                // While our reference is still alive, and we have not exceeded 10 attempts:
                for (int j = 0; hostAlcWeakRef.IsAlive && (j < 10); j++)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }

            isLoaded = false;
        }

        private Assembly LoadPlugin(string absolutePath)
        {
            Console.WriteLine($"Loading commands from: {absolutePath}");
            PluginLoadContext loadContext = new PluginLoadContext(absolutePath);
            ctxPluginList.Add(new WeakReference(loadContext));
            return loadContext.LoadFromAssemblyName(new AssemblyName(Path.GetFileNameWithoutExtension(absolutePath)));
        }

        private static IEnumerable<ICommand> CreateCommands(Assembly assembly)
        {
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

        public void loadPlugins()
        {
            // Load Plugin files
            string[] pluginPaths = Directory.GetFiles(Globals.pluginCacheFolder, "*.dll", SearchOption.AllDirectories);

            try
            {
                this.plugins = pluginPaths.SelectMany(pluginPath => {
                    Assembly pluginAssembly = LoadPlugin(pluginPath);
                    return CreateCommands(pluginAssembly);
                }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return;
            }

            foreach (ICommand command in this.plugins)
            {
                Console.WriteLine($"{command.Name}\t - {command.Description}");
            }

            isLoaded = true;
        }

        public void openProgram(object? sender, EventArgs e)
        {
            // Get the current element that was clicked
            ToolStripMenuItem? itm = sender as ToolStripMenuItem;
            if (itm == null || itm.Text == null) return;
            // Check if the plugin is loaded in the system.
            foreach (ICommand cmd in this.plugins)
            {
                Console.WriteLine(cmd.Name);
            }

            ICommand? command = this.plugins.FirstOrDefault(c => c.Name == $"{itm.OwnerItem?.Text}/{itm.Text}");
            if (command == null)
            {
                getFiles(itm.OwnerItem?.Text, itm.Text);
                this.loadPlugins();
                command = this.plugins.FirstOrDefault(c => c.Name == $"{itm.OwnerItem?.Text}/{itm.Text}");
                if (command == null)
                {
                    MessageBox.Show($"Error! Could not load program with name of {itm.OwnerItem?.Text}/{itm.Text}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            command.Execute();

        }

        private static void putProgram()
        {

        }

        public static void getFiles(string? PanelGroup, string PanelName)
        {

        }

    }

    public class PluginLoadContext : AssemblyLoadContext
    {
        private AssemblyDependencyResolver _resolver;

        public PluginLoadContext(string pluginPath) : base(isCollectible: true)
        {
            _resolver = new AssemblyDependencyResolver(pluginPath);
        }

        protected override Assembly? Load(AssemblyName assemblyName)
        {
            string? assemblyPath = _resolver.ResolveAssemblyToPath(assemblyName);
            if (assemblyPath != null)
            {
                return LoadFromAssemblyPath(assemblyPath);
            }
            return null;
        }

        protected override nint LoadUnmanagedDll(string unmanagedDllName)
        {
            string? libraryPath = _resolver.ResolveUnmanagedDllToPath(unmanagedDllName);
            if (libraryPath != null)
            {
                return LoadUnmanagedDllFromPath(libraryPath);
            }

            return IntPtr.Zero;
        }
    }
}
