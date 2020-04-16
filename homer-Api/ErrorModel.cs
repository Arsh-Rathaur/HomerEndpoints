using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomerEndpoints
{
    public class ErrorModel<T>
    {
        public Utility.HttpCodes.Codes Code { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
