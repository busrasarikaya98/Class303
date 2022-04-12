using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Log4Net.Loggers
{
    public class DatabaseLogger : BaseLoggerService
    {
        public DatabaseLogger() : base("DatabaseLogger")
        {

        }
    }
    public class FileLogger : BaseLoggerService
    {
        public FileLogger() : base("JsonFileLogger")
        {

        }
    }
}
