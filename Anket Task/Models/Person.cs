namespace Anket_Task.Models;

public class Person
{
    public Person() { }
    public Person(string name, string surname, string fathersName, string country, string city, string phoneNumber, string birthDate)
    {
        Name = name;
        Surname = surname;
        FathersName = fathersName;
        Country = country;
        City = city;
        PhoneNumber = phoneNumber;
        BirthDate = birthDate;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string FathersName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string BirthDate { get; set; }
    public string Gender { get; set; }

}
