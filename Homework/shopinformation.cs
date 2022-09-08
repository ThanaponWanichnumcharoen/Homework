public class Shop 
{
 string name ;
 string owner ;
 string number ;
 string value ;

public Shop (string name,string owner , string number , string value)
{
    this.name = name;
    this.owner = owner;
    this.number = number;
    this.value = value;
}

public void Printshop()
{
    Console.WriteLine("------------Shop Information----------------");
    Console.WriteLine("Name: {0}",name);
    Console.WriteLine("Number: {0}",number);
    Console.WriteLine("Owner Name: {0}",owner);
    Console.WriteLine("Registered Value: {0}",value);
    Console.WriteLine("--------------------------------------------");

}



}

