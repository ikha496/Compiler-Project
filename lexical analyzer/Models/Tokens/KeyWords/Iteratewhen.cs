namespace lexical_analyzer.Models.Tokens
{
    class Iteratewhen : ValidatKeyWords
    {
        public static string Tokenname = "Iteratewhen";

        private List<char> characters = new List<char> { 'I','t','e','r','a','t','e','w','h','e','n' };
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
