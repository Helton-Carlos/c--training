// See https://aka.ms/new-console-template for more information
class Program
{
  static void Main()
  {
    string[] names = { "news", "categories", "releases" };

    if (names.Length > 0)
    {
      for (int i = 0; i < names.Length; i++)
      {
        Console.WriteLine(names[i]);
      }
    }
    else
    {
      Console.WriteLine("Names no found");
    }
  }
}
