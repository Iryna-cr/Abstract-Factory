using System;

class RomanticSet
{
    public string CreateBouquet() => "Букет троянд ";
    public string CreateGift() => "Цукерки ";
}

class ClassicSet
{
    public string CreateBouquet() => "Букет тюльпанів ";
    public string CreateGift() => "Листівка ";
}

class Program
{
    static void Main()
    {
        var romantic = new RomanticSet();
        var classic = new ClassicSet();

        Console.WriteLine(romantic.CreateBouquet() + " + " + romantic.CreateGift());
        Console.WriteLine(classic.CreateBouquet() + " + " + classic.CreateGift());
    }
}




