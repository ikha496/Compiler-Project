namespace lexical_analyzer.Models.Tokens
{
    class Loopwhen : ValidatKeyWords
    {
        public static string Tokenname = "Loopwhen";

        private List<char> characters = new List<char> { 'L','o','o','p','w','h','e','n' };
        public override bool isValid(string keyword, int stateNumber)
        {
            if (keyword.Length != characters.Count)
            {
                ScannerControl.instance.setState(stateNumber);
                return false;
            }
            for (int i = 0; i < keyword.Length; i++)
            {
                if (keyword[i] == characters[i])
                {
                    ScannerControl.instance.state++;
                }
                else
                {
                    ScannerControl.instance.setState(stateNumber);
                    return false;
                }
            }
            ScannerControl.instance.printValidToken(Tokenname, keyword);
            return true;
        }
    }
}
