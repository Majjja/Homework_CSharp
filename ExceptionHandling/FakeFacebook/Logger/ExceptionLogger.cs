using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FakeFacebook.Logger
{
    public class ExceptionLogger
    {
        private string FilePath { get; set; } = @"D:\WEB DEVELOPER\SEDC Code Academy\5. C#_Basic\HOMEWORKS\Homework_CSharp\ExceptionHandling\ExceptionLogger";

        public void LogUserExceptions(Exception ex)
        {
            StreamWriter sw = new StreamWriter(FilePath);
            sw.WriteLine($"Name: {ex.GetType().Name}\nMessage: {ex.Message}\nStack Trace: {ex.StackTrace}");
            sw.Close();
        }

        public void LogAdminExceptions(Exception ex)
        {
            var sw = new StreamWriter(FilePath);
            sw.WriteLine($"Name: {ex.GetType().Name}\nMessage: {ex.Message}\nStack Trace: {ex.StackTrace}");
            sw.Close();
        }
    }
}
