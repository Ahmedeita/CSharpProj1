using System.ComponentModel;

namespace Project2
{
    internal class Program
    {
        static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            #region Error Types
            #region Syntax Error (Compilation Error)
            //console.WriteLine("Hello");
            //IInt x;
            #endregion
            #region RunTime Error
            //int x = 5;
            //int y = 0;
            //Console.WriteLine(x / y);

            #endregion
            #region Logical Error
            //int A = 10;
            //int B = 5;
            //Sum(A , B);
            #endregion
            #region Warning
            //  int X; // 4 Byte

            #endregion

            #endregion

            #region Variable
            //5
            // int Number = 5 ;

            #endregion

            #region CTS - CLS
            //int x = 5; // 4 Bytes
            //string Name = "test"; // 8 Bytes 
            //Name = "Ali"; // 6 Bytes
            #endregion

            #region Value Type
            //int x; //4 Byte
            //Console.WriteLine(X);
            //X=4;
            //int Y = 9; //4Byte
            //Y = X;//4 BYTE
            //X++;
            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            #endregion

            #region Reference Type
            //Point P01;
            //P01 = new Point();  
            // Point P02 = new Point();
            //P02 = P01;

            //P01.x = 10;
            //Console.WriteLine(P02.x);

            #endregion

            #region Object
            //Point P01 = new Point();
            //P01.
            //object obj01 = new object();
            //obj = 1;
            //obj = "Hello";
            //obj = 'A';
            //obj = true;
            //object obj02 = new object();
            //Console.WriteLine(obj01.GetHashCode());
            //Console.WriteLine(obj02.GetHashCode());
            //obj02= obj01
            //Console.WriteLine("*********************");
            //Console.WriteLine(obj01.GetHashCode());
            //Console.WriteLine(obj02.GetHashCode());

            #endregion
        }
    }
}
