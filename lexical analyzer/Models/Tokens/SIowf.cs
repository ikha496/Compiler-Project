﻿using System;

namespace Compiler-Project.Models.Tokens
{
    public class SIowf
    {
        public string tokenName = "SIowf";

        private List<char> characters = new List<char> { 'S', 'I', 'o', 'w', 'f' };

        public bool isValid(string keyword, int stateNumber)
        {
            if (keyword.Length != characters.Count)
            {
                CompilerManager.instance.setState(stateNumber);
                return false;
            }
            for (int i = 0; i < keyword.Length; i++)
            {
                if (keyword[i] == characters[i])
                {
                    CompilerManager.instance.state++;
                }
                else
                {
                    CompilerManager.instance.setState(stateNumber);
                    return false;
                }
            }
            CompilerManager.instance.validToken(tokenName, keyword);
            return true;
        }
    }
}