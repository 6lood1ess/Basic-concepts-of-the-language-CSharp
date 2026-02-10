using System;

class Program {

  static void Main() {

    int taskSelection;
    int codeOfTheFirstTask = 1;
    int codeOfTheSecondTask = 2;

    Console.WriteLine("The programm has two tasks:\n" +
                      "1. Construction of the number a into n exponent\n" +
                      "2. Moving digit of the number x from the second to the last\n");

    Console.Write("Type 1 if you want to select the first task, " +
                  "or 2 if you want to choose the second task: ");
    taskSelection = Convert.ToInt32(Console.ReadLine());
    
    //Processing of the custom task selection and its implementation
    if (taskSelection == codeOfTheFirstTask) {
      int baseA, exponentN, theResultOfRaisingToTheExponent;

      Console.Write("\nEnter the exponent base: ");
      baseA = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the exponent: ");
      exponentN = Convert.ToInt32(Console.ReadLine());

      theResultOfRaisingToTheExponent = RaisingToTheExponent(baseA, exponentN);
      Console.WriteLine($"{baseA}^{exponentN} = {theResultOfRaisingToTheExponent}");

    } else if (taskSelection == codeOfTheSecondTask) {
      int startingNumberX, endingNumberN;
      int minimumNumber = 100; //Number must be >= 100

      Console.Write("\nEnter the number x (x >= 100): ");
      startingNumberX = Convert.ToInt32(Console.ReadLine());

      if (startingNumberX < minimumNumber) {
        Console.WriteLine("Error: number must be >= 100");
      } else {
        endingNumberN = TransformNumber(startingNumberX);
        Console.WriteLine($"Transformation result: {endingNumberN}");
      }
    } else {
      Console.WriteLine("The task code is entered incorrectly. " +
                        "Please, restart the program and try again");
      return;
    }
  }

  static int RaisingToTheExponent(int baseA, int exponentN) {

    //At zero exponent returns 1
    if (exponentN == 0) {
      return 1;
    }

    int theResultOfRaisingToTheExponent = baseA;

    for (int exponentIndex = 1; exponentIndex < exponentN; ++exponentIndex) {
      theResultOfRaisingToTheExponent *= baseA;
    }

    return theResultOfRaisingToTheExponent;
  }

  static int TransformNumber(int startingNumberX) {

    string startingNumberXString;
    string resultNumber;
    int minimumNumberOfDigitsInNumber = 2;
    char secondDigit; //The number we will extract from the number and place at the end

    startingNumberXString = startingNumberX.ToString();
    if (startingNumberXString.Length < minimumNumberOfDigitsInNumber) {
      return startingNumberX;
    }

    secondDigit = startingNumberXString[1];

    resultNumber = startingNumberXString.Remove(1, 1);
    resultNumber += secondDigit;

    return Convert.ToInt32(resultNumber);

  }
}
