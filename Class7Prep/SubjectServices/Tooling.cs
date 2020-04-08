using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    public class Tooling
    {
        public string MainIDE;
        public string AlternativeIDE;

        public int Code;
        public Tooling()
        {
            Code = SubjectCodeGenerator.GenerateSubjectCode();
        }
    }
}
