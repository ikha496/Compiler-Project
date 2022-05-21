namespace lexical_analyzer.Models.Tokens
{
    abstract class ValidatChar
    {
        public abstract bool isValid(char word, int stateNumber);
    }
}
