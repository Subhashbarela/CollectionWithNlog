using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogProgrammingConcept
{
    public class Nlog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
        public void LogInfoUsingKey(string message, int key, string value)
        {
            logger.Info(key);
            logger.Info(value);
        }
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
        public void LogError(string message)
        {
            logger.Error(message);
        }
    }
}

    

