using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate T mynum<T>(T n);
namespace AList
{
    class Genric_Delegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MulNum(int p)
        {
            num *= 10;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        
  

    }
}
