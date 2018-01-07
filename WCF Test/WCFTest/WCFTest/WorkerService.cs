using System;
using Entities;

namespace WCFTest
{
    public class WorkerService : IWorkerService
    {
        public Response GetData(Request request)
        {
            Response response = new Response() { SessionId = request.SessionId };

            return response;
        }
    }
}
