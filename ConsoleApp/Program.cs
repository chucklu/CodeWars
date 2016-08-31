using System;

namespace ConsoleApp
{
    class Program
    {
        private static void Main()
        {
            try
            {
                object a1 = 1;
                object b1 = 'a';
                object c1 = "hello";


                object a2 = 2;
                object b2 = 'b';
                object c2 = "world";


                object a3 = 3;
                object b3 = 'c';
                object c3 = "love";

                object[] array1 = {a1, b1, c1};
                object[] array2 = {a2, b2, c2, array1};
                object[] array3 = {a3, b3, c3, array2};
                string str = Kata.PrintArray(array3);
                Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    Console.WriteLine("错误信息:{0}{1}异常类型:{2}{1}程序集:{3}{1}方法:{4}{1}跟踪栈信息:{1}{5}{1}",
                        ex.Message, Environment.NewLine, ex.GetType(), ex.Source, ex.TargetSite, ex.StackTrace);
                    ex = ex.InnerException;
                }
            }
            Console.ReadLine();
        }
    }
}
