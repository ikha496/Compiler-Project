namespace lexical_analyzer.Models.Tokens
{
    class Stop : ValidatKeyWords
    {
        public static string Tokenname = "Stop";

        private List<char> characters = new List<char> { 'S','t','o','p' };
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
