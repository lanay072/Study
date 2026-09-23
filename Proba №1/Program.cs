Console.WriteLine("твое имя");
string name = Console.ReadLine();
if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("блять какой ты тупой");
}
else
{ Console.WriteLine("ебать ты лев");
}

Console.WriteLine("сколько лет");
int age = int.Parse(Console.ReadLine());
if (age<0 || age>120)
{ Console.WriteLine("пиздабол!"); }
else if (age <= 12)
{
    Console.WriteLine("ты пиздюк");
}
else if (age >= 13 && age < 18)
{
    Console.WriteLine("подросток");
}
else
        { Console.WriteLine("ебать ты дядя"); }

Console.WriteLine("в каком городе живёшь");
string city = Console.ReadLine();


Console.WriteLine("===== Информация о пользователе =====");
Console.WriteLine($"Тебя еблана зовут = {name}");
Console.WriteLine($"тебе ебанату {age} лет");
Console.WriteLine($"ты {city}ский хуесос");
Console.WriteLine("=====================================");
