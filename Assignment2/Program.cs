namespace Assignment2
{
    public class Reference
    {
       public  int x=10 ;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1-	Write a program that allows the user to enter a number then print it.
            //int EnteredValue;
            //Console.Write("Enter a number :  ");
            //EnteredValue = int.Parse(Console.ReadLine()); 
            //Console.WriteLine(EnteredValue);

            #endregion
            #region 2- Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            // int x = 10; //Define 1st variable
            // int y = 5; //Define 2nd variable
            //  y = x; //assign x to y
            //  x = 87; // modify x
            // Console.WriteLine("x = "+ x + "y = "+y);
            // when we print we found y still with assigned value
            // because it's value type and didn't feel the Modification on the othe value

            #endregion

            #region 3-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Reference R1 = new Reference(); // Define 1st Variable
            //Reference R2 = R1;                       // Define 2nd Variable and assign variable 1 to variable 2

            //Console.WriteLine("values before modifications");  // Print before modifications
            //Console.WriteLine("Variable 1: " + R1.x); 
            //Console.WriteLine("Variable 2: " + R2.x);

          
            //R1.x = 524;                // Modify 1st Variable

            //Console.WriteLine("values before modifications"); // Print after modifications
            //Console.WriteLine("Variable 1: " + R1.x);
            //Console.WriteLine("Variable 2: " + R2.x);

            //Modifications will reflect on the both Variables because both refer to the same address as a reference type

            #endregion
        }
    }
}
