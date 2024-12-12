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
                  #region variable
  //5
  int number = 5;
  #endregion

  #region  cts-cls
  int x = 5; //4 byte
  string name = "test"; //8 byte 
  name = "ali";

  #endregion

  #region value type
  int x; //4 byte
  //Console.WriteLine(x);
  x = 4;
  int y = 9;
  y = x;
  x++;
  Console.WriteLine(y);
  Console.WriteLine(x);
  #endregion

  #region reference type
  point p01;
  p01 = new point();

  point p02 = new point();
  p02 = p01;
  p01.x = 10;
  Console.WriteLine(p02.x);
  #endregion

  #region object
  //point p01 = new point();
  //p01.
  object obj01 = new object();
  //obj = 1;
  //obj = "hello";
  //obj = 'a';
  //obj = true;
  object obj02 = new object();
  Console.WriteLine(obj01.GetHashCode());
  Console.WriteLine(obj02.GetHashCode());

  obj01 = obj02;
  Console.WriteLine("***************");
  Console.WriteLine(obj01.GetHashCode());
  Console.WriteLine(obj02.GetHashCode());
  #endregion

  #region fractions and discard
  //int num01 = 1233444444444;
  long num02 = 1233444444444;

  double num03 = 22.2;
  float num04 = 22.2f;
  decimal num05 = 22.2m;

  int num06 = 1_000_000;
  Console.WriteLine(num06);
  #endregion

            #endregion


 
        }
    }
}
