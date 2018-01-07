using System;
using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class Request
    {
        [DataMember]
        public Guid SessionId { get; set; }
    }
}
