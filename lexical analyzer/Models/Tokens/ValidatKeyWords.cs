namespace lexical_analyzer.Models.Tokens
{
    abstract class ValidatKeyWords
    {
        public abstract bool isValid(string keyword, int stateNumber);
    }
}
