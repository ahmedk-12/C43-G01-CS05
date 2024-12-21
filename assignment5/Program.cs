namespace Assignment5
{
    internal class Program
    {


        #region 1-	Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        //Passing by Value(Value Type) :

        //A copy of the variable's value is passed to the function.
        //Changes made inside the function do not affect the original value.

        //Passing by Reference(Reference Type) :

        //A reference to the memory address of the variable is passed to the function.
        //Changes made inside the function directly modify the original variable.
        //static void SwapByValue(int x, int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //    Console.WriteLine($"Inside SwapByValue: x = {x}, y = {y}");
        //}
        #endregion

        #region 2-	Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

        //Reference Type Passed by Value:

        //A copy of the reference(not the actual object) is passed to the function.
        //Changes to the object's properties affect the original object, but reassigning the reference inside the function does not affect the original reference.

        //Reference Type Passed by Reference:

        //The actual reference itself is passed to the function.
        //The function can modify the object's properties and reassign the reference to a new object, affecting the original reference.
        //static void SwapByRef(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #region 3-	Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //static void Calculate(int a, int b, int c, int d, out int sum, out int subtract)
        //{
        //    sum = a + b;
        //    subtract = c - d;
        //}
        #endregion

        #region 4-	Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
        //static int SumDigits(int number)
        //{
        //    int sum = 0;
        //    while (number > 0)
        //    {
        //        sum += number % 10;
        //        number /= 10;
        //    }
        //    return sum;
        //}
        #endregion

        #region 5-	Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        //static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;

        //    for (int i = 2; i < number; i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
        #endregion

        #region 6-	Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //static void MinMaxArray(int[] arr, out int min, out int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    foreach (int num in arr)
        //    {
        //        if (num < min) min = num;
        //        if (num > max) max = num;
        //    }
        //}
        #endregion

        #region 7-	Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        //static int Factorial(int number)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= number; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}
        #endregion

        #region 8-Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        //static string ChangeChar(string input, int position, char newChar)
        //{
        //    char[] chars = input.ToCharArray();
        //    chars[position] = newChar;
        //    return new string(chars);
        //}
        #endregion
        static void Main()
        {
            // Example 1: Value Type
            //int a = 5, b = 10;
            //SwapByValue(a, b);
            //Console.WriteLine($"After SwapByValue: a = {a}, b = {b}");

            // Example 2: Reference Type
            //SwapByRef(ref a, ref b);
            //Console.WriteLine($"After SwapByRef: a = {a}, b = {b}");

            // Example 3: Summation and Subtraction
            //Calculate(5, 10, 20, 15, out int sum, out int subtract);
            //Console.WriteLine($"Sum = {sum}, Subtract = {subtract}");

            // Example 4: Sum of Digits
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum of digits: {SumDigits(number)}");

            // Example 5: Prime Check
            //Console.Write("Enter a number to check if it's prime: ");
            //int primeCheck = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Is Prime: {IsPrime(primeCheck)}");

            // Example 6: Min and Max in Array
            //int[] arr = { 5, 3, 9, 1, 4 };
            //MinMaxArray(arr, out int min, out int max);
            //Console.WriteLine($"Min = {min}, Max = {max}");

            // Example 7: Factorial
            //Console.Write("Enter a number to calculate factorial: ");
            //int factNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Factorial: {Factorial(factNumber)}");

            // Example 8: Change Character
            //string text = "hello";
            //string updatedText = ChangeChar(text, 1, 'a');
            //Console.WriteLine($"Updated Text: {updatedText}");
        }
    }
}
