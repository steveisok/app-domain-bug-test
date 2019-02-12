using System;
using System.Web;
using System.Web.Hosting;
using ADHost;

namespace App
{
    public class TestApp
    {
        public static void Main()
        {
            HostingTest test;
            Console.WriteLine("Starting... in " + AppDomain.CurrentDomain.Id.ToString() + " at: " + AppDomain.CurrentDomain.BaseDirectory);

            ApplicationManager appMan = ApplicationManager.GetApplicationManager();

            test = appMan.CreateObject("TestDomain", typeof(HostingTest), "/", @"/Users/steveman/Projects/web-folder/", true) as HostingTest;

            Console.WriteLine("Before method call in " + AppDomain.CurrentDomain.Id.ToString() + " at: " + AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine("\n\n\n");

            test.RunTest();

            Console.WriteLine("\n\nDone");
        }
    }
}