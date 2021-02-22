using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedSource_ClassLibrary;

namespace SubProject_ClassLibrary
{
    public static class SubProjectClass
    {
        public static int Sum(List<int> numbers)
        {
            int result = 0;

            foreach(var n in numbers)
            {
                result = SharedClass.Add(result, n);
            }

            return result;
        }
    }
}
