using System;
using System.IO;
using System.Net.Http;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Installer
{
    class Installer
    {
        public static void Main(string[] args)
        {
            string installPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Console.WriteLine("Installing to: " + installPath);

            Console.WriteLine("                                                   \r\n _____             _____     _         _     _     \r\n|     |___ ___ ___|   __|___| |_ ___ _| |_ _| |___ \r\n|  |  | . | -_|   |__   |  _|   | -_| . | | | | -_|\r\n|_____|  _|___|_|_|_____|___|_|_|___|___|___|_|___|\r\n      |_|                                          ");
            installPath = Path.Join(installPath, "OpenSchedule");

            if (Directory.Exists(installPath))
            {
                Console.WriteLine("Warning! The target install directory already exists! Are you sure you wish to proceed? y/n [Default: n]");
                if(Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Aborting Install");
                    return;
                }
                Directory.Delete(installPath, true);
            }
            Console.WriteLine("Beginning Client Install");
            Directory.CreateDirectory(installPath);
            Console.WriteLine("Creating Local Cache Folder");
            Directory.CreateDirectory(Path.Join(installPath, "cache"));
            Console.WriteLine("Downloading Program");
            Directory.CreateDirectory(Path.Join(installPath, "bin"));
            using(HttpClient client = new HttpClient())
            {
                using(Task<Stream> s = client.GetStreamAsync("https://www.adasneves.info/OpenSchedule/data.zip"))
                {
                    using(FileStream stream = new FileStream(Path.Join(installPath, "bin", "data.zip"), FileMode.OpenOrCreate))
                    {
                        s.Result.CopyTo(stream);
                    }
                }
            }
            Console.WriteLine("Download Complete. Unzipping Files");
            ZipFile.ExtractToDirectory(Path.Join(installPath, "bin", "data.zip"), Path.Join(installPath, "bin"));
            File.Delete(Path.Join(installPath, "bin", "data.zip"));
            Console.WriteLine("Creating Desktop Shortcut");
            createShortcut(Path.Join(installPath, "bin", "OpenEMS.exe"));
            Console.WriteLine("Client Install Complete. Press [Enter] to exit...");
            Console.ReadLine();

        }

        static void createShortcut(string exePath)
        {
            IShellLink link = (IShellLink)new ShellLink();

            // setup shortcut information
            link.SetDescription("An Open Source Scheduling Management Tool");
            link.SetPath(exePath);

            // save it
            IPersistFile file = (IPersistFile)link;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            file.Save(Path.Combine(desktopPath, "OpenSchedule.lnk"), false);
        }

        [ComImport]
        [Guid("00021401-0000-0000-C000-000000000046")]
        internal class ShellLink
        {
        }

        [ComImport]
        [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
        [Guid("000214F9-0000-0000-C000-000000000046")]
        internal interface IShellLink
        {
            void GetPath([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszFile, int cchMaxPath, out IntPtr pfd, int fFlags);
            void GetIDList(out IntPtr ppidl);
            void SetIDList(IntPtr pidl);
            void GetDescription([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszName, int cchMaxName);
            void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string pszName);
            void GetWorkingDirectory([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszDir, int cchMaxPath);
            void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string pszDir);
            void GetArguments([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszArgs, int cchMaxPath);
            void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string pszArgs);
            void GetHotkey(out short pwHotkey);
            void SetHotkey(short wHotkey);
            void GetShowCmd(out int piShowCmd);
            void SetShowCmd(int iShowCmd);
            void GetIconLocation([Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder pszIconPath, int cchIconPath, out int piIcon);
            void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string pszIconPath, int iIcon);
            void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string pszPathRel, int dwReserved);
            void Resolve(IntPtr hwnd, int fFlags);
            void SetPath([MarshalAs(UnmanagedType.LPWStr)] string pszFile);
        }


    }
}