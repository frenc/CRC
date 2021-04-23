using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Exercises.Exercise5
{
    public sealed class TextConverter
    {
        public string ReversText(string text)
        {
            return string.Concat(text.Reverse());
        }

        public string ReversTextAndChangeLetterSize(string text)
        {
            return string
                .Concat(text
                    .Reverse()
                    .Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));
        }

        public string ReversTextAndChangeLetterSizeBeforeSpecialCharacter(string text)
        {
            var splittedText = text.Split('|');
            var reversedTest = string.Concat(splittedText[0]
                .Reverse()
                .Select(x => char.IsLower(x) ? char.ToUpper(x) : char.ToLower(x)));
            
            return $"{reversedTest}|{splittedText[1]}";
        }
    }
}
