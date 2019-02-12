using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;

namespace ADHost
{
    public class HostingTest : MarshalByRefObject, IRegisteredObject
    {
        public void RunTest()
        {
            Console.WriteLine("Hello from " + AppDomain.CurrentDomain.Id.ToString() + " at: " + AppDomain.CurrentDomain.BaseDirectory);
        }

        public void Stop(bool immediate)
        {
            Console.WriteLine("Stopping");
        }
    }
}
