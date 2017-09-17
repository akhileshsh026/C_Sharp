using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static void ArrList_Show()
        {
            ArrayList al = new ArrayList();
            al.Add("Akhileesh");
            Console.WriteLine(al.Capacity);

            ArrayList obj = new ArrayList() { 1, "Kumar", 324, "Akhilesh", 546, 54, 65, 67, 6576, 86786 };
            char[] charobj = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'j' };
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            al.AddRange(obj);
            al.AddRange(charobj);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }
            Console.ReadLine();
        }

        public static void HashTable()
        {

        }
    }
}
