namespace lexical_analyzer.Models.Tokens
{
    public class Worthless
    {
        public static string Tokenname = "Worthless";

        private List<char> characters = new List<char> { 'W','o','r','t','h','l','e','s','s' };
        public bool isValid(string keyword, int stateNumber)
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
            CompilerManager.instance.validToken(Tokenname, keyword);
            return true;
        }
    }
}
