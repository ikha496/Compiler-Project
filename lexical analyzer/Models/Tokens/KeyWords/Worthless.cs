namespace lexical_analyzer.Models.Tokens
{
    class Worthless : ValidatKeyWords
    {
        public static string Tokenname = "Worthless";

        private List<char> characters = new List<char> { 'W','o','r','t','h','l','e','s','s' };
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
