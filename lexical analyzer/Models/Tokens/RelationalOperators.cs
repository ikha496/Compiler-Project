namespace lexical_analyzer.Models.Tokens
{
    public class RelationalOperators
    {
        public static string tokenName = "relationalOperator";

        public bool isValid(string keyWord, int stateNumber)
        {
            if(keyWord.Length == 1)
            {
                if (keyWord[0] == '>' || keyWord[0] == '<')
                {
                    CompilerManager.instance.validToken(tokenName, keyWord);
                    return true;
                }
            }
            else if (keyWord.Length == 2)
            {
                if (keyWord[0] == '>' || keyWord[0] == '<' || keyWord[0] == '!' || keyWord[1] == '=')
                {
                    if (keyWord[1] == '=' || keyWord[1] == '=' || keyWord[1] == '=')
                    {
                        CompilerManager.instance.validToken(tokenName, keyWord);
                        return true;
                    }
                }
            }
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
    }
}
