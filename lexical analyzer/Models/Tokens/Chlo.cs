using System;

namespace Compiler-Project.Models.Tokens{
    public class Chlo
    {
        public string tokenName ="Chlo";

        private List<char> characters = new List<char> { 'C', 'h', 'l', '' };
    public bool isValid(string word, int stateNumber)
    {
        if (word.Length != characters.Count)
        {
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == characters[i])
            {
                CompilerManager.instance.state++;
            }
            else
            {
                CompilerManager.instance.setState(stateNumber);
                return false;
            }
        }
        CompilerManager.instance.validToken(tokenName, word);
        return true;
    }
}
}
