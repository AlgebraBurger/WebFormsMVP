using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyInvites2.Presenters.Results
{
    public class RedirectResult : IResult
    {
        private string url;
        public RedirectResult(string urlValue)
        {
            url = urlValue;
        }
        public string Url
        {
            get
            {
                return url;
            }
        }
    }
}
