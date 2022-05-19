namespace Compiler-Project.Models.Tokens
{
    public class Braces
    {
        public string tokenName = "Braces";

        private List<char> characters = new List<char> { '{', '}', '[', ']' };
        public bool isValid(char word, int stateNumber)
        {
            if (characters.Contains(word))
            {
                CompilerManager.instance.validToken(tokenName, word.ToString());
                return true;
            }
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
    }
}
