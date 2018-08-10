using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class helper
    {
    }
    class Utility
    {
        public static string[] SplitString(string msg, string StrSplit)
        {
            return SplitString(msg, StrSplit, true);
        }
        public static string[] SplitString(string msg, string StrSplit, bool IsRemoveEmpty)
        {
            if (string.IsNullOrEmpty(msg)) { return new string[] { }; }
            else if (IsRemoveEmpty)
                return msg.Split(new string[] { StrSplit }, StringSplitOptions.RemoveEmptyEntries);
            else { return msg.Split(new string[] { StrSplit }, StringSplitOptions.None); }
        }
        public class CompareDateTime : IComparer<string>//format => "dd/MM/yyyy HH:mm:ss"
        {
            public int Compare(string x, string y)
            {
                string[] arr_x = Utility.SplitString(x, " ");
                string[] arr_y = Utility.SplitString(y, " ");
                string[] date_x = Utility.SplitString(arr_x[0], "/");
                string[] date_y = Utility.SplitString(arr_y[0], "/");
                for (int i = 2; i >= 0; i--)
                {
                    if (date_x[i] != date_y[i])
                        return string.Compare(date_x[i], date_y[i]);
                }
                string[] time_x = Utility.SplitString(arr_x[1], ":");
                string[] time_y = Utility.SplitString(arr_y[1], ":");
                for (int i = 0; i < 3; i++)
                {
                    if (time_x[i] != time_y[i])
                        return string.Compare(time_x[i], time_y[i]);
                }
                return 0;
            }
        }
        public static bool HasMember(string target, string[] set)
        {
            var results = Array.FindAll(set, s => s.Equals(target));
            return results.Length > 0 ? true : false;
        }
    }
}
