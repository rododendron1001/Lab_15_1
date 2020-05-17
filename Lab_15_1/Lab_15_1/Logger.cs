using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_15_1
{
    public interface Logger
    {
        public void WriteLog(LogLevel level, string errorMessage)
        {
            WriteLog(level, errorMessage, string.Empty);
        }

        public abstract void WriteLog(LogLevel level, string errorMessage, string additionalInfo);
    }
}
