using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    public interface ILogging
    {
        void Log(string text);

        void LogFormat(string text, params object[] p);

    }
}
