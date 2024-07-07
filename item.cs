namespace TestPDO
{
  public class Item
  {
    private string _product = "";
    private int _unid;
    private decimal _price;

    public string Product
    {
      get { return _product; }
      set
      {
        if (String.IsNullOrEmpty(value))
        {
          throw new ArgumentNullException("Produto não encontrado");
        }

        _product = value;
        Console.WriteLine(value);
      }
    }

    public int Unid
    {
      get { return _unid; }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentNullException("Adicione no minimo 1 unidade!");
        }

        _unid = value;
        Console.WriteLine(value);
      }
    }

    public decimal Price
    {
      get { return _price; }
      set
      {
        if (value <= 0)
        {
          throw new ArgumentNullException("Adicione no minimo 1 unidade!");
        }

        _price = value;
        Console.WriteLine(value);
      }
    }

    public decimal Total => _price * _unid;
  }
}