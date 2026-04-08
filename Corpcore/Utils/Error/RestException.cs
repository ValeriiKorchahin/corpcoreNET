using System.ComponentModel;
using System.Net;

namespace Corpcore.Utils.Error
{
    public class RestException : Exception
    {
        public object Errors { get; }
        public HttpStatusCode Code { get; }
        public RestException(HttpStatusCode code, string message)
            : base(message)
        {
            Code = code;
            Errors = new { message };
        }

        public RestException(HttpStatusCode code, object errors) 
            : base(errors.ToString()) 
        {
            Code = code;
            Errors = errors;
        }
    }
}
