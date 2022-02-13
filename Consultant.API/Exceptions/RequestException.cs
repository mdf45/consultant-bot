using Consultant.Shared.Entity.Http;

namespace Consultant.API.Exceptions
{
    public class RequestException : Exception
    {
        public EResponseCode Code { get; set; }

        public RequestException(EResponseCode code)
        {
            Code = code;
        }
    }
}
