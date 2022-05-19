namespace lexical_analyzer.Models.Tokens
{
    public class Turnback
    {
        public static string Tokenname = "Turnback";

        private List<char> characters = new List<char> { 'T','u','r','n','b','a','c','k' };
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
