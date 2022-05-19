using System;

namespace Compiler-Project.Models.Tokens
{
    public class TokenDelimiter
    {
        public static string name = "TokenDelimiter";

        public static List<string> tokenDelimiterList = new List<string> { " ", "\n", "\t"};
        public string Delimiter { get; set; }
        bool isValid()
        {
            if (tokenDelimiterList.Contains(this.Delimiter)) 
            { 
                CompilerManager.instance.state++; 
                return true; 
            }
            return false;
        }
    }

}
