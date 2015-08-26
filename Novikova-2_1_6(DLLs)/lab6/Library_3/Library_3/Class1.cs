using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_1;
using Library_2;
namespace Library_3
{
    public class KI3_Class_3 : KI3_Class_1
    {
        public int F3(int x, int y)
        {
            return 5 * this.F1(x, y) - 2 * KI3_Class_2.F2(x, y);
        }
    }
}
