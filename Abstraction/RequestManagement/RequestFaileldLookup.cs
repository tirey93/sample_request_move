using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Abstraction.RequestManagement
{
    class RequestFaileldLookup : RequestSender
    {
        public RequestFaileldLookup(object request, string client, string user, string productName, Exception exception)
        {
            object command = SetFields(request, client, user, productName,exception);
            Send(command);
        }

        private object SetFields(object request, string client, string user, string productName, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
