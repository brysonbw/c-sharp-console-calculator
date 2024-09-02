Console.WriteLine("Console Calculator App");

int num1 = GetValidNumber("Please enter the first number: ");
int num2 = GetValidNumber("Please enter the second number: ");

PrintCalculation(num1, num2);

int GetValidNumber(string prompt)
{
    int number = 0;
    bool isValid = false;

    while (!isValid)
    {
        Console.Write(prompt);
        string input = Console.ReadLine() ?? string.Empty;

        // Try parsing input to an integer
        if (int.TryParse(input, out number))
        {
            isValid = true;
        }
        else
        {
            Console.WriteLine($"Not a valid number [{input}]. Please try again.");
        }
    }

    return number;
}

void PrintCalculation(int num1, int num2) 
{
     bool isValidOption = false;
     while (!isValidOption)
    {
        Console.WriteLine("Select calculation: ");
        Console.WriteLine("[A]dd");
        Console.WriteLine("[S]ubtract");
        Console.WriteLine("[M]ultiply");

        string input = Console.ReadLine() ?? string.Empty;
        string selectedOption = input.ToLower();

        // Check selected option
        if (selectedOption == "a" || selectedOption == "s" || selectedOption == "m")
        {
            isValidOption = true;
            if(selectedOption == "a") {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            } else if (selectedOption == "s") {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            } else if(selectedOption == "m") {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }

        }
        else
        {
            Console.WriteLine($"Invalid option. Please enter A, S, or M (case insensitive)");
        }
    }
}