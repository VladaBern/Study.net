using System;
using System.Runtime.Remoting.Messaging;

namespace HomeTask1
{
    internal class Program
    {
        static int Factorial(int count)
        {
            int result = 1;

            for (int i = 1; i <= count; i++)
            {
                result *= i;
            }
            return result;
        }

        static void CallBack(IAsyncResult asyncResult)
        {
            AsyncResult ar = asyncResult as AsyncResult;
            Func<int, int> caller = (Func<int, int>)ar.AsyncDelegate;
            int result = caller.EndInvoke(asyncResult);
            Console.WriteLine(String.Format(asyncResult.AsyncState.ToString(), result));
        }

        static void Main(string[] args)
        {
            var func = new Func<int, int>(Factorial);
            func.BeginInvoke(5, CallBack, "a! = {0}");

            Console.ReadKey();
        }
    }
}
