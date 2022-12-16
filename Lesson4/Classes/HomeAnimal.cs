namespace Classes;

public abstract class HomeAnimal : Animal {
    public HomeAnimal(string name, string owner) : base(name) {
        Owner = owner;
    }

    public string Owner { get; }
}
