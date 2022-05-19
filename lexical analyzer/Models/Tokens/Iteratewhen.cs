namespace lexical_analyzer.Models.Tokens
{
    public class Iteratewhen
    {
        public static string Tokenname = "Iteratewhen";

        private List<char> characters = new List<char> { 'I','t','e','r','a','t','e','w','h','e','n' };
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
