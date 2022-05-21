namespace lexical_analyzer.Models.Tokens
{
    public class Constants
    {
        public static string tokenName = "constant";
        private List<char> digits = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public bool isValid(string keyWord, int stateNumber)
        {
            for (int i = 0; i < keyWord.Length; i++)
            {
                if (!digits.Contains(keyWord[i]))
                {
                    ScannerControl.instance.setState(stateNumber);
                    return false;
                }
            }
            ScannerControl.instance.printValidToken(tokenName, keyWord);
            return true;
        }
    }
}
