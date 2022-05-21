namespace lexical_analyzer.Models.Tokens
{
    class QuotationMark : ValidatChar
    {
        public static string tokenName = "quotation";
        private List<char> quotions = new List<char> { '\'', '\"' };

        public override bool isValid(char keyWord, int stateNumber)
        {
            if (quotions.Contains(keyWord))
            {
                ScannerControl.instance.printValidToken(tokenName, keyWord.ToString());
                return true;
            }
            ScannerControl.instance.setState(stateNumber);
            return false;
        }
    }
}
