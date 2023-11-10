using System.Net;

class Animal
{
    private string kind = "Кот";
    private int age = 6;
    public string Name { get; set; } = "Мурзик";

    public string Kind
    {
        get
        {
            return kind;
        }
        set
        {
            kind = value;
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if(age > 0)
            {
                age = value;
            }
        }
    }

    public bool Check
    {
        get
        {
            if( age < 25)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public string GetInfo()
    {
        return $"Имя: {Name}, Вид: {Kind}, Возраст: {Age}, Проверка: {Check}";
    }

    public string GetInfo (bool includeIntProperty)
    {
        if (includeIntProperty == true)
        {
            return GetInfo();
        }
        else
        {
            return $"Имя: {Name}, Вид: {Kind}, Проверка: {Check}";
        }
    }
}

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.GetInfo());
            Console.WriteLine(animal.GetInfo(false));
        }
    }
}