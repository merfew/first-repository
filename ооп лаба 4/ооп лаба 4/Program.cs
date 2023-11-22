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

class Add
{
    private static List<Animal> list = new List<Animal>();

    public List<Animal> list1 = list;
    public void add(Animal animal)
    {
        list.Add(animal);
    }
}

namespace laba4
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Animal animal = new Animal();
            Add add = new Add();
            add.add(animal);
            Console.WriteLine(animal.GetInfo());
            Console.WriteLine(animal.GetInfo(false));
=======
            Student student = new Student();
            Console.WriteLine(student.GetInfo());
            Console.WriteLine(student.GetInfo(false));
>>>>>>> first_branch
        }
    }
}