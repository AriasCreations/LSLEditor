using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSLEditor.Helpers
{
    internal static class StringCollectionExtension
    {
        internal static string[] ToArray(this StringCollection strings)
        {
            string[] ret = new string[strings.Count];
            strings.CopyTo(ret, 0);
            return ret;
        }

        internal static void set(this StringCollection strings, List<string> newList)
        {
            strings.Clear();
            strings.AddRange(newList.ToArray());
        }
    }
}
