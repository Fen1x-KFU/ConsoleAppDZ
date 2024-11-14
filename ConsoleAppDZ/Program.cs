                            //Выведите на экран информацию о каждом типе данных в виде:
                            //Тип данных – максимальное значение – минимальное значение
using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("byte - min = 0 - max = 255");
        Console.WriteLine("sbyte - min = -128 - max = 127");
        Console.WriteLine("short - min = -32768 - max = 32767");
        Console.WriteLine("ushort - min = 0 - max = 65535");
        Console.WriteLine("int - min = -2147483648 - max = 2147483647");
        Console.WriteLine("uint - min = 0 - max = 4294967295");
        Console.WriteLine("lnog - min = -9 223372036854775808 - max = 9223372036854775807");
        Console.WriteLine("ulong - min = 0 - max = 18446744073709551615");
        Console.WriteLine("float - min = -3.402823e38 - max = 3.402823e38");
        Console.WriteLine("double - min = -1.797693e308 - max = 1.797693e308");
        Console.WriteLine("decimal - min = -7.922816e28 - max = 7.922816e28");
    }
}

                            //Напишите программу, в которой принимаются данные пользователя в виде имени,
                            //города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
                            //переменной, а затем распечатайте всю информацию в правильном формате.
using System;

// Определение собственного типа данных в виде класса
public class Person
{
    // Поля (переменные) класса
    public string Name;
    public int Age;
    public string Town;
    public string Pin;

    // Конструктор класса для инициализации объектов
    public Person(string name, int age, string town, string pin)
    {
        Name = name;
        Age = age;
        Town = town;
        Pin = pin;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте! Введите своё имя пожалуйста:");
        string nameee = Console.ReadLine();

        Console.WriteLine("Введите свой возраст пожалуйста:");
        int ageee;
        int.TryParse(Console.ReadLine(), out ageee);

        Console.WriteLine("Введите свой город пожалуйста:");
        string townnn = Console.ReadLine();

        Console.WriteLine("Введите свой PIN-code пожалуйста:");
        string pinnn = Console.ReadLine();

        // Создание объекта собственного типа данных Person
        Person person1 = new Person(nameee, ageee, townnn, pinnn);

        // Использование метода для отображения информации о человеке
        Console.WriteLine($"Вот ваше имя: {person1.Name}");
        Console.WriteLine($"Вот ваш возраст: {person1.Age}");
        Console.WriteLine($"Вот название вашего города: {person1.Town}");
        Console.WriteLine($"Вот ваш пин код: {person1.Pin}");
    }
}

                            //Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на
                            //строчные.
using System;
