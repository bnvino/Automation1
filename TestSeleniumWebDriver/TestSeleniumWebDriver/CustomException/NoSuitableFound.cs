using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSeleniumWebDriver.CustomException
{
    public class NoSuitableFound:Exception
    {
        public NoSuitableFound(string msg) : base(msg)
         {

        }
    }
}
