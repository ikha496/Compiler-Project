namespace lexical_analyzer.Models.Tokens
{
    public class ArithmeticOperations
    {
        public static string tokenName = "arithmetic";
        private List<char> operations = new List<char> { '+', '-', '*', '/' };

        public bool isValid(char word, int stateNumber)
        {
            if (operations.Contains(word))
            {
                CompilerManager.instance.validToken(tokenName, word.ToString());
                return true;
            }
            CompilerManager.instance.setState(stateNumber);
            return false;
        }
    }
}
