using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_1
{
    public class ConsoleLogger : Logger
    {
        public void WriteLog(LogLevel level, string errorMessage, string additionalInfo)
        {
            Console.WriteLine($"{level}: {errorMessage}");

            if (!string.IsNullOrWhiteSpace(additionalInfo))
            {
                Console.WriteLine(additionalInfo);
            }
        }
    }
}
