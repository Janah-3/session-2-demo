using System;

namespace session_2_demo
{
    internal class Program
    {

        static int sum(int x,int y) {
            return x - y;
        }
          
        static void Main(string[] args)
        {
 

            #region Error types
            #region syntax - copolation error
            console.WriteLine('hello');
            iint x;
            #endregion


            #region runtime error
            int x = 5;
            int y = 0;
            Console.WriteLine(x/y);
            #endregion

            #region logical Error
            int a = 10;
            int b = 5;
            Console.WriteLine(sum(a,b));
            #endregion

            #region warning
            int x=5; //4byte
            Console.WriteLine(x);


            #endregion
            #endregion


 
        }
    }
}
