using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGalileo.Api.Log
{
    /// <summary>
    /// Interface para los mensajes de error
    /// </summary>
    public interface ILog
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Information(string message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Warning(string message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Debug(string message);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        void Error(string message);

    }
}
