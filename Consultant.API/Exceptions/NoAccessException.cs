using Consultant.Shared.Entity.Http;

namespace Consultant.API.Exceptions
{
    public class NoAccessException : Exception
    {
        public EResponseCode Code { get; set; }

        public NoAccessException(EResponseCode code)
        {
            Code = code;
        }
    }
}
