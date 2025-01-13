using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PluginBase;

namespace OpenEMS
{
    public class Globals
    {

        public static IEnumerable<ICommand>? plugins;
        public static string? username;
        public static string? password;
        public static string? db_host;
        public static string? db_name;
        public static int port;
        public static string connString {get {
             return "server=" + db_host + ";uid=" + username +
                                ";pwd=" + password + ";database=" + db_name;
        }}
    }
}