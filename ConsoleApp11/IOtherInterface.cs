using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal interface IOtherInterface
    {
        void SomeMethod();
    }

    internal class OtherClass : IOtherInterface
    {
        private readonly IMyInterface _myInterface;

        public OtherClass(IEnumerable<IMyInterface> myInterfaces)
        {
            _myInterface = myInterfaces.First(a => a.TestId == "1");            
        }

        public void SomeMethod()
        {
            Console.WriteLine("OtherClass");

            _myInterface.Test();
        }
    }
}
