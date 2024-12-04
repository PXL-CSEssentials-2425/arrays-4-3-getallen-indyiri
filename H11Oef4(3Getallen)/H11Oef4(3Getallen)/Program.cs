bool isValid = false;

double[] numbers = new double[3];

double sum = 0.0;

do 
{
    Console.WriteLine("=== Som van 3 getallen bepalen ===");
    Console.WriteLine();
    Console.Write("Geef 1ste getal: ");
    string inputFirstNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 2de getal: ");
    string inputSecondNumber = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Geef 3de getal: ");
    string inputThirdNumber = Console.ReadLine();
    Console.WriteLine();

    bool isFirstNumberValid = double.TryParse(inputFirstNumber, out numbers[0]);
    bool isSecondNumberValid = double.TryParse(inputSecondNumber, out numbers[1]);
    bool isThirdNumberValid = double.TryParse(inputThirdNumber, out numbers[2]);

    if (!isFirstNumberValid || !isSecondNumberValid || !isThirdNumberValid || numbers[0] == 0.0 || numbers[1] == 0.0 || numbers[2] == 0.0)
    {
        Console.WriteLine("U moet getallen ingeven die niet gelijk zijn aan 0!");
        Console.ReadKey(true);
        Console.Clear();
    }
    else
    {
        foreach (double number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"De som is {sum}");
        isValid = true;
    }
}
while (isValid == false);
