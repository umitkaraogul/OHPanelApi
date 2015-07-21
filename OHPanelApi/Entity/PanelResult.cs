using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace OHPanelApi
{
    [Serializable]
    public class PanelResult
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public int ErrorCode { get; set; }

        public PanelResult() 
        { 
        }
        //public PanelResult(IResult) 
        //{ 
        
        //}
    }


}
