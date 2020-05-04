using System;
using System.Collections.Generic;
using System.Text;

namespace SubjectServices
{
    internal class SubjectCodeGenerator
    {
        internal static int GenerateSubjectCode()
        {
            return new Random().Next(0, 10);
        }
    }
}
