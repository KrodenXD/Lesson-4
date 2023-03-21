using System;
using System.Text;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("abcde");
            sb.Append("123");
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("xd");
            sb.Append(sb1);
            Console.WriteLine(sb);

            //string s = "aabcaddaa";
            //int count = 0;

            //for(int i = 0; i < s.Length; i++)
            //{
            //    if(s[i] == 'a')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //Math();
            //Math(12, 34);
            //Math(11, 21, 45);
            //Math(10, 10.1);
            //Math("aa", "bb");
        }
        //public static void Math()
        //{
        //    int x = 10;
        //    int y = 45;
        //    Console.WriteLine(x+y);
        //}
        //public static void Math(int x,int y)
        //{
        //    Console.WriteLine(x+y);
        //}
        //public static void Math(int x,int y,int z)
        //{
        //    Console.WriteLine(x + y + z);
        //}
        //public static void Math(int x,double y)
        //{
        //    Console.WriteLine(x + y);
        //}
        //public static void Math(string a,string b)
        //{
        //    Console.WriteLine(a+b);
        //}

    }
}
