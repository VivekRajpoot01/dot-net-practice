using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDisconArchDemo
{
    public class MyCustomException: Exception
    {
        public MyCustomException(string msg): base(msg)
        {

        }
    }

    public class IdNotInRangeException: Exception
    {
        public IdNotInRangeException(string msg): base(msg)
        {

        }
    }
}
