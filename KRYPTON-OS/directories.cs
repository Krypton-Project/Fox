using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace krypto_os
{
    class Directories
    {
        /// <summary>
        /// This is the string declarations for the filesytem.
        /// This code will only work when the GUI is run on-top of a Windows system.
        /// Different GUI code is required when run as a stand-alone
        /// </summary>
        public static string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/krypton/fox/filesystem/";
        public static string bin = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "/krypton/fox/filesystem/bin/";
        public static string bcore_system = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer) + "/krypton/fox/filesystem/core/";
        
    }
}