using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Abstraction.Responses
{
    class ValidatePhoneNumberResponse
    {
        public string PhoneNumber { get; set; }
        public bool ValidationResult { get; set; }
    }
}
