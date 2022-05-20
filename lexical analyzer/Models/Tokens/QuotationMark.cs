namespace lexical_analyzer.Models.Tokens
{
    public class QuotationMark
    {
        public static string tokenName = "quotation";
        private List<char> quotions  = new List<char> { '\'', '\"' };

        public bool isValid(char keyWord, int stateNumber)
        {
            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!quotions.Contains(keyWord[i]))
                {
                    CompilerManager.instance.setState(stateNumber);
                    return false;
                }
            }
            CompilerManager.instance.validToken(tokenName, keyWord);
            return true;
        }
    }
}
