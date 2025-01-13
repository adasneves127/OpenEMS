using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenEMS
{
    public class Utils
    {
        public static string fetchFile(string progName){
            DBConnection conn = new DBConnection(Globals.connString);
            return "";
        }

        public static void putFile(string progPath){
            
            System.Console.WriteLine(Globals.connString);
            DBConnection conn = new DBConnection(Globals.connString);
            AppDesigner.saveFile(@"C:\Users\Alex Dasneves\source\repos\OpenEMS\OpenEMS\bin\Debug\net9.0-windows\OpenEMS.dll");
        }
    }
}