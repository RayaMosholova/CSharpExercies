using System;
using System.Collections.Generic;
using System.Linq;

namespace DataTypesAnd_VariablesAscent
{
    class Program
    {
        private static char input;

        static void Main(string[] args)
        {
            // Ex.1 Data Types and variables
            //sbyte number1 = -100;
            //byte number2 = 128;
            //short number3 = -3540;
            //ushort number4 = 64876;
            //uint number5 = 2147483648;
            //int number6 = -1141583228;
            //long number7 = -1223372036854775808;

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            //Console.WriteLine(number3);
            //Console.WriteLine(number4);
            //Console.WriteLine(number5);
            //Console.WriteLine(number6);
            //Console.WriteLine(number7);

            //Ex.2 Data Types and Variables
            //decimal number1 = 3.141592653589793238m;
            //double number2 = 1.60217657;
            //decimal number3 = 7.8184261974584555216535342341m;

            //Console.WriteLine(number1);
            //Console.WriteLine(number2);
            //Console.WriteLine(number3);

            //Ex.3 Data Types and Variables
            //string firstString = "Software University";
            //char firstChar = 'B';
            //char secondChar = 'y';
            //char thirdChar = 'e';
            //string secondString = "I love programming";

            //Console.WriteLine($"{firstString}\n{firstChar}\n{secondChar}\n{thirdChar}\n{secondString}");

            //Ex.4 Data Types and Variables
            //string number1 = Console.ReadLine();

            //Console.WriteLine(Convert.ToInt32(number1, 16));

            //Ex.5 Data Types and Variables
            //string input = Console.ReadLine();
            //try
            //{
            //    bool newBool = Convert.ToBoolean(input);

            //    if (newBool)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("You have inserted invaluid value.");
            //}

            ////Ex.6 Data Types and Variables

            //string firstString = "Hello";
            //string secondString = "World";
            //object greeting = firstString + " " + secondString;

            //Console.WriteLine(greeting);

            //string thirdString = (string)greeting;

            //Ex.7 Data Types and Variables
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Before:\na={a}\nb={b}");
            //int temp = a;
            //a = b;
            //b = temp;

            //Console.WriteLine($"After:\na={a}\nb={b}");

            ////Ex.8 Data Types and Variables
            //Console.Write("First name: ");
            //string firstName = Console.ReadLine();
            //Console.Write("Last name: ");
            //string lastName = Console.ReadLine();
            //Console.Write("Age: ");
            //byte age = byte.Parse(Console.ReadLine());
            //Console.Write("Gender (m or f): ");
            //char gender = char.Parse(Console.ReadLine());
            //Console.Write("Personal ID number: ");
            //long personalIdNumber = long.Parse(Console.ReadLine());
            //Console.Write("Unique employee number: ");
            //int uniqueEmployeeNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine($"First name: {firstName}");
            //Console.WriteLine($"Last name: {lastName}");
            //Console.WriteLine($"Age: {age}");
            //Console.WriteLine($"Gender: {gender}");
            //Console.WriteLine($"Personal ID: {personalIdNumber}");
            //Console.WriteLine($"Unique Employee number: {uniqueEmployeeNumber}");

            ////Ex.9 Data Types and Variables
            //char firstChar = char.Parse(Console.ReadLine());
            //char secondChar = char.Parse(Console.ReadLine());
            //char thirdChar = char.Parse(Console.ReadLine());

            //Console.WriteLine($"{thirdChar}{secondChar}{firstChar}");

            //Ex.10 Data Types and Variables
            //byte centuries = byte.Parse(Console.ReadLine());
            //short years = (short)(centuries * 100);
            //int days = (int)(years * 365.2422);
            //int hours = days * 24;
            //long minutes = hours * 60;
            //long seconds = minutes * 60;
            //long miliseconds = seconds * 1000;
            //long microseconds = miliseconds * 1000;
            //long nanoseconds = microseconds * 1000;

            //Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} miliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

            ////Ex.11 Data Types and Variables - the Outputs in the given examples were not precised up to 6 digits after the floating point
            //Console.Write("Distance in metres: ");
            //float distanceInMetres = float.Parse(Console.ReadLine());
            //Console.Write("Hours: ");
            //float timeTakenHours = float.Parse(Console.ReadLine());
            //Console.Write("Minutes: ");
            //float timeTakenMinutes = float.Parse(Console.ReadLine());
            //Console.Write("Seconds: ");
            //float timeTakenSeconds = float.Parse(Console.ReadLine());

            //float timeForWholeDistanceInSeconds = (timeTakenHours * 3600) + (timeTakenMinutes * 60) + timeTakenSeconds;
            //float speedInMetresPerSecond = distanceInMetres / timeForWholeDistanceInSeconds;

            //float distanceInKilometres = distanceInMetres / 1000;
            //float timeForWholeDistanceInHours = timeTakenHours + (timeTakenMinutes / 60) + (timeTakenSeconds / 3600);
            //float speedInKilometersPerHour = distanceInKilometres / timeForWholeDistanceInHours;

            //float distanceinMiles = distanceInMetres / 1609;
            //float speedInMilesPerHour = distanceinMiles / timeForWholeDistanceInHours;

            //Console.WriteLine(Math.Round(speedInMetresPerSecond, 6));
            //Console.WriteLine(Math.Round(speedInKilometersPerHour, 6));
            //Console.WriteLine(Math.Round(speedInMilesPerHour, 6));

            //Ex.12 Data Types and Variables
            //Console.Write("Width: ");
            //double width = double.Parse(Console.ReadLine());
            //Console.Write("Height: ");
            //double height = double.Parse(Console.ReadLine());

            //double rectanglePerimeter = 2 * (width + height);
            //double rectangleArea = width * height;
            //double rectangleDiagonal = Math.Sqrt((width * width) + (height * height));

            //Console.WriteLine($"{rectanglePerimeter}\n{rectangleArea}\n{rectangleDiagonal}");

            //Ex.13 Data Types and Variables
            //Console.Write("User input: ");
            //char input = char.Parse(Console.ReadLine());

            //if (input == 'a' || input == 'i' || input == 'e' || input == 'u' || input == 'o')
            //{
            //    Console.WriteLine("This is a vowel.");
            //}
            //else if (input >= '0' && input <= '9')
            //{
            //    Console.WriteLine("This is a digit.");
            //}
            //else
            //{
            //    Console.WriteLine("This is other character.");
            //}

            //Ex.13 Second solution
            //Console.Write("Please input symbol here: ");
            //string symbol = Console.ReadLine();

            //if (symbol.Length != 1)
            //{
            //    Console.WriteLine("Please insert exactly one character!");
            //}
            //else if (symbol == "a" || symbol == "i" || symbol == "e" || symbol == "u" || symbol == "o")
            //{
            //    Console.WriteLine("This is a vowel.");
            //}
            //else if (char.IsDigit(symbol[0]))
            //{
            //    Console.WriteLine("This is a digit.");
            //}
            //else
            //{
            //    Console.WriteLine("This is other character.");
            //}

            //Ex.14
            //Console.Write("Insert decimal number here: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine(Convert.ToString(number, 16).ToUpper());
            //Console.WriteLine(Convert.ToString(number, 2).ToUpper());

            //Ex.15
            //Console.Write("Input number here: ");
            //int maxNumber = int.Parse(Console.ReadLine());
            //for (int currentNumber = 2; currentNumber <= maxNumber; currentNumber++)
            //{
            //    bool isPrime = true;
            //    for (int divisor = 2; divisor <= Math.Sqrt(currentNumber); divisor++)
            //    {
            //        if (currentNumber % divisor == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    Console.WriteLine($"{currentNumber} -> {isPrime}");
            //}


            //Ex.1 from second file Data Types and Variables
            //Console.Write("Input number type: ");
            //string numberType = Console.ReadLine();

            //if (numberType == "int")
            //{
            //    Console.WriteLine(int.MaxValue);
            //    Console.WriteLine(int.MinValue);

            //}
            //else if (numberType == "uint")
            //{
            //    Console.WriteLine(uint.MaxValue);
            //    Console.WriteLine(uint.MinValue);
            //}
            //else if (numberType == "long")
            //{
            //    Console.WriteLine(long.MaxValue);
            //    Console.WriteLine(long.MinValue);
            //}
            //else if (numberType == "byte")
            //{
            //    Console.WriteLine(byte.MaxValue);
            //    Console.WriteLine(byte.MinValue);
            //}
            //else if (numberType =="sbyte")
            //{
            //    Console.WriteLine(sbyte.MaxValue);
            //    Console.WriteLine(sbyte.MinValue);
            //}
            //else
            //{
            //    Console.WriteLine("You have inserted invalid number type");
            //}

            //Ex.1 from second file Data Types and Variables - second solution
            //Console.Write("Input number type: ");
            //string numberType = Console.ReadLine();

            //switch (numberType)
            //{
            //    case "int":
            //        Console.WriteLine(int.MaxValue);
            //        Console.WriteLine(int.MinValue);
            //        break;
            //    case "uint":
            //        Console.WriteLine(uint.MaxValue);
            //        Console.WriteLine(uint.MinValue);
            //        break;
            //    case "long":
            //        Console.WriteLine(long.MaxValue);
            //        Console.WriteLine(long.MinValue);
            //        break;
            //    case "byte":
            //        Console.WriteLine(byte.MaxValue);
            //        Console.WriteLine(byte.MinValue);
            //        break;
            //    case "sbyte":
            //        Console.WriteLine(sbyte.MaxValue);
            //        Console.WriteLine(sbyte.MinValue);
            //        break;
            //    default:
            //        Console.WriteLine("You have inserted invalid number type");
            //        break;

            //}

            //Ex.2 from second file Data Types and Variables(we accept that we input numbers only)
            //string input = Console.ReadLine();

            //long number;
            //bool isLong = long.TryParse(input, out number);

            //if (isLong)
            //{
            //    Console.WriteLine("This is integer number");
            //}
            //else
            //{
            //    Console.WriteLine("This is floating-point number");
            //}

            //Ex.2 from second file Data Types and Variables - second solution (we accept that we input numbers only)
            //Console.Write("Input number here: ");
            //string input = Console.ReadLine();

            //if (input.Contains('.') || input.Contains(','))
            //{
            //    Console.WriteLine("This is floating point number");
            //}
            //else
            //{
            //    Console.WriteLine("This is integer number");
            //}

            ////Ex.3 from second file Data Types and Variables
            //Console.Write("Please input number of lines: ");
            //int lines = int.Parse(Console.ReadLine());

            //int pouredLitres = 0;

            //for (int i = 1; i <= lines; i++)
            //{
            //    Console.Write($"Please input litres for {i} row: ");
            //    int litresPerRow = int.Parse(Console.ReadLine());

            //    if (pouredLitres + litresPerRow > 255)
            //    {
            //        Console.WriteLine("Insufficient capacity!");
            //    }
            //    else
            //    {
            //        pouredLitres = pouredLitres + litresPerRow;
            //    }
            //}

            //Console.WriteLine(pouredLitres);

            ////Ex.4 from second file Data Types and Variables
            //Console.Write("Please insert initial imperial unit: ");
            //string initialImperialUnit = Console.ReadLine();
            //Console.Write("Please insert initial value: ");
            //string initialValueString = Console.ReadLine();
            //float initialValue = float.Parse(initialValueString);
            //float milesToKilometers = (float)(initialValue * 1.6);
            //float inchessToCentimeters = (float)Math.Round((initialValue * 2.54), 2);
            //float feetToCentimeters = (float)Math.Round((initialValue * 30), 2);
            //float yardsToMeters = (float)Math.Round((initialValue * 0.91), 2);
            //float gallonsToLiters = (float)Math.Round((initialValue * 3.8), 2);

            //switch (initialImperialUnit)
            //{
            //    case "miles":
            //        Console.WriteLine($"{initialValueString} {initialImperialUnit} = {milesToKilometers:0.00} kilometres");
            //        break;
            //    case "inches":
            //        Console.WriteLine($"{initialValueString} {initialImperialUnit} = {inchessToCentimeters:0.00} centimeters");
            //        break;
            //    case "feet":
            //        Console.WriteLine($"{initialValueString} {initialImperialUnit} = {feetToCentimeters:0.00} centimeters");
            //        break;
            //    case "yards":
            //        Console.WriteLine($"{initialValueString} {initialImperialUnit} = {yardsToMeters:0.00} meters");
            //        break;
            //    case "gallons":
            //        Console.WriteLine($"{initialValueString} {initialImperialUnit} = {gallonsToLiters:0.00} liters");
            //        break;
            //    default:
            //        Console.WriteLine("You have inserted not accepted or invalid imperial unit.");
            //        break;
            //}

            //Ex.5 from second file Data Types and Variables
            //Console.Write("Please input number here: ");
            //string input = Console.ReadLine();

            //if (input.Contains('.') || input.Contains(','))
            //{
            //    Console.WriteLine("Rainy");
            //}
            //else
            //{
            //    long number = long.Parse(input);
            //    if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
            //    {
            //        Console.WriteLine("Sunny");
            //    }
            //    else if (number >= int.MinValue && number <= int.MaxValue)
            //    {
            //        Console.WriteLine("Cloudy");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Windy");
            //    }
            //}

            ////Ex.6 from second file Data Types and Variables
            //Console.Write("Please input number type: ");
            //string numberType = Console.ReadLine();

            //if (numberType == "sbyte" || numberType == "int" || numberType == "long")
            //{
            //    var absoluteMaxValue = long.MaxValue;
            //    switch (numberType)
            //    {
            //        case "sbyte":
            //            absoluteMaxValue = sbyte.MaxValue;
            //            break;
            //        case "int":
            //            absoluteMaxValue = int.MaxValue;
            //            break;
            //    }
            //    Console.Write("Please insert number of Ids to receive: ");
            //    byte numberOfIds = byte.Parse(Console.ReadLine());
            //    if (numberOfIds < 1 && numberOfIds > 20)
            //    {
            //        Console.WriteLine("Number of Ids to receive should be between 1 and 20. Please try again.");
            //    }
            //    else
            //    {
            //        var currentMaxId = long.MinValue;
            //        for (int i = 1; i <= numberOfIds; i++)
            //        {
            //            Console.Write($"Please insert Id number {i}: ");
            //            long insertedId = long.Parse(Console.ReadLine());
            //            if (currentMaxId < insertedId && insertedId <= absoluteMaxValue)
            //            {
            //                currentMaxId = insertedId;
            //            }
            //        }
            //        Console.WriteLine(currentMaxId);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You have inserted not accepted number type! Please try again");
            //}

            ////Ex.7 from second file Data Types and Variables
            //Console.Write("Please input number type: ");
            //string numberType = Console.ReadLine();

            //if (numberType == "sbyte" || numberType == "int" || numberType == "long")
            //{
            //    var absoluteMaxValue = long.MaxValue;
            //    switch (numberType)
            //    {
            //        case "sbyte":
            //            absoluteMaxValue = sbyte.MaxValue;
            //            break;
            //        case "int":
            //            absoluteMaxValue = int.MaxValue;
            //            break;
            //    }
            //    Console.Write("Please insert number of Ids to receive: ");
            //    byte numberOfIds = byte.Parse(Console.ReadLine());
            //    if (numberOfIds < 1 && numberOfIds > 20)
            //    {
            //        Console.WriteLine("Number of Ids to receive should be between 1 and 20. Please try again.");
            //    }
            //    else
            //    {
            //        var currentMaxId = long.MinValue;
            //        for (int i = 1; i <= numberOfIds; i++)
            //        {
            //            Console.Write($"Please insert Id number {i}: ");
            //            long insertedId = long.Parse(Console.ReadLine());
            //            if (currentMaxId < insertedId && insertedId <= absoluteMaxValue)
            //            {
            //                currentMaxId = insertedId;
            //            }
            //        }

            //        int durationOfSentence = 0;
            //        if (currentMaxId > 0)
            //        {
            //            durationOfSentence = (int)Math.Ceiling(currentMaxId / (double)sbyte.MaxValue);

            //        }
            //        else if (currentMaxId < 0)
            //        {
            //            durationOfSentence = (int)Math.Ceiling(currentMaxId / (double)sbyte.MinValue);

            //        }

            //        if (durationOfSentence == 1)
            //        {
            //            Console.WriteLine($"Prisoner with id {currentMaxId} is sentenced to {durationOfSentence} year");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Prisoner with id {currentMaxId} is sentenced to {durationOfSentence} years");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You have inserted not accepted number type! Please try again");
            //}

            //Ex.8 from second file Data Types and Variables
            Console.Write("Please insert first number here: ");
            long firstNumber = long.Parse(Console.ReadLine());
            Console.Write("Please insert second number here: ");
            long secondNumber = long.Parse(Console.ReadLine());

            long totalPriceofMaterials = 0;

            if (firstNumber >= 0 && firstNumber <= 127)
            {
                totalPriceofMaterials = (firstNumber * 4) + (secondNumber * 10);
                Console.WriteLine(totalPriceofMaterials);
            }
            else
            {
                totalPriceofMaterials = (firstNumber * 10) + (secondNumber * 4);
                Console.WriteLine(totalPriceofMaterials);
            }

        }
    }
}
