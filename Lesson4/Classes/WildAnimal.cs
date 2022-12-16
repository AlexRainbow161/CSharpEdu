namespace Classes;

public abstract class WildAnimal : Animal {
    public WildAnimal(string name, string lifeArea) : base(name) {
        LifeArea = lifeArea;
    }
    public string LifeArea { get; }
}
