namespace lexical_analyzer.Models.Tokens
{
    class Braces : ValidatChar
    {
        public string tokenName = "Braces";
        private List<char> characters = new List<char> { '{', '}', '[', ']' };
        public override bool isValid(char keyword, int stateNumber)
        {
            if (characters.Contains(keyword))
            {
                ScannerControl.instance.printValidToken(tokenName, keyword.ToString());
                return true;
            }
            ScannerControl.instance.setState(stateNumber);
            return false;
        }
    }
}
