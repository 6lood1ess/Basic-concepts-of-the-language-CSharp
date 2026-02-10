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
      int minimumNumber = 100;

      Console.Write("\nEnter the number x (x >= 100): ");
      startingNumberX = Convert.ToInt32(Console.ReadLine());

      if (startingNumberX < minimumNumber) {
        Console.WriteLine("Error: number must be >= 100");
      } else {
        endingNumberN = TransformNumber(startingNumberX);
        Console.WriteLine($"Transformation result: {endingNumberN}");
      }
    } else {
      Console.WriteLine("The task code is entered incorrectly. Please, restart the program and try again");
      return;
    }
  }
}
