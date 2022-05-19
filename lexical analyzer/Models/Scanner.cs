namespace lexical_analyzer.Models
{
    public class Scanner
    {
        CompilerController compilerController = new CompilerController();
        public string codeFile { get; set; }
        public void initScanner()
        {
            codeFile = codeFile.Insert(codeFile.Length, " ");
            compilerController.Awake();
            compilerController.resetState();
            compilerController.codeFile = codeFile;
        }
        public void Scan()
        {
            
        }   
    }
}
