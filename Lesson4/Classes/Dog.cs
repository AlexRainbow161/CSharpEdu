namespace Classes;

public class Dog : HomeAnimal {
    public Dog(string name, string owner) : base(name, owner) {
    }

    public override string Family => "Dogs";

    public override void MakeSound() {
        Console.WriteLine("Bark");
    }
}
