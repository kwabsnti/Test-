namespace skillTest;

public class Dog
{
   public int ID { get; set; }
   public string Name { get; set; }
   public string Race { get; set; }
   public int YearOfBirth { get; set; }
   public Dog(int iD, string name, string race, int yearOfBirth)
   {
      ID = ID;
      Name = name;
      Race = race; 
      YearOfBirth = yearOfBirth;
   }
   
   public override string ToString()
   {
      return $"ID:{ID} Name:{Name},Race:{Race}, YearOfBirth:{YearOfBirth}";
   }

}


