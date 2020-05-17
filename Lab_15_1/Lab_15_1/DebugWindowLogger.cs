using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_1
{
    public class DebugWindowLogger : Logger
    {
        public void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            System.Diagnostics.Debug.WriteLine($"{level}: {errorMessage}");

            if (!string.IsNullOrWhiteSpace(additionalInfo))
            {
                System.Diagnostics.Debug.WriteLine(additionalInfo);
            }
        }
    }
}
