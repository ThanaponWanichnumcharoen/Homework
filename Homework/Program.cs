public class Program
{
  static void Main (String[] args)
  {
     string name = nameshop();
     string number = numbershop();
     string owner = ownershop();
     string value = valueshop();
     Shop info = new Shop(name,number,owner,value);
     info.Printshop();

     double amount = 0;
     double ngen = moneycal();
     double amount_ = ConvertStringToDouble(value);
     Moneyy money = new Moneyy();
     Moneyy.Count(ngen,amount);
      
  }

  public static string nameshop()
  {
    Console.Write("Please input Name : ");
    return Console.ReadLine();
  }
  public static string  numbershop()
  {
     Console.Write("Please input Number : ");
     return Console.ReadLine();
  }
  public static string ownershop()
  {
      Console.Write("Please input Owner Name : ");
      return Console.ReadLine();
  }
  public static string valueshop()
  {   
       Console.Write("Please input Registered Value : ");
      return Console.ReadLine();
  }

  public static double ConvertStringToDouble(string value)
    {
        if (double.TryParse(value, out double number))
        {
            return number;
        }

        throw new Exception("Error Input Please Input your money ");
    }

  public static double moneycal()
  {
      Console.Write("Please input money: ");
      return double.Parse(Console.ReadLine());
  }
  

}
    




 

   
