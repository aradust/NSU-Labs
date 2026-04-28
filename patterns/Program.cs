//Upcasting

Employee employee = new Employee("Oleg", "Bebrov");
Person person = employee;

Console.WriteLine(employee.Company); //можно
//Console.WriteLine(person.Company.ToString()); нельзя

Console.WriteLine(person.Name); //можно

Person oleg = new Employee("Olig", "Bibrov");

//oleg.Name только так

Object person1 = new Employee("Oleg1", "Bebrov1");
Object person2 = new Client("Oleg2", "Bebrov2");
Object person3 = new Person("Oleg3");


//DownCasting
Person person4 = new Employee("employee", "company");

//Employee employee5 = person4; нельзя
Employee employee5 = (Employee)person4;

Object obj1 = new Employee("employee2", "company2");
Person person5 = (Person)obj1;
//person5.Name
Object obj2 = new Employee("employee3", "company3");
Client client5 = (Client)obj2; //ошибка
//client5.Bank;
Object obj3 = new Employee("employee4", "company4");
//Employee employee6 = (Client)obj3; нельзя

//string bank = ((Client)obj3).Bank; //опасно, так как ошибка в рантайме, но не на этапе компиляции.

//Employee employee7 = new Object(); нельзя
//Employee employee7 = new Person("Oleg"); нельзя
/*

Person person8 = new Person("Bob");
//Employee employee2 = (Employee)person; нельзя при этом ошибка рантайма

Employee? employee2 = person as Employee;

Person person1 = new Person("oleg1"); //можно
//Person person2 = new Object(); //нельзя
Person person3 = new Employee("oleg3", "bebrov3"); //можно

Employee employee = new Employee("oleg", "bebrov");
Person person4 = employee as Person;
//person4.Name;
Employee? employee5 = person4 as Employee;
//employee5.Name; employee5.Company;
Client? client5 = person4 as Client; //нельзя, но не упадет*/
public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"Person {Name}");
    }
}

public class Employee : Person
{
    public string Company { get; set; }

    public Employee(string name, string company) : base(name)
    {
        Company = company;
    }
}

public class Client : Person
{
    public string Bank { get; set; }

    public Client(string name, string bank) : base(name)
    {
        Bank = bank;
    }
}