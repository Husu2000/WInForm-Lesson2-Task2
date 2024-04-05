using System.Text.RegularExpressions;

namespace WinFormsApp3;

public class User
{
    private string _name;

    public string Name
    {
        get;
        set;
    }
    private string _surname;

    public string Surname
    {
        get;
        set;
    }

    private string _country;
    public string Country
    {
        get;
        set;
    }

    private string profession;

    public string Profession
    {
        get;
        set;
    }

    private string _city;
    public string City
    {
        get;
        set;
    }


    private string _phone;
    public string Phone
    {
        get; set;
    }

    public DateTime Date { get; set; }
    public string male { get; set; }

    public User(string name, string surname, string country, string profession, string city, string phone, DateTime date, string male)
    {
        Name = name;
        Surname = surname;
        Country = country;
        Profession = profession;
        City = city;
        Phone = phone;
        Date = date;
        this.male = male;
    }
    public User()
    {
        _name = string.Empty;
        _surname = string.Empty;
        _phone = string.Empty;
        _city = string.Empty;
        male = string.Empty;
        Date = new();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nSurname: {Surname}\nProfession: {Profession}\nCountry: {Country}\nCity: {City}\nPhone: {Phone}\nDate: {Date}\nMale: {male}";
    }

}
