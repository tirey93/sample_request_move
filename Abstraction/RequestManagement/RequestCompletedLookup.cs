using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Abstraction.RequestManagement
{
    class RequestCompletedLookup : RequestSender
    {
        public RequestCompletedLookup(object request, string client, string user, string productName)
        {
            object command = SetFields(request, client, user, productName);
            Send(command);
        }

        private object SetFields(object request, string client, string user, string productName)
        {
            throw new NotImplementedException();
        }
    }
}
