namespace lexical_analyzer.Models.Tokens
{
    public class LogicalOperators
    {
        public static string name = "logical";

        public bool isValid(string keyWord, int stateNumber)
        {
            if (keyWord.Length == 1 && keyWord[0] == '~')
            {
                ScannerControl.instance.printValidToken(name, keyWord);
                return true;
            }
            else if (keyWord.Length == 2)
            {
                if ((keyWord[0] == '&' && keyWord[1] == '&') || (keyWord[0] == '|' && keyWord[1] == '|'))
                {
                    ScannerControl.instance.printValidToken(name, keyWord);
                    return true;
                }
            }
            ScannerControl.instance.setState(stateNumber);
            return false;
        }
    }
}
