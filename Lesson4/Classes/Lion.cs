namespace Classes;

public class Lion : WildAnimal {
    public Lion(string name, string lifeArea) : base(name, lifeArea) {
    }

    public override string Family => "Cats";

    public override void MakeSound() {
        Console.WriteLine("Roar");
    }
}
