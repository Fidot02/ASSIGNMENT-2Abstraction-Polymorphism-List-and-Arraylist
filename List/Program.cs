//List of fruits

using System.Collections;

List<string> fruits = new List<string>();
fruits.Add("Orange");
fruits.Add("Banana");
fruits.Add("Mango");
fruits.Add("Watermelon");
fruits.Add("Pineapple");
fruits.Add("Apple");
fruits.Add("Cherry");
fruits.Add("Pawpaw");

Dictionary<string,decimal> fruitPrices = new Dictionary<string,decimal>();
fruitPrices.Add("Orange",500);
fruitPrices.Add("Banana",800);
fruitPrices.Add("Mango",200);
fruitPrices.Add("Watermelon",1500);
fruitPrices.Add("Pineapple",650);
fruitPrices.Add("Apple",300);
fruitPrices.Add("cherry",200);
fruitPrices.Add("Pawpaw",900);

foreach (string fruit in fruits) 
{
    Console.WriteLine(fruit + " is sweet");
}
Console.WriteLine(fruits.ElementAt(3));



foreach (var fruitPrice in fruitPrices)
{
    Console.WriteLine("For " +fruitPrice.Key + " the price is " + "$" + fruitPrice.Value);
}

Console.WriteLine(fruitPrices.Keys.ElementAt(3) +" is " + "$" + fruitPrices.Values.ElementAt(3));


object oil = 25; //Boxing
ArrayList Caleb = new ArrayList();
Caleb.Add("Yam");
Caleb.Add("pepper");
Caleb.Add("salt");
Caleb.Add("GoatMeat");
Caleb.Add("water");
Caleb.Add("Maggi");
Caleb.Add(2000);
Caleb.Add(oil);
int o = (int)oil; //Unboxing

foreach (object ingredient in Caleb)
{
    Console.WriteLine("Buy " + ingredient);

}


//Console.WriteLine(Caleb[5]);
Console.WriteLine(Caleb.Count);
Console.WriteLine(Caleb[Caleb.Count - 6]);

Console.ReadKey();