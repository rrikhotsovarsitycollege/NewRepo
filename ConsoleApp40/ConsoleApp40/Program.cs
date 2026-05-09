namespace ConsoleApp40
{
    public class Program
    {
        static void Main(string[] args)
        {         

            Dog dog1;
            dog1 = new Dog();
            Console.WriteLine("Dog1 details...");
            Console.WriteLine(dog1.getColor());
            Console.WriteLine(dog1.getBreed());
            Console.WriteLine(dog1.getAge());

            string userColor;
            Console.Write("Enter a color : ");
            userColor = Console.ReadLine();

            dog1.setColor(userColor);
            Console.WriteLine("Dog1's new color...");
            Console.WriteLine(dog1.getColor());

            Dog dog2;
            dog2 = new Dog();
            Console.WriteLine("Dog2 details...");
            Console.WriteLine(dog2.getColor());
            Console.WriteLine(dog2.getBreed());
            Console.WriteLine(dog2.getAge());

            Dog dog3;
            dog3 = new Dog("black", "Rotteweiller", 2);
            Console.WriteLine("Dog3 details...");
            Console.WriteLine(dog3.getColor());
            Console.WriteLine(dog3.getBreed());
            Console.WriteLine(dog3.getAge());
        }

    }
}
