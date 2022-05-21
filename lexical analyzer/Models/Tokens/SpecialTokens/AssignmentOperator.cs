namespace lexical_analyzer.Models.Tokens
{
    public class AssignmentOperator
    {
        public static string tokenName = "assignment";

        public bool isValid(string keyWord, int stateNumber)
        {
            if (keyWord == "=")
            {
                ScannerControl.instance.printValidToken(tokenName, keyWord);
                return true;
            }
            ScannerControl.instance.setState(stateNumber);
            return false;
        }
    }
}
