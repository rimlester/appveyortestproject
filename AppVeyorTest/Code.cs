using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVeyorTest
{
    public class Code
    {

        public IEnumerable<int> EmitOdd()
        {
            int i = 1;
            while (i < 10000)
            {
                yield return i += 2;
            }
        }
    }
}
