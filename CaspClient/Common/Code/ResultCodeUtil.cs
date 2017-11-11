using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace CaspClient.Common.Code
{
    public class ResultCodeUtil
    {
        private static Dictionary<string, string> dictionary;

        public static void init()
        {
            dictionary = new Dictionary<string, string>();
            Assembly executingAssembly = typeof(ResultCodeUtil).GetTypeInfo().Assembly;
            Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(executingAssembly.GetName().Name + ".Common.Code.CodeMess.properties");
            StreamReader streamReader = new StreamReader(manifestResourceStream);
            string text;
            while ((text = streamReader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(text) && !text.StartsWith(";") && !text.StartsWith("#") && !text.StartsWith("'") && text.Contains("="))
                {
                    int num = text.IndexOf('=');
                    string key = text.Substring(0, num).Trim();
                    string text2 = text.Substring(num + 1).Trim();
                    if ((text2.StartsWith("\"") && text2.EndsWith("\"")) || (text2.StartsWith("'") && text2.EndsWith("'")))
                    {
                        text2 = text2.Substring(1, text2.Length - 2);
                    }
                    dictionary.Add(key, text2);
                }
            }
        }

        public static string getCodeMess(string resultCode)
        {
            if (dictionary.ContainsKey(resultCode))
            {
                return dictionary[resultCode];
            }
            return null;
        }
    }
}
