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
#define DATA_UNAVAILABLE
#define CANNOT_LOAD_FILES

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

public class VALUES
{
    
    public static class RETURN
    {
        /* Define the RETURN code values: */
        public const int EXIT_SUCCESS = (0);        // As in C's return 0;
        public const int EXIT_ERROR_FATAL = (-1);   // As in EOF
        public const int EXIT_WARNING = (1);        // Why not?
        public const int EXIT_WARNINGS = (2);       // << Hello, World\0!
        public const int EXIT_UNAVAILABLE = (-2);   // Should not happen anyways
        public const int EXIT_CANNOT_LOCATE_WARNING = (-3);     // Fun stuff
        public const int EXIT_CANNOT_LOCATE_ERROR = (-0);   // Is negative zero even mathematically possible? Curious as to how the hardware will handle this. 

        /* Define the RETURN strings: */
        public const string STRING_EXIT_SUCCESS = ("APPLICATION EXITED SUCCESSFULLY");      // Goes along with EXIT_SUCCESS
        public const string STRING_EXIT_ERROR_FATAL = ("APPLICATION RETURNED A FATAL ERROR");
        public const string STRING_WARNING = ("APPLICATION RETURNED A WARNING (Code: 1)");
        public const string STRING_WARNINGS = ("APPLICATION RETURNED WARNINGS");
        public const string STRING_UNAVAILABLE = ("APPLICATION RETURN DATA IS UNAVAILABLE");
        public const string STRING_DATA_UNAVAILABLE = ("DATA IS UNAVAILABLE!"); // Should not happen anyways. IF happens will be treated as a FATAL error!


    }

     
}