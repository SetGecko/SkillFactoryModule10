using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public interface ISum
    {
        int Sum(int a, int b);
    }

    public interface ILogger
    {
        void EventLog(string message);

        void ErrorLog(string message);
    }
}
