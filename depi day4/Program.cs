namespace depi_day4
{
    internal class Program
    {
        // Enum
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            
        
                
                // Problem 1: Array Initialization & IndexOutOfRangeException
                

                Console.WriteLine(" Problem 1");

                // 1. Using new int[size]
                int[] arr1 = new int[5];

                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = i + 1;
                }

                Console.WriteLine("Array 1:");
                for (int i = 0; i < arr1.Length; i++)
                {
                    Console.WriteLine(arr1[i]);
                }

                // 2. Using initializer list
                int[] arr2 = new int[] { 10, 20, 30, 40, 50 };

                Console.WriteLine("\nArray 2:");
                foreach (int value in arr2)
                {
                    Console.WriteLine(value);
                }

                // 3. Array syntax sugar
                int[] arr3 = { 100, 200, 300, 400, 500 };

                Console.WriteLine("\nArray 3:");
                foreach (int value in arr3)
                {
                    Console.WriteLine(value);
                }

                // IndexOutOfRangeException
                try
                {
                    Console.WriteLine(arr1[10]);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("IndexOutOfRangeException occurred!");
                }


                
                // Problem 2: Shallow Copy & Deep Copy
                
                Console.WriteLine("\n Problem 2 ");

                int[] originalArray = { 1, 2, 3, 4, 5 };

                // Shallow Copy
                int[] shallowCopy = originalArray;

                shallowCopy[0] = 100;

                Console.WriteLine("After modifying shallow copy:");
                Console.WriteLine("Original Array: " + originalArray[0]);
                Console.WriteLine("Shallow Copy: " + shallowCopy[0]);

                // Deep Copy using Clone
                int[] secondArray = { 10, 20, 30, 40, 50 };

                int[] deepCopy = (int[])secondArray.Clone();

                deepCopy[0] = 999;

                Console.WriteLine("\nAfter modifying deep copy:");
                Console.WriteLine("Original Array: " + secondArray[0]);
                Console.WriteLine("Deep Copy: " + deepCopy[0]);



                 // Problem 3: 2D Array - Student Grades

                 Console.WriteLine( "\n Problem 3 ");

                   int[,] grades = new int[3, 3];

                for (int student = 0; student < 3; student++)
                {
                    Console.WriteLine($"\nEnter grades for Student {student + 1}:");

                    for (int subject = 0; subject < 3; subject++)
                    {
                        Console.Write($"Subject {subject + 1}: ");
                        grades[student, subject] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nStudent Grades:");

                for (int student = 0; student < 3; student++)
                {
                    Console.Write($"Student {student + 1}: ");

                    for (int subject = 0; subject < 3; subject++)
                    {
                        Console.Write(grades[student, subject] + "\t");
                    }

                    Console.WriteLine();
                }


               
                // Problem 4: Array Methods
                // Sort, Reverse, IndexOf, Copy, Clear
                
                Console.WriteLine("\n Problem 4 ");

                int[] numbers = { 5, 2, 8, 1, 3 };

                Console.WriteLine("Original Array:");
                PrintArray(numbers);

                // Sort
                Array.Sort(numbers);

                Console.WriteLine("After Sort:");
                PrintArray(numbers);

                // Reverse
                Array.Reverse(numbers);

                Console.WriteLine("After Reverse:");
                PrintArray(numbers);

                // IndexOf
                int index = Array.IndexOf(numbers, 8);

                Console.WriteLine("Index of 8: " + index);

                // Copy
                int[] copiedArray = new int[numbers.Length];

                Array.Copy(numbers, copiedArray, numbers.Length);

                Console.WriteLine("Copied Array:");
                PrintArray(copiedArray);

                // Clear
                Array.Clear(numbers, 0, numbers.Length);

                Console.WriteLine("After Clear:");
                PrintArray(numbers);


                // Problem 5: For, Foreach & While
               

                Console.WriteLine("\n Problem 5");

                int[] values = { 1, 2, 3, 4, 5 };

                // For loop
                Console.WriteLine("Using for loop:");

                for (int i = 0; i < values.Length; i++)
                {
                    Console.WriteLine(values[i]);
                }

                // Foreach loop
                Console.WriteLine("\nUsing foreach loop:");

                foreach (int value in values)
                {
                    Console.WriteLine(value);
                }

                // While loop - Reverse
                Console.WriteLine("\nUsing while loop in reverse:");

                int position = values.Length - 1;

                while (position >= 0)
                {
                    Console.WriteLine(values[position]);
                    position--;
                }

                  
                    // Problem 6: Positive Odd Number Validation
                     
                   Console.WriteLine("\n Problem 6 ");

                int number;

                do
                {
                    Console.Write("Enter a positive odd number: ");

                    if (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("Invalid input. Please enter an integer.");
                        continue;
                    }

                    if (number <= 0 || number % 2 == 0)
                    {
                        Console.WriteLine("Please enter a positive odd number.");
                    }

                } while (number <= 0 || number % 2 == 0);

                Console.WriteLine("Valid number: " + number);


                
                // Problem 7: 2D Array Matrix
               

                Console.WriteLine("\n Problem 7");

                int[,] matrix =
                {
                 { 1, 2, 3 },
                 { 4, 5, 6 },
                 { 7, 8, 9 }
                      };

                Console.WriteLine("Matrix:");

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }

                    Console.WriteLine();
                }


                
                // Problem 8: Month Using If-Else & Switch
                
                Console.WriteLine("\n Problem 8 ");

                Console.Write("Enter month number (1-12): ");
                int month = int.Parse(Console.ReadLine());

                // Using if-else
                Console.WriteLine("\nUsing if-else:");

                if (month == 1)
                    Console.WriteLine("January");
                else if (month == 2)
                    Console.WriteLine("February");
                else if (month == 3)
                    Console.WriteLine("March");
                else if (month == 4)
                    Console.WriteLine("April");
                else if (month == 5)
                    Console.WriteLine("May");
                else if (month == 6)
                    Console.WriteLine("June");
                else if (month == 7)
                    Console.WriteLine("July");
                else if (month == 8)
                    Console.WriteLine("August");
                else if (month == 9)
                    Console.WriteLine("September");
                else if (month == 10)
                    Console.WriteLine("October");
                else if (month == 11)
                    Console.WriteLine("November");
                else if (month == 12)
                    Console.WriteLine("December");
                else
                    Console.WriteLine("Invalid month.");

                // Using switch
                Console.WriteLine("\nUsing switch:");

                switch (month)
                {
                    case 1:
                        Console.WriteLine("January");
                        break;

                    case 2:
                        Console.WriteLine("February");
                        break;

                    case 3:
                        Console.WriteLine("March");
                        break;

                    case 4:
                        Console.WriteLine("April");
                        break;

                    case 5:
                        Console.WriteLine("May");
                        break;

                    case 6:
                        Console.WriteLine("June");
                        break;

                    case 7:
                        Console.WriteLine("July");
                        break;

                    case 8:
                        Console.WriteLine("August");
                        break;

                    case 9:
                        Console.WriteLine("September");
                        break;

                    case 10:
                        Console.WriteLine("October");
                        break;

                    case 11:
                        Console.WriteLine("November");
                        break;

                    case 12:
                        Console.WriteLine("December");
                        break;

                    default:
                        Console.WriteLine("Invalid month.");
                        break;
                }

               
                 // Problem 9: Sort, IndexOf & LastIndexOf

                 Console.WriteLine("\n Problem 9 ");

                int[] searchArray = { 5, 2, 8, 3, 8, 1, 8 };

                Console.WriteLine("Before sorting:");
                PrintArray(searchArray);

                Array.Sort(searchArray);

                Console.WriteLine("After sorting:");
                PrintArray(searchArray);

                int searchValue = 8;

                int firstIndex = Array.IndexOf(searchArray, searchValue);

                int lastIndex = Array.LastIndexOf(searchArray, searchValue);

                Console.WriteLine("First index of 8: " + firstIndex);
                Console.WriteLine("Last index of 8: " + lastIndex);


                
                // Problem 10: Sum Using For & Foreach
                

                Console.WriteLine("\n Problem 10 ");

                int[] sumArray = { 10, 20, 30, 40, 50 };

                // Using for
                int sumFor = 0;

                for (int i = 0; i < sumArray.Length; i++)
                {
                    sumFor += sumArray[i];
                }

                Console.WriteLine("Sum using for: " + sumFor);

                // Using foreach
                int sumForeach = 0;

                foreach (int value in sumArray)
                {
                    sumForeach += value;
                }

                Console.WriteLine("Sum using foreach: " + sumForeach);


                
                // Problem 11: Enum DayOfWeek
                
                Console.WriteLine("\n Problem 11 ");

                Console.Write("Enter a number from 1 to 7: ");

                int dayNumber;

                if (int.TryParse(Console.ReadLine(), out dayNumber))
                {
                    if (dayNumber >= 1 && dayNumber <= 7)
                    {
                        DayOfWeek day = (DayOfWeek)Enum.Parse(
                        typeof(DayOfWeek),
                        dayNumber.ToString()
                        );

                        Console.WriteLine("Day: " + day);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number from 1 to 7");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }


           
            // Helper Method
            
            static void PrintArray(int[] array)
            {
                foreach (int value in array)
                {
                    Console.Write(value + " ");
                }

                Console.WriteLine();
            }
        }
    }
    

