using System;

namespace Learning04
{

    public class MathAssignment : Assignment
    {
        private string _textBookSection;
        private string _problmes;

        public MathAssignment(string studentName, string topic, string textBookSection, string problmes)
            :base(studentName, topic)
        {
            _textBookSection = textBookSection;
            _problmes = problmes;
        }

        public string GetHomeworkList()
        {
            return $"{_textBookSection} {_textBookSection}";
        }
    }
}