using System;

namespace Lab_15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationLog.ConfigureLogger(new DebugWindowLogger());

            int i = 10;
            int j = 0;

            try
            {
                int result = i / j;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                ApplicationLog.WriteLog(LogLevel.Critical, ex.Message, ex.StackTrace);
            }
        }
    }
}
