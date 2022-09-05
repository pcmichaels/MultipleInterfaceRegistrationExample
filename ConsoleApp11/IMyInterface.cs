using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal interface IMyInterface
    {
        void Test();

        public string TestId { get; }
    }

    internal class MyService1 : IMyInterface
    {
        public string TestId => "1";

        public void Test()
        {
            Console.WriteLine("My Service 1");
        }
    }

    internal class MyService2 : IMyInterface
    {
        public string TestId => "2";

        public void Test()
        {
            Console.WriteLine("My Service 2");
        }
    }

}
