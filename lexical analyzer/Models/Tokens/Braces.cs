namespace Compiler-Project.Models.Tokens
{
    public class Braces
    {
        public string tokenName = "Braces";

        private List<char> characters = new List<char> { '{', '}', '[', ']' };
        public bool isValid(char keyword, int stateNumber)
        {
            if (characters.Contains(keyword))
            {
                CompilerManager.instance.validToken(tokenName, keyword.ToString());
                return true;
            }
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
    }
}
