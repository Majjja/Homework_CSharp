using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    public class Tooling
    {
        public Tooling()
        {
            Code = SubjectCodeGenerator.GenerateSubjectCode();
        }

        public int Code { get; set; }

        public string MainIDE { get; set; }
        public string AlternativeIDE { get; set; }
    }
}
