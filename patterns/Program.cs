
/*DelMessage delMessage;
DelMessage1 delMessage1;

delMessage = Message;

delMessage();

delMessage = new Person("oleg").SpeakName;

delMessage();

delMessage1 = Person.Speak;

delMessage1("oleg");*/

using System.Numerics;
using System.Security.Principal;

DelMessage? delMessage2 = new DelMessage(Message);

//delMessage2();

//delMessage2 -= Message;
//delMessage2 -= Message;
//delMessage2 -= Message;
//delMessage2 -= Message;

delMessage2 -= Message;
delMessage2 -= Message;

delMessage2?.Invoke();
DelMessage delMessage4 = new DelMessage(Message);
DelMessage delMessage5 = new DelMessage(Message);

DelMessage delMessage6 = delMessage4 + delMessage5;

Operation<int>? operation;

operation = Substraction;

operation += Addition;

Console.WriteLine(operation?.Invoke(7, 8));

operation -= Addition;

Console.WriteLine(operation?.Invoke(7, 8));

operation -= Substraction;

Operation<int> operation1 = SelectOperation<int>(OperationType.Sub);
operation1(7, 8);

Print(7)(8)(9);

Account account = new Account(500);

account.RegisterHandler(PrintConsole);

account.Take(800);

void PrintConsole(string msg)  
{
    Console.WriteLine(msg);
}

try
{
    Console.WriteLine(operation(7, 8));
}

catch (Exception ex)
{
    Console.Write(ex.Message);
}

try
{
    Person person = new Person("l");
}

catch (PersonException ex)
{
    Console.WriteLine("error");
}

void Message()
{
    Console.WriteLine("abab");
}

void Oleg()
{
    Console.WriteLine("f");
}

T Substraction<T>(T val1, T val2) where T:INumber<T>
{
    return val1 - val2;
}

T Addition<T>(T val1, T val2) where T:INumber<T>
{
    return val1 + val2; 
}

Operation<T> SelectOperation<T>(OperationType operationType) where T:INumber<T>
{
    switch (operationType)
    {
        case OperationType.Add:
            return Addition;
        case OperationType.Sub:
            return Substraction;
        default:
            return Addition;
    }

}

Oleg Print(int val)
{
    return Print;
}

delegate int Operation1(int val1, int val2);

delegate void DelMessage();

delegate void DelMessage1(string msg);

delegate T Operation<T>(T val1, T val2);

delegate Oleg Oleg(int val);

public delegate void AccountHandler(string msg);

public class Account
{
    private int sum;

    public AccountHandler? del;

    public Account(int sum)
    {
        this.sum = sum;
    }

    public void RegisterHandler(AccountHandler? del)
    {
        this.del += del;
    }

    public void UnRegisterHandler(AccountHandler? del)
    {
        this.del -= del;
    }

    public void Take(int sum)
    {
        if (sum <= this.sum)
        {
            this.sum -= sum;
            del?.Invoke("Success");
        }
        else del?.Invoke("Fail");
    }

}

public class PersonException : Exception
{
    public PersonException(string msg) : base(msg) { }
}

public class Person
{

    public string Name { get; }

    public Person(string name)
    {
        if (name != "oleg")
        {
            throw new PersonException("not oleg");
        }
        Name = name;
    }

    public static void Speak(string message)
    {
        Console.WriteLine(message);
    }

    public void SpeakName()
    {
        Console.WriteLine(Name);
    }

    public void Oleg() { Console.WriteLine("a"); }
}

public class PersonT<T> where T : class
{
    public T Data { get; set; }

    public PersonT(T data)
    {
        this.Data = data;
    }

    public void Print()
    {
        Console.WriteLine(Data);
    }
}

enum OperationType
{
    Add,
    Sub
}