using PluginBase;
namespace Plugin2;

public class Class1 : ICommand
{
    public string Name { get => "Administer Development/Maintain Permissions" ; }
    public string Description { get => "Contains the form for maintaining Permissions for users."; }

    private Form1 _f1;

    public int Execute()
    {
        _f1 = new Form1();
        _f1.Show();
        return 1;
    }
}
