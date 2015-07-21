using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OHPanelApi
{

    /// <summary>
    /// Data formats
    /// </summary>
    public enum DataFormat
    {
        Json,
        Xml
    }

    /// <summary>
    /// HTTP method to use when making requests
    /// </summary>
    public enum Method
    {
        GET,
        POST,
        PUT,
        DELETE,
        HEAD,
        OPTIONS,
        PATCH,
        MERGE,
    }


    /// <summary>
    /// Status for responses
    /// </summary>
    public enum ResponseStatus
    {
        None,
        Completed,
        Error,
        TimedOut,
        Aborted
    }
}
