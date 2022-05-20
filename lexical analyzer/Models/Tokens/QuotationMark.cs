namespace lexical_analyzer.Models.Tokens
{
    public class QuotationMark
    {
        public static string tokenName = "quotation";
        private List<char> quotions = new List<char> { '\'', '\"' };

        public bool isValid(char keyWord, int stateNumber)
        {
            if (quotions.Contains(keyWord))
            {
                CompilerManager.instance.validToken(tokenName, keyWord.ToString());
                return true;
            }
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
    }
}
