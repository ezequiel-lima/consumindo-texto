namespace ExercicioConsumindoText
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
    }
}
