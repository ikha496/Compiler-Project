namespace lexical_analyzer.Models.Tokens
{
    class ArithmeticOperations : ValidatChar
    {
        public static string tokenName = "arithmetic";
        private List<char> operations = new List<char> { '+', '-', '*', '/' };

        public override bool isValid(char word, int stateNumber)
        {
            if (operations.Contains(word))
            {
                ScannerControl.instance.printValidToken(tokenName, word.ToString());
                return true;
            }
            ScannerControl.instance.setState(stateNumber);
            return false;
        }
    }
}
