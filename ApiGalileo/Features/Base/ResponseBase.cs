using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Base
{
    public class ResponseBase
    {
        public bool bOK { get; set; }
        public object Response { get; set; }
    }
}
