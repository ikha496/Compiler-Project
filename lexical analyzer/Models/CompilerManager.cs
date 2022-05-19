namespace lexical_analyzer.Models
{
    public class CompilerManager
    {
        public static CompilerManager instance;
        public int state;
        public List<String> scannerMessages = new List<String>();
        public bool isIdintfire = true;
        public string codeFile { get; set; }
        public void Awake()
        {
            instance = this;
        }
        public void resetState()
        {
            this.state = 0;
        }
        public void setState(int stateNumber)
        {
            this.state = stateNumber;
        }
        public void validToken(string tokenName, string word)
        {
            scannerMessages.Add("Token Text: " + word + "\tToken Type: " + tokenName);
            isIdintfire = false;
        }
    }//Category cat
}
