/*UniversalPerson<int> person1 = new UniversalPerson<int>(5);
UniversalPerson<string> person2 = new UniversalPerson<string>("r");
Person<string> person3 = new UniversalPerson<string>("a");
UniversalPerson<string> person4 = (UniversalPerson<string>)person3;*/

public class Person<T>
{
    T ID { get;}

    public Person (T id)
    {
        this.ID = id;
    }
}

public class UniversalPerson<T> : Person<string>
{
    public T Code { get;}
    public UniversalPerson(string id, T code) : base(id)
    {
        this.Code = code;
    }
}
//для ограничений используется слово where