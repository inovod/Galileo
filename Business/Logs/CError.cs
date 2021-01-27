using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Logs
{
    public class CError : Exception
    {
        public int IdTransaction { get; set; }
        public List<CErrorDet> ErrorDetails { get; set; }

        public CError()
        {
            ErrorDetails = new List<CErrorDet>();
        }
        public CError(CErrorDet error)
        {
            ErrorDetails = new List<CErrorDet> { error };
        }
    }
}
