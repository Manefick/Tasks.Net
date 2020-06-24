using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;

namespace Task5_Interfase
{
    class UseLibraryTest:Car
    {
        private int RunCar { get; } = 0;
        public UseLibraryTest(string b, string m, int y, bool n, int rc) : base(b, m, y,n)
        {
            if (CarStateNew==false)
                RunCar = rc;
        }
    }
}
