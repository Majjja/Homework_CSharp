using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    class SubjectCodeGenerator
    {
        public static int GenerateSubjectCode()
        {
            Random rand = new Random();
            int code = rand.Next(1, 10);
            return code;
        }

    }
}
