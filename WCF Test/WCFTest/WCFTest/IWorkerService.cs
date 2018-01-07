using Entities;
using System.ServiceModel;

namespace WCFTest
{
    [ServiceContract]
    public interface IWorkerService
    {
        [OperationContract]
        Response GetData(Request request);
    }
}
