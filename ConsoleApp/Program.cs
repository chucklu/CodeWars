using System;

namespace ConsoleApp
{
    class Program
    {
        private static void Main()
        {
            try
            {
                int result = Kata.CloseCompare(3, 5, 3);
                Console.WriteLine(result);
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
