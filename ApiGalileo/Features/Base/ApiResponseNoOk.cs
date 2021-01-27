using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Features.Base
{
    public class ApiResponseNoOk : ApiResponse
    {

        public object Result { get; }

        public ApiResponseNoOk(object result)
            : base(400)
        {
            Result = result;
        }
    }
}
