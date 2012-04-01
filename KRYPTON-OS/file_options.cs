/**
 * Copyright © Edward Chernysh (kryptonX)
 * 
    *This program is free software: you can redistribute it and/or modify
    *it under the terms of the GNU General Public License as published by
    *the Free Software Foundation, either version 3 of the License, or
    *(at your option) any later version.

    *This program is distributed in the hope that it will be useful,
    *but WITHOUT ANY WARRANTY; without even the implied warranty of
    *MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    *GNU General Public License for more details.

    *You should have received a copy of the GNU General Public License
    *along with this program.  If not, see <http://www.gnu.org/licenses/>.
 *
  **/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace krypto_os
{
    class file_options
    {
        public string root = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static void file_create(string filename)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
            {
                sw.Write("");
                sw.Dispose();
            }
        }

        public static void file_write(string filename, string data)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
            {
                sw.Write(data);
                sw.Dispose();
            }
        }

        public static void directory_create(string path, string name)
        {
           
        }
    }
}
