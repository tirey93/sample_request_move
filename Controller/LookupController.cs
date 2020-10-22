using sample_request_move.Abstraction.RequestManagement;
using sample_request_move.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Controller
{
    class LookupController : FakeApi
    {
        private readonly ILookupApplication _application;

        public LookupController(ILookupApplication application)
        {
            _application = application;
        }

        public string ValidatePhoneNumber(object request, string phoneNumber)
        {
            try
            {
                var result = _application.ValidatePhoneNumber(phoneNumber);
                new RequestCompletedLookup(request, "007", "user", "productName");
                return Ok(result);
            }
            catch (Exception ex)
            {
                new RequestFaileldLookup(request, "007", "user", "productName", ex);
                return StatusCode(500);
            }
        }
    }
}
