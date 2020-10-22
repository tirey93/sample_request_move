using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_request_move.Abstraction.RequestManagement
{
    abstract class RequestSender
    {
        protected object request;
        protected string client;
        protected string user;
        protected string productName;

        protected object mediator;

        protected void Send(object command)
        {
            throw new NotImplementedException();
        }
    }
}
