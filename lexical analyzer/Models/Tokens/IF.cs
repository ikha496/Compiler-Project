using System;

namespace Compiler-Project.Models.Tokens
{
    public class If
    {
        public static string tokenName = "If";

        private List<char> characters = new List<char> { 'I', 'f' };
        public bool validate(string keyword, int stateNumber)
        {
            if (keyword.Length != characters.Count)
            {
                CompilerManager.instance.setState(stateNumber);
                return false;
            }
            for (int i = 0; i < keyword.Length; i++)
            {
                if (keyword[i] == characters[i])
                {
                    CompilerManager.instance.state++;
                }
                else
                {
                    CompilerManager.instance.setState(stateNumber);
                    return false;
                }
            }
            CompilerManager.instance.validToken(tokenName, keyword);
            return true;
        }
    }
}
