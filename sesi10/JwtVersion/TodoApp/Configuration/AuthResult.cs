using System.Collections.Generic;

namespace TodoApp.Configuration
{
    public class AuthResult
    {
        public string Token { get; set; }
        public bool Succeess { get; set; }

        public List<string> Errors { get; set; }
    }
}