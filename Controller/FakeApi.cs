using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Controller
{
    class FakeApi
    {
        public string Ok(object response)
        {
            return "Ok";
        }
        public string StatusCode(int code)
        {
            return code.ToString();
        }
    }
}
