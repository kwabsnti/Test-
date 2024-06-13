namespace skillTest;

public class Member
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Addresse { get; set; }
    public string BirthDate { get; set; }
    public int Phone { get; set; }
    public string Email { get; set; }
    public List<Dog> Dogs { get; set; }

    public Member(int iD, string name, string addresse, string birthDate, int phone, string email)
    {
        ID = ID;
        Name = name;
        Addresse = addresse;
        BirthDate = birthDate;
        Phone = phone;
        Email = email;
        List<Dog> dogs;
    }

    public object DogTodelete { get; private set; }

    public void RegisterDog(Dog dog)
    {
        Dogs.Add(dog);
    }

    public void PrintDogs()
    {
        foreach (var dog in Dogs)
        {
            Console.WriteLine(Dogs.ToString());
        }
    }
    public void RemoveDog(Dog dog)
    {
        Dogs.Remove(dog);
    }
    
    public override string ToString()
    {
        return $"ID:{ID} Name:{Name},Addresse:{Addresse},BirthDate:{BirthDate},Phone{Phone},Email,{Email}";
    }
}  