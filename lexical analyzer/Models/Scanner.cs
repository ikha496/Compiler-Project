namespace lexical_analyzer.Models
{
    public class Scanner
    {
        CompilerManager compilerManager = new CompilerManager();
        public string codeFile { get; set; }
        public void initScanner()
        {
            codeFile = codeFile.Insert(codeFile.Length, " ");
            compilerManager.Awake();
            compilerManager.resetState();
            compilerManager.codeFile = codeFile;
        }
        public void Scan()
        {
            
        }   
    }
}
