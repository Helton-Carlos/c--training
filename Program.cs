// See https://aka.ms/new-console-template for more information
using TestPDO;

class Program
{
  static void Main()
  {
    Item ball = new Item();
    ball.Product = "BOLA";
    ball.Unid = 4;
    ball.Price = 25M;
    Console.WriteLine(ball.Total);

    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine($"Value Roll:{roll}");

    int firstValue = 700;
    int secondValue = 950;
    int largerValue;
    largerValue = Math.Max(firstValue, secondValue);
    Console.WriteLine($"Max Value: {largerValue}");

    string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

    foreach (string orderID in orderIDs)
    {
      if (orderID.StartsWith("C"))
      {
        Console.WriteLine(orderID);
      }
    }

    //
    string fruit = "cherry";

    switch (fruit)
    {
      case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

      case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

      case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
    }
  }
}
