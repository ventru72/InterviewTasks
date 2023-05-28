using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tasks
{
    public static class Task1
    {
        public static string Compress(string str)
        {
            List<string> list = new List<string>();
            int count = 1;
            string a = string.Empty;
            if (str.Length < 2) return str;

            else if (str.Length >= 2)
            {
                for (int i = 1; i < str.Length; i++)
                {
                    var f = str[i];
                    if (str[i - 1].Equals(str[i]))
                    {
                        count++;
                        if (i == str.Length - 1)
                        {
                            a = count.ToString();
                            a = a == "1" ? "" : a;
                            list.Add(str[i - 1].ToString() + a);
                        }
                    }
                    else
                    {
                        a = count.ToString();
                        a = a == "1" ? "" : a;
                        list.Add(str[i - 1].ToString() + a);
                        count = 1;
                        if (i == str.Length - 1) list.Add(str[i].ToString());
                    }
                }
            }
            return string.Join("", list);
            //StringBuilder stringBuilder = new StringBuilder();
            //str.GroupBy(x => x).Select(x => new { k = x.Key, c = x.Count() }).ToList().ForEach(x => stringBuilder.Append(x.k.ToString() + x.c.ToString()));
            //string result = stringBuilder.ToString();
        }
        public static string Decompress(string str)
        {
            Regex regex = new Regex(@"\d");
            StringBuilder sbStr = new StringBuilder();
            StringBuilder sbNumber = new StringBuilder();

            foreach (var i in str.Reverse().ToArray())
            {
                if (!regex.IsMatch(i.ToString()))
                {
                    sbStr.Append(new string(i, sbNumber.Length > 0 ? Convert.ToInt32(sbNumber.ToString()) : 1));
                    sbNumber.Clear();
                }
                else sbNumber.Append(i.ToString());
            }
            return String.Join("", sbStr.ToString().Reverse().ToArray());
        }
    }
}
                         