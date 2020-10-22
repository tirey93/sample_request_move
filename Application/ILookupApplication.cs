using sample_request_move.Abstraction.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Application
{
    interface ILookupApplication
    {
        ValidatePhoneNumberResponse ValidatePhoneNumber(string phoneNumber);
    }
}
