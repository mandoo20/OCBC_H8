using System.Collections.Generic;

namespace PaymentApi.Configuration
{
    public class AuthResult
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public bool Succeess { get; set; }

        public List<string> Errors { get; set; }
    }

    public class ApiGlobalResult
    {
        public List<string> Message { get; set; }
        public object result { get; set; }
        public bool Success { get; set; }
    }
}