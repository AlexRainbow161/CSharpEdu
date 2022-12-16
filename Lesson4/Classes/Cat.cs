namespace Classes;

public class Cat : HomeAnimal {
    public Cat(string name, string owner) : base(name, owner) {
    }

    public override string Family => "Cats";

    public override void MakeSound() {
        Console.WriteLine("Meow");
    }
}
