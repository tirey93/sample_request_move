using sample_request_move.Abstraction.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Application
{
    class LookupApplication : ILookupApplication
    {
        public ValidatePhoneNumberResponse ValidatePhoneNumber(string phoneNumber)
        {
            try
            {
                bool result = RegexCheck(phoneNumber);
                return new ValidatePhoneNumberResponse { PhoneNumber = phoneNumber, ValidationResult = result };
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool RegexCheck(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
