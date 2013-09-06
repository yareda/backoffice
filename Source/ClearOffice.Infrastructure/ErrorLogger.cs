using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ClearOffice.Infrastructure
{
    public class ErrorLogger
    {
        /// <summary>
        /// Logs errors to a persistent store (Database/EventLog) after an error has occured. This will enable
        /// us to inspect runtime errors after deployment.
        /// </summary>
        /// <param name="source">The soruce of the error (Form/Entity/Workflow) </param>
        /// <param name="ex">The actual exception that has occured</param>        
        public static void LogError(object source, Exception ex)
        {
            EventLog elog = new EventLog();
            if (!EventLog.SourceExists(source.ToString()))
            {
                EventLog.CreateEventSource(source.ToString(),"Application");
            }
            elog.Source = source.ToString();
            elog.WriteEntry(ex.Message);
        }
    }
}
