using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // Using a do-while loop to loop through the elements on the list
        int userNumber;
        do
        {
            Console.Write("Enter a number(0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        // Make sure there is a least one number
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        // To get the expected value
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
                max = number;
        }

        Console.WriteLine($"The max is: {max}");
        return;

    }
    
    

}
