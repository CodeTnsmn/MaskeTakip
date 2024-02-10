using Business.Concrete;
using Entities.Concrete;
using System.Runtime.Versioning;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.FirstName = "ali";
        person1.LastName = "veli";
        person1.DateOfBirthYear = 1923;
        person1.NationalIdentity = 123;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        Console.ReadLine();
    }


}
