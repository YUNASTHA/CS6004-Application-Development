class Book
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Book(string name, double price)
    {
        Name = name;
        Price = price;
    }
}