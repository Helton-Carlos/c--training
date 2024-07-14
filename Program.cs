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

    int hero = 10;
    int monster = 10;

    Random dice = new Random();

    do
    {
      int roll = dice.Next(1, 11);
      monster -= roll;
      Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

      if (monster <= 0) continue;

      roll = dice.Next(1, 11);
      hero -= roll;
      Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

    } while (hero > 0 && monster > 0);

    Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
  }
}
