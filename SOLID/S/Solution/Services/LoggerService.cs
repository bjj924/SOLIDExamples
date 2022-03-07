using SOLID.S.Solution.Interfaces;
using System;
using System.IO;

namespace SOLID.S.Solution.Services
{
    public class LoggerService: ILoggerService
    {
        public LoggerService()
        {
            //here we need to write the code for inicialization
            // that is creating the log file with necessary details
        }

        public void Info(string info) 
        {
            // here we need to write the code for info information into the ErrorLog text file
        }

        public void Debug(string info)
        {
            // here we need to write the code for debug information into the ErrorLog text file
        }

        public void Error(string message, Exception ex)
        {
            // here we need to write the code for error information into the ErrorLog text file
        }


    }
}
