using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OHPanelApi.Panels.Maestro
{
    [Serializable]
    [XmlRoot("Result")]
    [DataContract]
    public class ApiResult<T>:IResult
    {
        [DataMember]
        public int StatusCode { get; set; }
        [DataMember]
        public int ErrorCode { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public T Details { get; set; }
    }

    [Serializable]
    [XmlRoot("Result")]
    [DataContract]
    public class ApiResultList<T>:IResult
    {
        [DataMember]
        public int StatusCode { get; set; }
        [DataMember]
        public int ErrorCode { get; set; }
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public List<T> Details { get; set; }
    }


    public interface IResult
    {
        [DataMember]
        int StatusCode { get; set; }
        [DataMember]
        int ErrorCode { get; set; }
        [DataMember]
        string Message { get; set; }
    }
}
