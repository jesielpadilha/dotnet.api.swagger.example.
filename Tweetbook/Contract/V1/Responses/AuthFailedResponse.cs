using System.Collections.Generic;

namespace Tweetbook.Domain
{
    public class AuthFailedResponse
    {
        public IEnumerable<string> Errors { get; set; }
    }
}
