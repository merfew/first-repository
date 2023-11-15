using System.Net;

class Student
{
    private string name = "Светлана Добрынина";
    private int age;
    private string university = "Политех";


    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
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
    public string University
    {
        get
        {
            return university;
        }
        set
        {
            university = value;
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
        return $"Имя: {Name}, Возраст: {Age}, Университет: {University}, Проверка: {Check}";
    }

    public string GetInfo (bool includeIntProperty)
    {
        if (includeIntProperty == true)
        {
            return GetInfo();
        }
        else
        {
            return $"Имя: {Name}, Университет: {University}, Проверка: {Check}";
        }
    }
}

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(student.GetInfo(false));
        }
    }
}