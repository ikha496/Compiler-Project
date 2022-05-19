namespace lexical_analyzer.Models.Tokens
{
    public class Else
    {
        public string tokenName = "Else";

        private List<char> characters = new List<char> { 'E', 'l', 's', 'e'};

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
