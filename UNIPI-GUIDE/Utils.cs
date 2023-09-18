using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNIPI_GUIDE
{
    internal class Utils
    {
        /**
        * Displays texts read from the database correctly.
        */
        public static string readMultilineFromDB(string retrieved)
        {
            return retrieved.Replace("\\n", "\n");
        }
    }
}
