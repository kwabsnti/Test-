namespace skillTest;

class Program
{
    static void Main(string[] args)
    {
        //Test af Dog klasse 
        Dog Dog1 = new Dog(101, "Mikkel", "GoldenRetriever", 2004);
        Dog Dog2 = new Dog(102, "David", "Poodle", 2004);
        
        Console.WriteLine("Dogs information:",Dog1); 
        Console.WriteLine("Dogs information:",Dog2);
        //Test af Member klassen 
        Member member = new Member(1, "nick", "Gildbrovej", "Roskildevej123,4000 Roskilde", 477534, "123@gmail.com");
        Console.WriteLine(member);
    }
    
} 