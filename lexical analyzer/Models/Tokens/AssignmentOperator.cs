namespace lexical_analyzer.Models.Tokens
{
    public class AssignmentOperator
    {
        public static string tokenName = "assignment";

        public bool isValid(string keyWord, int stateNumber)
        {
            if (keyWord == "=")
            {
                CompilerManager.instance.validToken(tokenName, keyWord);
                return true;
            }
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
    }
}
