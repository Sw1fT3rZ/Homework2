using System;

struct DecimalNumber
{
    public int DecimalValue;

    public DecimalNumber(int value)
    {
        DecimalValue = value;
    }

    public string ToBinary()
    {
        return Convert.ToString(DecimalValue, 2);
    }

    public string ToOctal()
    {
        return Convert.ToString(DecimalValue, 8);
    }

    public string ToHexadecimal()
    {
        return Convert.ToString(DecimalValue, 16).ToUpper();
    }

    public void ShowConversions()
    {
        Console.WriteLine($"Десяткове число: {DecimalValue}");
        Console.WriteLine($"Двійкова система: {ToBinary()}");
        Console.WriteLine($"Вісімкова система: {ToOctal()}");
        Console.WriteLine($"Шістнадцяткова система: {ToHexadecimal()}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  // Додаємо підтримку українських символів

        Console.WriteLine("Введіть десяткове число:");
        int value = int.Parse(Console.ReadLine());

        DecimalNumber number = new DecimalNumber(value);
        number.ShowConversions();
    }
}
