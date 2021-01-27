using Microsoft.Extensions.Logging;
using NLog;

namespace ApiGalileo.Api.Log
{
    /// <summary>
    /// Clase para almacenar los diferentes mensajes en funcion de su criticidad
    /// </summary>
    public class GalileoLog : ILog
    {
        private static readonly NLog.ILogger logger = LogManager.GetCurrentClassLogger();

        public void Debug(string message)
        {
            logger.Debug(message);
        }

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Information(string message)
        {
            logger.Info(message);
        }

        public void Warning(string message)
        {
            logger.Warn(message);
        }
    }

}