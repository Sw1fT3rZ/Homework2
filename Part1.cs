using System;

class Money
{
    private int wholePart;  // Ціла частина (наприклад, долари, євро, гривні)
    private int fractionalPart;  // Копійки (наприклад, центи, євроценти, копійки)

    public Money(int wholePart, int fractionalPart)
    {
        this.wholePart = wholePart;
        this.fractionalPart = fractionalPart;
    }

    public void SetValues(int whole, int fractional)
    {
        wholePart = whole;
        fractionalPart = fractional;
    }

    public void Show()
    {
        Console.WriteLine($"{wholePart}.{fractionalPart:D2} грн");
    }

    public int WholePart
    {
        get { return wholePart; }
        set { wholePart = value; }
    }

    public int FractionalPart
    {
        get { return fractionalPart; }
        set { fractionalPart = value; }
    }
}

class Product : Money
{
    private string productName;

    public Product(int wholePart, int fractionalPart, string productName)
        : base(wholePart, fractionalPart)
    {
        this.productName = productName;
    }

    public void DecreasePrice(int whole, int fractional)
    {
        int totalFractional = FractionalPart + WholePart * 100;
        int decreaseFractional = fractional + whole * 100;

        int newFractional = totalFractional - decreaseFractional;

        if (newFractional < 0)
        {
            Console.WriteLine("Ціна не може бути меншою за 0");
            return;
        }

        WholePart = newFractional / 100;
        FractionalPart = newFractional % 100;
    }

    public void ShowProduct()
    {
        Console.WriteLine($"Продукт: {productName}");
        Console.Write("Ціна: ");
        Show();
    }
}

class Program
{
    static void Main()
    {
        // Встановлення кодування консолі для підтримки української мови
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Product product = new Product(15, 75, "Яблуко");
        product.ShowProduct();

        Console.WriteLine("Зменшення ціни на 5.25:");
        product.DecreasePrice(5, 25);
        product.ShowProduct();

        Console.WriteLine("Зменшення ціни на 11.50:");
        product.DecreasePrice(11, 50);
        product.ShowProduct();
    }
}
