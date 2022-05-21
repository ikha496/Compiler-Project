namespace lexical_analyzer.Models.Tokens
{
    public class AccessOperator
    {
        public static string tokenName = "access";

        public bool isValid(string keyWord, int stateNumber)
        {
            if (keyWord.Length == 2 && keyWord[0] == '-' && keyWord[1] == '>')
            {
                ScannerControl.instance.printValidToken(tokenName, keyWord);
                return true;
            }
            ScannerControl.instance.setState(stateNumber);
            return false;
        }
    }
}
