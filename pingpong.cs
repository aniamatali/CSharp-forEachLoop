using System;

public class PingPong
{
  public static void Main()
  {

    int[] numbers = {};

    Console.WriteLine("Enter a number");
    string userInput = Console.ReadLine();
    int intUserInput = int.Parse(userInput);

    for (int index = 1; index < intUserInput; index++) {
      if (index % 15 == 0)
    {
      Console.WriteLine("Ping-Pong");
    } else if (index % 5 == 0)
    {
      Console.WriteLine("Pong");
    } else if (index % 3 == 0) {
      Console.WriteLine("Ping");
    }
}
  }
}
