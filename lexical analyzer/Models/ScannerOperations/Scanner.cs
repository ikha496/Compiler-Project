using lexical_analyzer.Models.Tokens;

namespace lexical_analyzer.Models
{
    public class Scanner
    {
        public ScannerControl compilerManager = new ScannerControl();
        int errorCounter = 0;
        Chain chain = new Chain();
        Chlo chlo = new Chlo();
        
        Else elsee =new Else();
        
        If iff =new If();
        Include include = new Include();    
        Iow iow = new Iow();
        Iowf iowf = new Iowf();
        Iteratewhen iteratewhen = new Iteratewhen();
        
        Loli loli = new Loli();
        Loopwhen loopwhen = new Loopwhen();
        
        SIow sIow = new SIow();
        SIowf sIowf = new SIowf();
        Stop stop = new Stop();
        
        Turnback turnback = new Turnback();
        
        Worthless worthless = new Worthless();
        
        AccessOperator accessOperator = new AccessOperator();
        ArithmeticOperations arithmeticOperations = new ArithmeticOperations();
        AssignmentOperator assignmentOperator = new AssignmentOperator();
        Braces braces = new Braces();
        Constants constants = new Constants();
        LogicalOperators logicalOperators = new LogicalOperators();
        QuotationMark quotationMark = new QuotationMark();
        RelationalOperators relationalOperators = new RelationalOperators();
        
        Identifier identifier = new Identifier();
        public string fileContent { get; set; }
        public void initScanner()
        {
            fileContent = fileContent.Insert(fileContent.Length, " ");
            compilerManager.Awake();
            compilerManager.resetState();
            compilerManager.codeFile = fileContent;
        }
        public void Scan()
        {
            string word = "";
            for (int i = 0; i < fileContent.Length; ++i)
            {
                if (!TokenDelimiter.tokenDelimiterList.Contains(fileContent[i].ToString()))
                {
                    word += fileContent[i];
                }
                else 
                {
                    switch(word[0])
                    {
                        case 'C':
                            ScannerControl.instance.setState(59);
                            if (chain.isValid(word, 59)) { break; }
                            else if (chlo.isValid(word, 59)) { break; }
                            else { break; }
                        case 'E':
                            ScannerControl.instance.setState(66);
                            elsee.isValid(word,66);
                            break;
                        case 'I':
                            ScannerControl.instance.setState(30);
                            if (iff.isValid(word, 30)) { break; }
                            else if (include.isValid(word, 30)) { break; }
                            else if (iow.isValid(word, 30)) { break; }
                            else if (iowf.isValid(word, 30)) { break; }
                            else if (iteratewhen.isValid(word, 30)) { break; }
                            else { break; }
                        case 'L':
                            ScannerControl.instance.setState(20);
                            if (loli.isValid(word, 20)) { break; }
                            else if (loopwhen.isValid(word, 20)) { break; }
                            else { break; }
                        case 'S':
                            ScannerControl.instance.setState(51);
                            if (sIowf.isValid(word, 51)) { break; }
                            else if (sIow.isValid(word, 51)) { break; }
                            else if (stop.isValid(word, 51)) { break; }
                            else { break; }
                        case 'T':
                            ScannerControl.instance.setState(3);
                            turnback.isValid(word, 3);
                            break;
                        case 'W':
                            ScannerControl.instance.setState(11);
                            worthless.isValid(word, 11);
                            break;
                        case '\'':  
                            ScannerControl.instance.setState(120);
                            quotationMark.isValid(word[0], 120);    
                            break;
                        case '\"':
                            ScannerControl.instance.setState(121);
                            quotationMark.isValid(word[0], 121);
                            break;
                        case '.':
                            ScannerControl.instance.setState(91);
                            break;
                        case '+':
                            ScannerControl.instance.setState(90);
                            arithmeticOperations.isValid(word[0], 90);
                            break;
                        case '-':
                            ScannerControl.instance.setState(89);
                            arithmeticOperations.isValid(word[0], 89);
                            break;
                        case '/':
                            ScannerControl.instance.setState(87);
                            arithmeticOperations.isValid(word[0], 87);
                            break;
                        case '*':
                            ScannerControl.instance.setState(88);
                            arithmeticOperations.isValid(word[0], 88);
                            break;
                        case '{':
                            ScannerControl.instance.setState(82);
                            braces.isValid(word[0], 82);
                            break;
                        case '}':
                            ScannerControl.instance.setState(83);
                            braces.isValid(word[0], 83);
                            break;
                        case '[':
                            ScannerControl.instance.setState(80);
                            braces.isValid(word[0], 80);
                            break;
                        case ']':
                            ScannerControl.instance.setState(81);
                            braces.isValid(word[0], 81);
                            break;
                        case '~':
                            ScannerControl.instance.setState(86);
                            logicalOperators.isValid(word, 86);  
                            break;
                        case '&':
                            ScannerControl.instance.setState(78);
                            logicalOperators.isValid(word, 78);
                            break;
                        case '|':
                            ScannerControl.instance.setState(76);
                            relationalOperators.isValid(word, 76);
                            break;
                        case '<':
                            ScannerControl.instance.setState(70);
                            relationalOperators.isValid(word, 70);
                            break;
                        case '>':
                            ScannerControl.instance.setState(74);
                            relationalOperators.isValid(word, 74);
                            break;
                        case '=':
                            ScannerControl.instance.setState(84);
                            assignmentOperator.isValid(word, 84);
                            break;
                        case '!':
                            ScannerControl.instance.setState(72);
                            relationalOperators.isValid(word, 72);
                            break;
                        case '0':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '1':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '2':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '3':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '4':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '5':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '6':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '7':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '8':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case '9':
                            ScannerControl.instance.setState(2);
                            constants.isValid(word, 2);
                            break;
                        case ';':                                       //doesn't have a state
                            ScannerControl.instance.setState(144);
                            ScannerControl.instance.printValidToken(word, "Semi Coln");
                            break;

                    }
                    if (compilerManager.isIdintfire)
                    {
                        if (!identifier.isValid(word, compilerManager.state))
                        {
                            compilerManager.scannerMessages.Add("Error in Token Text: " + word);
                            errorCounter++;
                        }
                    }
                    compilerManager.isIdintfire = true;
                    word = "";
                }
            }
            compilerManager.scannerMessages.Add("Total number of Errors: " + errorCounter);
        }  
    }
}
