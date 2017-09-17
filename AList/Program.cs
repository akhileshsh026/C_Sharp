using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    class Sample
    {
       public int a;
       public char b;
        List<int> o = new List<int>() {1,2,3,4,3,54,6,56,5,6,56,75,67,56,7,65,7,657 };
    }

    public class MyGen<T>
     {
        private T[] ary;
        public MyGen(int size)
            {
            ary = new T[size+1];
            }
        public T getItem(int index)
            {
            return ary[index];
            }
        public void setItem(int index , T value)
            {
               ary[index]= value;
            }
     }


    class Program
    {
        static void Main(string[] args)
        {
            //HashTable();
           // GenricCollections();
           Using_MyGen_Class();
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
            Hashtable obj = new Hashtable() { { 1, "akhill" }, { 2, "Kumar" }, { 3, "Sahu" } };
            foreach (var item in obj.Keys)
            {      
                Console.WriteLine("{0} = {1}",item,obj[item]);
            }
            Console.ReadLine();
        }

        public  static void GenricCollections()
        {
            Stack<Sample> obj = new Stack<Sample>();
            obj.Push(new Sample() { a=1 , b='2' });
            Console.WriteLine(obj.GetType());
            Console.ReadLine();
        }

        public static void Using_MyGen_Class()
        {
           // MyGen<int> obj = new MyGen<int>(5);
           // obj.setItem(0,1);
           // obj.setItem(1,2);
           // obj.setItem(2,3);
           // obj.setItem(3,4);
           // obj.setItem(4,5);

            MyGen<char> obj = new MyGen<char>(5);
            obj.setItem(0,'A');
            obj.setItem(1,'b');

            for (int i = 0; i < 2; i++)
			{
                Console.WriteLine(obj.getItem(i));
			}
            Console.ReadLine();
        }
    }
}
 