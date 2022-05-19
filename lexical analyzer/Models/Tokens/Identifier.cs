namespace lexical_analyzer.Models.Tokens
{
    public class Identifier
    {
        public string Tokenname = "Identifier";
        private List<char> digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private List<char> spicailChracter = new List<char> { '#', '$', '%', ';', '@', '^', '&', '*', '(', ')', '+', '*', '/', '>', '<', '=', '-', '{', '}', '[', ']' };

        public bool isValid(string keyword, int stateNumber)
        {
            if (digits.Contains(keyword[0]) || spicailChracter.Contains(keyword[0]))
            {
                CompilerManager.instance.setState(stateNumber);
                return false;
            }
            else
            {
                CompilerManager.instance.validToken(Tokenname, keyword);
                return true;
            }
        }
    }
}
