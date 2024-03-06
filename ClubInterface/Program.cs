using System;

interface IClub
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string Fullname();
}

class ClubMember : IClub
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string AdditionalInfo { get; set; }
    public DateTime JoinDate { get; set; }

    public ClubMember()
    {
        Id = 0;
        FirstName = "Kayden";
        LastName = "Krumrie";
    }

    public ClubMember(int id, string firstName, string lastName, string email, string additionalInfo, DateTime joinDate)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        AdditionalInfo = additionalInfo;
        JoinDate = joinDate;
    }

    public void DisplayInformation()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Full Name: {Fullname()}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Additional Info: {AdditionalInfo}");
        Console.WriteLine($"Join Date: {JoinDate}");
    }
    public string Fullname()
    {
        return $"{FirstName} {LastName}";
    }
}

class Program
{
    static void Main()
    {
        ClubMember member = new ClubMember(1, "Kayden", "Krumrie", "krumrik@mail.nmc.edu", "President of the Club", DateTime.Now);

        member.DisplayInformation();
    }
}

