# Abstract-Factory

Ідея абстрактної фабрики: 

створення групи пов’язаних об’єктів (наприклад, букет і упаковка) через одну фабрику.

Як працює код: 

є “фабрика квітів”, яка створює відповідні частини — троянду + коробку, або тюльпан + стрічку.

Навіщо: 

зручно міняти цілі набори об’єктів, не змінюючи решту програми.

## Код
```csharp
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

```
## Результат
![Результат виконання](sc2.png)
