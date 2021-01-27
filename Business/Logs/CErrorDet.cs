using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Logs
{
    public class CErrorDet : Exception
    { ///
        public string Origen { get; set; }

        public int IdError { get; set; }
        ///
        public string Error { get; set; }
        ///
        public int IdTransaction { get; set; }
        ///
        public string ModelInformation { get; set; }

        ///
        public CErrorDet() : base() { }
        ///
        public CErrorDet(System.Exception inner) : base(string.Empty, inner) { }
        ///
        public CErrorDet(string message) : base(message) { }
        ///
        public CErrorDet(string message, System.Exception inner) : base(message, inner) { }
        ///
        public CErrorDet(string message, string origen) : base(message) { Origen = origen; }
    }
}
