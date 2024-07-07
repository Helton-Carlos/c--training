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
  }
}
