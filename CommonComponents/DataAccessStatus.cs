using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents
{
    public class DataAccessStatus
    {
        public string Status { get; set; }
        public bool OperationSucceded { get; set; }
        public string ExceptionMessage { get; set; }
        public string CustomMessage { get; set; }
        public string HelpLink { get; set; }
        public int ErrorCode { get; set; }
        public string StackTrace { get; set; }

        public void setValues(string status, bool operationSucceded, string exceptionMessage, string customMessage, string helpLink, int errorCode, string stackTrace)
        {
            Status = status ?? string.Copy("");
            OperationSucceded = operationSucceded;
            ExceptionMessage = exceptionMessage ?? string.Copy("");
            CustomMessage = customMessage ?? string.Copy("");
            HelpLink = helpLink ?? string.Copy("");
            ErrorCode = errorCode;
            StackTrace = stackTrace ?? string.Copy("");
        }

        public string getFormatedValues()
        {
            return $"Status--> {Status}\nOperationSucceded-->{OperationSucceded}\nExceptionMessage--> {ExceptionMessage}\nCustomMessage--> {CustomMessage}\nHelpLink{HelpLink}\nStackTrace{StackTrace}";

        }
    }
}
