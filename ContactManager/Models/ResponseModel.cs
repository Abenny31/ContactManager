using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Models
{
    public class ResponseModel
    {
        public bool isError { get; set; }
        public string Message { get;set; }

        public ResponseModel (bool isError, string message)
        {
            this.isError = isError;
            Message = message;
        }
    }
}
