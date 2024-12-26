
namespace C43_G03_CS04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static int GetValidInteger(string prompt) // been Used in problem 11 or if needed .
            {
                int number;
                while (true)
                {
                    Console.Write(prompt);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        return number;
                    }
                    Console.WriteLine("Please enter a valid integer.");
                }
            }
            #region merge two arrays of the same size sorted in ascending order.
            //int n;
            //Console.WriteLine("Enter the size of the arrays:");

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the arrays:");
            //}

            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];

            //Console.WriteLine($"Enter {n} elements for the first array:");
            //int i = 0;
            //while (i < n)
            //{
            //    if (int.TryParse(Console.ReadLine(), out arr1[i]))
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }
            //}

            //Console.WriteLine($"Enter {n} elements for the second array:");
            //i = 0;
            //while (i < n)
            //{
            //    if (int.TryParse(Console.ReadLine(), out arr2[i]))
            //    {
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }
            //}

            //Array.Sort(arr1);
            //Array.Sort(arr2);

            //int[] arr3 = new int[2 * n];
            //int idx1 = 0, idx2 = 0, idx3 = 0;

            //while (idx1 < n && idx2 < n)
            //{
            //    if (arr1[idx1] < arr2[idx2])
            //    {
            //        arr3[idx3++] = arr1[idx1++];
            //    }
            //    else
            //    {
            //        arr3[idx3++] = arr2[idx2++];
            //    }
            //}

            //while (idx1 < n)
            //{
            //    arr3[idx3++] = arr1[idx1++];
            //}

            //while (idx2 < n)
            //{
            //    arr3[idx3++] = arr2[idx2++];
            //}

            //Console.WriteLine("The merged and sorted array is:");
            //foreach (var item in arr3)
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region count the frequency of each element of an array.
            //int n;
            //Console.WriteLine("Please enter a valid integer for the size of the array:");
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer for the size of the array:");
            //}

            //int[] arr = new int[n];

            //Dictionary<int, int> freq = new Dictionary<int, int>();

            //// I used Dictionary cuz the out of bounded error that will occure if we input in the array integers > n || integers < 0.  

            //int i = 0;
            //Console.WriteLine($"Enter {n} elements for the array:");
            //while (i < n)
            //{
            //    if (int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        if (freq.ContainsKey(arr[i]))
            //        {
            //            freq[arr[i]]++;
            //        }
            //        else
            //        {
            //            freq[arr[i]] = 1;
            //        }
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer:");
            //    }
            //}

            //Console.WriteLine("Element frequencies:");
            //foreach (var pair in freq)
            //{
            //    Console.WriteLine($"Element {pair.Key} appears {pair.Value} times");
            //}

            #endregion

            #region find maximum and minimum element in an array

            //int n;
            //Console.WriteLine("enter a valid positive integer:");
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer:");
            //}

            //int[] arr = new int[n];
            //int i = 0;
            //Console.WriteLine($"Enter {n} elemnts for the array:");
            //while (i < n)
            //{
            //    if (int.TryParse(Console.ReadLine(), out arr[i]))
            //        i++;

            //    else
            //        Console.WriteLine("Please enter a valid integer.");
            //}

            //for (int j = 0; j < arr.Length - 1; j++)
            //{
            //    for (int k = 0; k < arr.Length - 1 - j; k++)
            //    {
            //        if (arr[k] > arr[k + 1])
            //        {
            //            int temp = arr[k];
            //            arr[k] = arr[k + 1];
            //            arr[k + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine($"Maximum element is: {arr[n - 1]}");
            //Console.WriteLine($"Minimum element is: {arr[0]}");

            #endregion.

            #region find the second largest element in an array.

            //int n;
            //Console.WriteLine("Please enter a valid positive integer:");
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer:");
            //}

            //int[] arr = new int[n];
            //int i = 0;

            //Console.Write($"Enter {n} integers for the array : ");
            //while (i < n)
            //{
            //    if (int.TryParse(Console.ReadLine(), out arr[i]))
            //        i++;

            //    else
            //        Console.WriteLine("Please enter a valid integer.");
            //}

            //for (int j = 0; j < arr.Length - 1; j++)
            //{
            //    for (int k = 0; k < arr.Length - 1 - j; k++)
            //    {
            //        if (arr[k] > arr[k + 1])
            //        {
            //            int temp = arr[k];
            //            arr[k] = arr[k + 1];
            //            arr[k + 1] = temp;
            //        }
            //    }
            //}


            //Console.WriteLine($"The Secnd Maximum element is: {arr[n - 2]}");

            #endregion

            #region Distance between fitst and last equals

            //Console.WriteLine("Enter the size of the array:");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Please enter a valid positive integer for the array size:");
            //}

            //Console.WriteLine($"Enter {n} integers for the array:");
            //int[] arr = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.WriteLine("Please enter a valid integer:");
            //    }
            //}

            //int maxDistance = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i;
            //            if (distance > maxDistance)
            //            {
            //                maxDistance = distance;
            //            }
            //        }
            //    }
            //}

            //Console.WriteLine($"The longest distance between two equal cells is: {maxDistance}");
            #endregion

            #region reverse the order of the words.

            //Console.WriteLine("Enter words separated by spaces : ");
            //string input = Console.ReadLine();

            //string[] arr = input.Split(' ', StringSplitOptions.RemoveEmptyEntries); // 3amalt keda to input the words as one line .

            //Console.WriteLine("The reversed words be like : ");
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //Console.WriteLine();
            #endregion

            #region copy all the elements of first array on second array and print second array.
            //int n;
            //Console.WriteLine("Enter the size of the multidimensional arrays:");

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the arrays:");
            //}

            //int[,] arr1 = new int[n, n];
            //int[,] arr2 = new int[n, n];

            //Console.WriteLine($"Enter {n}x{n} elements for the first array:");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        while (!int.TryParse(Console.ReadLine(), out arr1[i, j]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer:");
            //        }
            //    }
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr2[i, j] = arr1[i, j];
            //    }
            //}

            //Console.WriteLine("The copied array is:");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion

            #region Print One Dimensional Array in Reverse Order
            //int n;
            //Console.WriteLine("Enter the size of the multidimensional array:");

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the size of the arrays:");
            //}

            //int[,] arr1 = new int[n, n];

            //Console.WriteLine($"Enter {n}x{n} elements for the first array:");

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        while (!int.TryParse(Console.ReadLine(), out arr1[i, j]))
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid integer:");
            //        }
            //    }
            //}

            //Console.WriteLine("The Reversed Array is:");
            //for (int i = n - 1; i >= 0; i--) 
            //{
            //    for (int j = n - 1; j >= 0; j--) 
            //    {
            //        Console.Write(arr1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region difference between passing value taype and refrence type
            // Passing by Value: A copy of the variable is passed to the method. Changes inside the method do not affect the original variable.
            // Passing by Reference: A reference to the variable is passed to the method. Changes inside the method affect the original variable.
            #endregion

            #region Exsample for the diffrence

            //    int n1;
            //    int n2;

            //    Console.WriteLine($"Enter 2 numbers : ");
            //    while(!int.TryParse( Console.ReadLine(), out n1 ))
            //{
            //    Console.WriteLine("Enter Avalid integer : ");
            //}

            //while (!int.TryParse(Console.ReadLine(), out n2))
            //{
            //    Console.WriteLine("Enter Avalid integer : ");
            //}

            //    incrementByValue(n1);
            //    Console.WriteLine($"After incremnting the number by 1 with function of value type : number1 = {n1}");

            //    incrementByRefrence(ref n2);
            //    Console.WriteLine($"After incremnting the number by 1 with function of Refrence type : number2 = {n2}"); 


            //static void incrementByValue(int num)
            //{
            //    num++; 
            //}

            //static void incrementByRefrence(ref int num)
            //{
            //    num++; 
            //}


            #endregion

            #region # Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //    int n1, n2, n3, n4;
            //    Console.WriteLine("Enter 4 numbers:");

            //    n1 = GetValidInteger("Enter the first number: ");
            //    n2 = GetValidInteger("Enter the second number: ");
            //    n3 = GetValidInteger("Enter the third number: ");
            //    n4 = GetValidInteger("Enter the fourth number: ");

            //    (int sum, int difference) = SUM(n1, n2, n3, n4); // tuple = returned tuple.

            //    Console.WriteLine($"The summation of the first two numbers is: {sum}");
            //    Console.WriteLine($"The subtraction of the least two numbers is: {difference}");


            //static (int, int) SUM(int num1, int num2, int num3, int num4)
            //{
            //    int add = num1 + num2;
            //    int sub = num3 - num4;

            //    return (add, sub); // like a tuple.
            //}
            #endregion

            #region a function to calculate the sum of the individual digits of a given number
            //    int n;

            //    Console.WriteLine("Enter A valid postive integer : ");
            //    while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            //    {
            //        Console.WriteLine("Enter A valid postive integer : ");
            //    }

            //Console.WriteLine($"The summation of the digits of the numbers is: {SumOfDigits(n)}");

            //static int SumOfDigits(int num)
            //{
            //        int sum = 0;
            //        while (num > 0)
            //        {
            //            sum += num % 10;
            //            num /= 10;
            //        }
            //        return sum;
            //}
            #endregion

            #region IsPrime
            //    int n;
            //    Console.WriteLine("Enter a valid positive integer: ");

            //    while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            //    {
            //        Console.WriteLine("Enter a valid positive integer: ");
            //    }

            //    if (IsPrime(n))
            //        Console.WriteLine($"{n} is Prime");
            //    else
            //        Console.WriteLine($"{n} is not Prime");


            //static bool IsPrime(int num)
            //{
            //    if (num <= 1) return false; 
            //    if (num <= 3) return true;  

            //    for (int i = 2; i * i <= num; i++)
            //    {
            //        if (num % i == 0) return false;
            //    }

            //    return true; 
            //}

            #endregion

            #region MinMaxArray

            //int[] numbers = { 5, 3, 100, 100, 4, 2, 2, 1 };
            //int min = int.MaxValue; 
            //int max = int.MinValue;

            //MinMaxArray(numbers, ref min, ref max);

            //Console.WriteLine($"Minimum value: {min}");
            //Console.WriteLine($"Maximum value: {max}");

            //static void MinMaxArray(int[] array, ref int min, ref int max)
            //{
            //    foreach (int num in array)
            //    {
            //        if (num < min)
            //            min = num;

            //        if (num > max)
            //            max = num;
            //    }
            //}

            #endregion

            #region Factorial (non-Recursive)

            //int n = GetValidInteger("Enter A valid Positive integer : ");

            //Console.WriteLine($"Factorila of {n} is : {Factorial(n)}");

            //static long Factorial(int n)
            //{
            //    long result = 1;

            //    for (int i = 1; i <= n; i++)
            //    {
            //        result *= i; 
            //    }

            //    return result;
            //}

            #endregion

            #region ChangeChar
            //Console.Write("Enter a string: ");
            //string s = Console.ReadLine();

            //Console.Write("Enter the position to change : ");
            //int pos;
            //while (!int.TryParse(Console.ReadLine(), out pos) || pos < 0 || pos >= s.Length)
            //{
            //    Console.WriteLine("Please enter a valid position within the string.");
            //}

            //Console.Write("Enter the new character: ");
            //char newChar = Console.ReadKey().KeyChar;

            //string newS = ChangeChar(s, pos, newChar);
            //Console.WriteLine($"Modified string: {newS}");


            //static string ChangeChar(string str, int position, char newChar)
            //{
            //    char[] result = new char[str.Length];

            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (i == position)
            //        {
            //            result[i] = newChar;
            //        }
            //        else
            //        {
            //            result[i] = str[i];
            //        }
            //    }

            //    string NewS = "";
            //    for (int i = 0; i < result.Length; i++)
            //    {
            //        NewS += result[i]; 
            //    }

            //    return NewS;
            //}
            #endregion
        }
    }
}
 

            
    



    



