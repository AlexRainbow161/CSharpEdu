namespace Classes;

public class Lion : WildAnimal {
    public Lion(string name, string lifeArea) : base(name, lifeArea) {
    }

    public override string Family {
        get {
            return "Cats";
        }
    }

    public override void MakeSound() {
        Console.WriteLine("Roar");
    }
}
