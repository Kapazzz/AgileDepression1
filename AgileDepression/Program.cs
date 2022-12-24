using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Firstname { get; set; }
    public string Password { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Interests { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }

    public User(int id, string firstname,string username , string password, string lastname, string email, string interests, int age, string sex)
    {
        this.Id = id;
        this.Username = username;
        this.Firstname = firstname;
        this.Password = password;
        this.LastName = lastname;
        this.Email = email;
        this.Interests = interests;
        this.Age = age;
        this.Sex = sex;
    }
}

public class Program
{
    static void Main(string[] args)
    { 
        User Giorgos = new User(1, "Giorgos","User1" , "test@123", "Papadopoulos", "test@hotmail.com", "football", 34, "male");
        User Alex = new User(2, "Alex", "User2" , "test@123", "Kapasakalis", "test1@hotmail.com", "video games", 30, "male");
        User Thomais = new User(3, "Thomais", "User3" , "test@123", "Papadopoulos", "test2@hotmail.com", "Dungeons and Dragons", 24, "female");
        User Thanos = new User(4, "Thanos", "User4" , "test@123", "Roumpos", "test3@hotmail.com", "strip dancing", 28, "non binary");
        User Alexandru = new User(5, "Alexandru", "User5" , "test@123", "Savu", "test4@hotmail.com", "World of Warcraft", 25, "male");
        User Hlias = new User(6, "Hlias", "User6" ,"test@1234", "Tsellos", "test5@hotmail.com", "foortbal", 26, "male");
        List<User> users = new List<User>() { Giorgos, Alex, Thomais, Thanos, Alexandru, Hlias };


        List<string> UserList = new List<string>();
        UserList = users.Select(x => x.Username).ToList();
        List<string> PasswordList = new List<string>();
        PasswordList = users.Select(x => x.Password).ToList();

        Dictionary<string,string> credentials = new Dictionary<string, string>();
        credentials.Add(Giorgos.Username, Giorgos.Password);
        credentials.Add(Alex.Username, Alex.Password);
        credentials.Add(Thomais.Username, Thomais.Password);
        credentials.Add(Alexandru.Username, Alexandru.Password);
        credentials.Add(Hlias.Username, Hlias.Password);

        bool access = false;

        do
        {
            Console.WriteLine("Welcome to the AgileDepression programm");
            Console.WriteLine("Give me your Username: ");
            string tempusername = Console.ReadLine();
            Console.WriteLine("Give me your Password: ");
            string temppassword = Console.ReadLine();

            foreach (KeyValuePair<string, string> entry in credentials)
            {
                if (entry.Key == tempusername)
                {
                    if (entry.Value == temppassword)
                    {
                        access = true;
                    }
                    else
                    {
                        access = false;
                    }
                }
                else
                {
                    access = false;
                }
            }
        }
        while (false);

        Console.WriteLine("You are Valid");
    }
}