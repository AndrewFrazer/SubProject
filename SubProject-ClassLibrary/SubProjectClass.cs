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
        public static int AddFromStrings(string a, string b) => SharedClass.Add(int.Parse(a), int.Parse(b));
    }
}
