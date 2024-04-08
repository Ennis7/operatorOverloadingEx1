namespace OperatorOverloadingEx1
{
    public class Calculator
    {
        public int number { get; set; }

        // Overload unary operators ++ and --
        public static Calculator operator ++(Calculator calc)
        {
            calc.number++;
            return calc;
        }
        public static Calculator operator --(Calculator calc)
        {
            calc.number--;
            return calc;
        }
        // Overload Comparison Operators > and <
        public static bool operator >(Calculator calc1, Calculator calc2)
        {
            bool larger = false;
            if (calc1.number > calc2.number)
                larger = true;
            return larger;
        }
        public static bool operator <(Calculator calc1, Calculator calc2)
        {
            bool larger = false;
            if (calc1.number < calc2.number)
                larger = true;
            return larger;
        }
        // Overload Binary Operators + and -
        public static Calculator operator +(Calculator calc, int value)
        {
            calc.number += value;
            return calc;
        }
        public static Calculator operator -(Calculator calc, int value)
        {
            calc.number -= value;
            return calc;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            // create object array

            Calculator[] numbers = new Calculator[10];
            // place random numbers into array and print values
            Console.Write("Original Numbers= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = new Calculator(); // creates the object
                numbers[i].number = r.Next(1, 100);  // places a value in the object
                Console.Write(" " + numbers[i].number);
            }

            Console.WriteLine();
            // if divisible by 2, add 1 to value using operator ++ method
            // otherwise subtract 1 from value using operator -- method

            Console.Write("New Numbers +1 or -1= ");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].number % 2 == 0)
                {
                    // Code goes here to increment numbers[i] by 1
                    ++numbers[i];
                }
                else
                {
                    // Code goes here to decrement numbers[i] by 1
                    --numbers[i];
                }
                Console.Write(" " + numbers[i].number);
            }
            Console.WriteLine();

            // random Calculator object to add
            Calculator numToAdd = new Calculator();
            numToAdd.number = r.Next(1, 20);
            // Using operator +, add numToAdd.number to each element in the array
            // Print the results
            Console.Write($"Numbers + {numToAdd.number} = ");

            // Insert a for loop that adds numToAdd to numbers[i]
            for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i] + numToAdd.number;
                    Console.Write(" " + numbers[i].number);
                }

            Console.WriteLine();

            // random Calculator object to subtract
            Calculator numToSub = new Calculator();
            numToSub.number = r.Next(1, 20);
            // Using operator -, subtract numToSub.number from each element in the array
            // Print the results
            Console.Write($"Numbers - {numToSub.number}= ");
            // Insert a for loop that subtracts numToSub from numbers[i]
            for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = numbers[i] - numToSub.number;
                    Console.Write(" " + numbers[i].number);
                }

            Console.WriteLine();

            // random Calculator object for comparison
            Calculator numToCompare = new Calculator();
            numToCompare.number = r.Next(1, 100);
            // Using operator > and operator <, compare each element to numToCompare.number
            // print if the element is higher, lower or equal to the number you are comparing to
            Console.WriteLine($"Numbers above or below {numToCompare.number}");
            // Insert a for loop
            for (int i = 0; i < numbers.Length; i++)
                {
                    // Inside the for loop insert a nested if/else that checks numbers[i] > numberToCompare
                    if (numbers[i] > numToCompare)
                    {
                        // followed by a message that the number is higher
                        Console.WriteLine($"{numbers[i].number} is higher.");
                    }
                    // Then it should check numbers[i] < numToCompare 
                    else if (numbers[i] < numToCompare)
                    {
                        // followed by a message that the number is lower
                        Console.WriteLine($"{numbers[i].number} is lower.");
                    }
                    else
                    {
                        // if the number isn't higher or lower, the message should indicate they are equal
                        Console.WriteLine($"{numbers[i].number} is equal.");
                    }
                }
            Console.ReadLine();
        }
    }
}


