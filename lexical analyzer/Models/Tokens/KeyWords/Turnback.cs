namespace lexical_analyzer.Models.Tokens
{
    class Turnback : ValidatKeyWords
    {
        public static string Tokenname = "Turnback";

        private List<char> characters = new List<char> { 'T','u','r','n','b','a','c','k' };
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
