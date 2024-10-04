using System;

class MusicalInstrument
{
    protected string name;
    protected string description;
    protected string history;

    public MusicalInstrument(string name, string description, string history)
    {
        this.name = name;
        this.description = description;
        this.history = history;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{name} видає характерний звук.");
    }

    public void Show()
    {
        Console.WriteLine($"Назва інструменту: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис: {description}");
    }

    public void History()
    {
        Console.WriteLine($"Історія: {history}");
    }
}

class Violin : MusicalInstrument
{
    public Violin() : base("Скрипка", "Смичковий струнний інструмент.", "З'явилася у XVI столітті в Італії.")
    { }

    public override void Sound()
    {
        Console.WriteLine($"{name} видає високий та мелодійний звук.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone() : base("Тромбон", "Мідний духовий інструмент.", "З'явився у XV столітті.")
    { }

    public override void Sound()
    {
        Console.WriteLine($"{name} видає глибокий та потужний звук.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Укулеле", "Гавайський струнний інструмент.", "Популяризований у XIX столітті.")
    { }

    public override void Sound()
    {
        Console.WriteLine($"{name} видає легкий, дзвінкий звук.");
    }
}

class Cello : MusicalInstrument
{
    public Cello() : base("Віолончель", "Смичковий струнний інструмент великого розміру.", "З'явилася у XVI столітті.")
    { }

    public override void Sound()
    {
        Console.WriteLine($"{name} видає глибокий і багатий звук.");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;  

        Violin violin = new Violin();
        Trombone trombone = new Trombone();
        Ukulele ukulele = new Ukulele();
        Cello cello = new Cello();

        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();

        trombone.Show();
        trombone.Sound();
        trombone.Desc();
        trombone.History();

        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();

        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();
    }
}
