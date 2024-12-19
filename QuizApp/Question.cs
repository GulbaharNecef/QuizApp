using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Question
    {
        public string Text { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOption { get; set; }

        public Question(string text, List<string> options, int correctOption)
        {
            Text = text;
            Options = options;
            CorrectOption = correctOption;
        }
    }
}
