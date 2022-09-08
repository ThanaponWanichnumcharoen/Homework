public class Moneyy
{ 

    public static void Count(double money,double amount)
    {   
        if (money / 1000 != 0)
        {
            amount = money/1000;
            money = money%1000;
            Console.WriteLine("1000: {0}",Math.Floor (amount));
        }
        if (money / 500 != 0)
        {
            amount = money/500;
            money = money%500;
            Console.WriteLine("500: {0}",Math.Floor (amount));
        }
         if (money / 100 != 0)
        {
            amount = money/100;
            money = money%100;
            Console.WriteLine("100: {0}",Math.Floor (amount));
        }
         if (money / 50 != 0)
        {
            amount = money/50;
            money = money%50;
            Console.WriteLine("50: {0}",Math.Floor (amount));
        }
         if (money / 20 != 0)
        {
            amount = money/20;
            money = money%20;
            Console.WriteLine("20: {0}",Math.Floor (amount));
        }
          if (money / 10 != 0)
        {
            amount = money/10;
            money = money%10;
            Console.WriteLine("10: {0}",Math.Floor (amount));
        }
         if (money / 2 != 0)
        {
            amount = money/2;
            money = money%2;
            Console.WriteLine("2: {0}",Math.Floor (amount));
        }
        if (money / 1 != 0)
        {
            amount = money/1;
            money = money%1;
            Console.WriteLine("1: {0}",Math.Floor (amount));
        }
        if (money / 0.50 != 0)
        {
            amount = money/0.50;
            money = money%0.50;
            Console.WriteLine("0.50: {0}",Math.Floor (amount));
        }
        if (money / 0.25 != 0)
        {
            amount = money/0.25;
            money = money%0.25;
            Console.WriteLine("0.25: {0}",Math.Floor (amount));
        }

    }
    



}
