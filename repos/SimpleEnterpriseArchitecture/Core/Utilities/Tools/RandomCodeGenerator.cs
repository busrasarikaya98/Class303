using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Tools
{
    public static class RandomCodeGenerator
    {
        public static string Generate(int length=8,bool alphanumeric =true)
        {
            string words = (alphanumeric)?"ABCDEFGHIJKLMNOPRSTUVYZabcdefghijklmnoprstuvyz0123456789"
                :"0123456789";
            Random random;
            string result = "";
            for(int i=0;i<length;i++)
            {
                random = new Random();
                int index = random.Next(0, words.Length - 1);
                result += words[index];
            }
            return result;
        }
    }
}
