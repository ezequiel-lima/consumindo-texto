using ExercicioConsumindoText;
using System.Globalization;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

if (path is null)
    return;

using StreamReader file = new StreamReader(path);
string? line;
List<Product> products = new List<Product>();

while ((line = file.ReadLine()) is not null)
{ 
    string[] text = line.Split(',');
    string name = text[0];
    double price = double.Parse(text[1], CultureInfo.InvariantCulture);

    Product product = new Product(name, price);
    products.Add(product);
}

Console.WriteLine($"Average price: {products.Average(x => x.Price).ToString("F2")}"); 
products.OrderByDescending(x => x.Name).ToList().ForEach(x =>  Console.WriteLine(x.Name));

file.Close();

Console.ReadKey();